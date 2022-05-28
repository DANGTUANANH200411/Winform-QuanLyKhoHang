using DesignUI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignUI
{
    public partial class fExport : Form
    {
        public fExport()
        {
            InitializeComponent();
            LoadDgvPhieuXuat();
        }

        private void LoadDgvPhieuXuat()
        {
            string query = "exec sp_TONG_PHIEUXUAT";
            dGVPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVPhieuXuat.DataSource = DataProvider.Instance.ExecuteQuery(query);
            //Chỉnh header
            dGVPhieuXuat.EnableHeadersVisualStyles = false;
            dGVPhieuXuat.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dGVPhieuXuat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "exec sp_TIM_PHIEUXUAT @MA";
            string parameter = textBoxTim.Text;
            dGVPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVPhieuXuat.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { parameter });
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ngayNhap = dGVPhieuXuat.Rows[dGVPhieuXuat.CurrentRow.Index].Cells[1].Value.ToString();
            string month = ngayNhap.Substring(0, 1);
            string year = ngayNhap.Substring(5, 4);
            if (DateTime.Now.Year.ToString() == year && DateTime.Now.Month.ToString() == month)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn thực sự muốn xóa phiếu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = dGVPhieuXuat.CurrentRow.Index;
                    string idPX = dGVPhieuXuat.Rows[i].Cells[0].Value.ToString();
                    string query = "exec sp_XOA_PHIEUXUAT @MA";

                    int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idPX });
                    if (data > 0)
                    {
                        MessageBox.Show("Phiếu có mã " + idPX + " đã được xóa", "Xác nhận");
                        LoadDgvPhieuXuat();
                    }
                }
            }
            else
                MessageBox.Show("Chỉ có thể xóa những phiếu trong tháng hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dGVPhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void LoadCbxXuat()
        {
            // load data vao combobox Ma hang, textbox Loai hang
            string query = "select MAHG from KEHGHANG where SL>0 group by MAHG";
            cbxMaHang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxMaHang.DisplayMember = "MAHG";

            // load data vao combobox Nhan vien, textbox Ma NV
            query = "select * from NHANVIEN";
            cbxNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxNhanVien.DisplayMember = "TENNV";
            tbxMaNV.DataBindings.Clear();
            tbxMaNV.DataBindings.Add(new Binding("Text", cbxNhanVien.DataSource, "MANV"));

            // thay doi Ten CN va ma CN tuong ung
            query = "select * from CHINHANH";
            cbxCN.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxCN.DisplayMember = "TENCN";
            tbxMaCN.DataBindings.Clear();
            tbxMaCN.DataBindings.Add(new Binding("Text", cbxCN.DataSource, "MACN"));

            // tao su kien thay doi so luong
            numSLXuat.TextChanged += new EventHandler(numSLXuat_TextChanged);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // doi tab control
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPageList"]) LoadDgvPhieuXuat();
            else LoadCbxXuat();
        }

        private void cbxMaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            // gia tri Ma hang thay doi

            // thay doi Ten Hang 
            string query = "select * from HANG where MAHG = @MAHG";
            cbxTenHang.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { cbxMaHang.Text });
            cbxTenHang.DisplayMember = "TENHG";

            // thay doi Loai Hang
            tbxLoaiHang.DataBindings.Clear();
            tbxLoaiHang.DataBindings.Add(new Binding("Text", cbxTenHang.DataSource, "MALH"));

            // tim Ke Chua dang chua Loai Hang do
            query = "exec sp_TIM_KEHGHANG @MAHG";
            cbxMaKe.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { cbxMaHang.Text });
            cbxMaKe.DisplayMember = "MAKEHG";
        }

        private void tbxLoaiHang_TextChanged(object sender, EventArgs e)
        {
            // thay doi Ten Loai Hang
            string query = "select TENLH from LOAIHANG where MALH = @MALH";
            tbxTenLH.Text = Convert.ToString(DataProvider.Instance.ExecuteScalar(query, new object[] { tbxLoaiHang.Text }));
        }
        private void cbxMaKe_SelectedValueChanged(object sender, EventArgs e)
        {
            // tim so luong hang trong ke
            string query = "exec sp_TIM_SLHANG @MAHG , @MAKEHG";
            object data = DataProvider.Instance.ExecuteScalar(query, new object[] { cbxMaHang.Text, cbxMaKe.Text });
            // set gia tri max khi nhap vao so luong xuat hang
            if (!(data is DBNull) && data != null)
            {
                tbxSLTon.Text = data.ToString();
                numSLXuat.Maximum = Convert.ToInt32(data);
            }
        }

        private void numSLXuat_TextChanged(object sender, EventArgs e)
        {
            string maHG = cbxMaHang.Text.Trim();
            string maCN = tbxMaCN.Text;
            int slXuat = (int)numSLXuat.Value;
            string maKeHg = cbxMaKe.Text.Trim();
            string maNV = tbxMaNV.Text;
            if (slXuat > 0 && slXuat <= numSLXuat.Maximum &&
                maHG != "" && maCN != "" && maKeHg != "" && maNV != "")
                btnXuat.Enabled = true;
            else btnXuat.Enabled = false;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string query = "exec sp_XUATKHO @MAPX , @MAHG , @MACN , @SL , @MAKEHG , @MANV , @NGAY";
            string maPX = DateTime.Now.ToString("yyMMddHHmmss");
            string maHG = cbxMaHang.Text.Trim();
            string maCN = tbxMaCN.Text;
            int slXuat = (int)numSLXuat.Value;
            string maKeHg = cbxMaKe.Text.Trim();
            string maNV = tbxMaNV.Text;
            string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            int data = DataProvider.Instance.ExecuteNonQuery(query,
                        new object[] { maPX, maHG, maCN, slXuat, maKeHg, maNV, ngay });
            if (data > 0)
            {
                LoadCbxXuat();
                MessageBox.Show("Xuất kho thành công", "Xác nhận");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }
    }
}

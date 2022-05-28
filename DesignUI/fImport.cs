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
    public partial class fImport : Form
    {
        public fImport()
        {
            InitializeComponent();
            LoadDgvPhieuNhap();
        }

        private void LoadDgvPhieuNhap()
        {
            string query = "exec sp_TONG_PHIEUNHAP";
            dGVPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVPhieuNhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
            //Chỉnh header
            dGVPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVPhieuNhap.EnableHeadersVisualStyles = false;
            dGVPhieuNhap.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dGVPhieuNhap.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "exec sp_TIM_PHIEUNHAP @MA";
            string parameter = textBoxTim.Text;

            dGVPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVPhieuNhap.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { parameter });
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ngayNhap = dGVPhieuNhap.Rows[dGVPhieuNhap.CurrentRow.Index].Cells[1].Value.ToString();
            string month = ngayNhap.Substring(0, 1);
            string year = ngayNhap.Substring(5, 4);
            if (DateTime.Now.Year.ToString() == year && DateTime.Now.Month.ToString() == month)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn thực sự muốn xóa phiếu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = dGVPhieuNhap.CurrentRow.Index;
                    string idPN = dGVPhieuNhap.Rows[i].Cells[0].Value.ToString();
                    string query = "exec sp_XOA_PHIEUNHAP @MA";

                    int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idPN });
                    if (data > 0)
                    {
                        MessageBox.Show("Phiếu có mã " + idPN + " đã được xóa", "Xác nhận");
                        LoadDgvPhieuNhap();
                    }
                }
            }
            else
                MessageBox.Show("Chỉ có thể xóa những phiếu trong tháng hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dGVPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void LoadCbxNhap()
        {
            // load data vao combobox Ma hang, textbox Loai hang
            string query = "select * from HANG";
            cbxMaHang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxMaHang.DisplayMember = "MAHG";
            tbxLoaiHang.DataBindings.Clear();
            tbxLoaiHang.DataBindings.Add(new Binding("Text", cbxMaHang.DataSource, "MALH"));

            // load data vao combobox Nhan vien, textbox Ma NV
            query = "select * from NHANVIEN";
            cbxNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxNhanVien.DisplayMember = "TENNV";
            tbxMaNV.DataBindings.Clear();
            tbxMaNV.DataBindings.Add(new Binding("Text", cbxNhanVien.DataSource, "MANV"));

            // tao su kien thay doi so luong
            numSLNhap.TextChanged += new EventHandler(numSLNhap_TextChanged);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPageList"]) LoadDgvPhieuNhap();
            else LoadCbxNhap();
        }

        private void cbxMaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            // gia tri Ma hang thay doi
            string query = "exec sp_TIM_HANG @MAHG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { cbxMaHang.Text });
            // thay doi Ten hang
            cbxTenHang.DataSource = data;
            cbxTenHang.DisplayMember = "TENHG";
            // thay doi Ten NCC va ma NCC tuong ung
            cbxNCC.DataSource = data;
            cbxNCC.DisplayMember = "TENNCC";
            tbxMaNCC.DataBindings.Clear();
            tbxMaNCC.DataBindings.Add(new Binding("Text", cbxNCC.DataSource, "MANCC"));
        }

        private void tbxLoaiHang_TextChanged(object sender, EventArgs e)
        {
            // thay doi Ten Loai Hang
            string query = "select TENLH from LOAIHANG where MALH = @MALH";
            tbxTenLH.Text = Convert.ToString(DataProvider.Instance.ExecuteScalar(query, new object[] { tbxLoaiHang.Text }));
            // thay doi Ke Hang
            query = "SELECT MAKEHG FROM KEHANG WHERE MALH = @MALH";
            cbxMaKe.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { tbxLoaiHang.Text });
            cbxMaKe.DisplayMember = "MAKEHG";
        }

        private void cbxMaKe_SelectedValueChanged(object sender, EventArgs e)
        {
            // ke hang thay doi
            string query = "exec sp_TIM_SLTRONG @MAKEHG";
            object data = DataProvider.Instance.ExecuteScalar(query, new object[] { cbxMaKe.Text });
            tbxSLTrong.Text = data.ToString();
            // set gia tri max 
            if (!(data is DBNull)) numSLNhap.Maximum = Convert.ToInt32(data);
        }

        private void numSLNhap_TextChanged(object sender, EventArgs e)
        {
            if (numSLNhap.Value > 0 && numSLNhap.Value <= numSLNhap.Maximum)
                btnNhap.Enabled = true;
            else btnNhap.Enabled = false;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string query = "exec sp_NHAPHANG @MAPN , @MAHG , " +
                "@MANCC , @SLNHAP , @MAKEHG , @MANV , @NGAY";
            string maPN = DateTime.Now.ToString("yyMMddHHmmss");
            string maHG = cbxMaHang.Text.Trim();
            string maNCC = tbxMaNCC.Text;
            int slNhap = (int)numSLNhap.Value;
            string maKeHg = cbxMaKe.Text.Trim();
            string maNV = tbxMaNV.Text;
            string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            int data = DataProvider.Instance.ExecuteNonQuery(query,
                        new object[] { maPN, maHG, maNCC, slNhap, maKeHg, maNV, ngay });
            if (data > 0)
            {
                MessageBox.Show("Nhập hàng thành công", "Xác nhận");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }
    }
}

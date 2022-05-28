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
    public partial class fEmployee : Form
    {
        public fEmployee()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec sp_TONG_NHANVIEN");
            dGVNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVNhanVien.DataSource = data;
            //Chỉnh header
            dGVNhanVien.EnableHeadersVisualStyles = false;
            dGVNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dGVNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
        }

        private void LoadTabThem()
        {
            tbxMaNV.Text = "";
            tbxTenNV.Text = "";
            tbxChucVu.Text = "";
            tbxSDT.Text = "";
            tbxDiaChi.Text = "";
        }

        private void LoadTabCapNhat()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec sp_TONG_NHANVIEN");
            dGVNhanVien2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Chỉnh header
            dGVNhanVien2.EnableHeadersVisualStyles = false;
            dGVNhanVien2.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dGVNhanVien2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
            //Binding
            dGVNhanVien2.DataSource = data;
            if(data.Rows.Count > 0)
            {
                tbxChucVu2.Text = dGVNhanVien2.Rows[0].Cells[0].Value.ToString();
                tbxMaNV2.Text = dGVNhanVien2.Rows[0].Cells[1].Value.ToString();
                tbxTenNV2.Text = dGVNhanVien2.Rows[0].Cells[2].Value.ToString();
                cbxGioiTinh2.Text = dGVNhanVien2.Rows[0].Cells[3].Value.ToString();
                tbxSDT2.Text = dGVNhanVien2.Rows[0].Cells[4].Value.ToString();
                tbxDiaChi2.Text = dGVNhanVien2.Rows[0].Cells[5].Value.ToString();
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"]) LoadDataGridView();
            else
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"]) LoadTabThem();
                else LoadTabCapNhat();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable data;
            if (cbxTim.SelectedIndex == 0)
                data = DataProvider.Instance.ExecuteQuery("exec sp_TIM_NHANVIEN_MA @MA", new object[] { tbxTim.Text });
            else data = DataProvider.Instance.ExecuteQuery("exec sp_TIM_NHANVIEN_TEN @TEN", new object[] { tbxTim.Text });
            dGVNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVNhanVien.DataSource = data;
        }

        private void dGVNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn loại nhân viên ra khỏi danh sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int i = dGVNhanVien.CurrentRow.Index;
                string maNV = dGVNhanVien.Rows[i].Cells[1].Value.ToString();
                string query = "delete from NHANVIEN where MANV = @MANV";

                int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNV });
                if (data > 0)
                {
                    MessageBox.Show("Nhân viên có mã " + maNV + " đã được xóa", "Xác nhận");
                    LoadDataGridView();
                }
            }
        }

        private bool checkMaNV_TabThem(string maNV)
        {
            string query = "select * from NHANVIEN where MANV = @MANV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });
            if (data.Rows.Count > 0) return true;
            return false;
        }

        private void tbxMaNV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxMaNV.Text))
            {
                btnThemNV.Enabled = false;
                errorProvider1.SetError(tbxMaNV, "Không để trống ô này");
            }
            else if (checkMaNV_TabThem(tbxMaNV.Text))
            {
                btnThemNV.Enabled = false;
                errorProvider1.SetError(tbxMaNV, "Dữ liệu đã trùng");
            }
            else
            {
                errorProvider1.Clear();
                btnThemNV.Enabled = true;
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string query = "exec sp_THEM_NHANVIEN @MANV , @TENNV , @SEX , @CHUCVU , @SDT , @DIACHI";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { tbxMaNV.Text, tbxTenNV.Text,cbxGioiTinh.Text.Trim(),tbxChucVu.Text, tbxSDT.Text, tbxDiaChi.Text });
            if (data > 0)
            {
                MessageBox.Show("Nhân viên mới đã được thêm", "Xác nhận");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }

        private void dGVNhanVien2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGVNhanVien2.CurrentRow.Index;
            tbxChucVu2.Text = dGVNhanVien2.Rows[i].Cells[0].Value.ToString();
            tbxMaNV2.Text = dGVNhanVien2.Rows[i].Cells[1].Value.ToString();
            tbxTenNV2.Text = dGVNhanVien2.Rows[i].Cells[2].Value.ToString();
            cbxGioiTinh2.Text = dGVNhanVien2.Rows[i].Cells[3].Value.ToString();
            tbxSDT2.Text = dGVNhanVien2.Rows[i].Cells[4].Value.ToString();
            tbxDiaChi2.Text = dGVNhanVien2.Rows[i].Cells[5].Value.ToString();
        }

        private bool checkMaNV_TabCapNhat(string maNV, string s)
        {
            string query = "select * from NHANVIEN where MANV = @MANV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });
            if (data.Rows.Count > 0)
            {
                if (data.Rows[0]["MANV"].ToString() == s) return false;
                return true;
            }
            return false;
        }

        private void tbxMaNV2_TextChanged(object sender, EventArgs e)
        {
            int i = dGVNhanVien2.CurrentRow.Index;
            string maCN = dGVNhanVien2.Rows[i].Cells[1].Value.ToString();
            if (string.IsNullOrEmpty(tbxMaNV2.Text))
            {
                btnCapNhat.Enabled = false;
                errorProvider2.SetError(tbxMaNV2, "Không để trống ô này");
            }
            else if (checkMaNV_TabCapNhat(tbxMaNV2.Text, maCN))
            {
                btnCapNhat.Enabled = false;
                errorProvider2.SetError(tbxMaNV2, "Dữ liệu đã trùng");
            }
            else
            {
                errorProvider2.Clear();
                btnCapNhat.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhật nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int i = dGVNhanVien2.CurrentRow.Index;
                string maNV = dGVNhanVien2.Rows[i].Cells[1].Value.ToString();
                if (tbxMaNV2.Text != maNV)
                {
                    string query = "exec sp_SUA_NHANVIEN_ALL @MANVCU , @MANVMOI , @TENNV , @SEX , @CHUCVU , @SDT , @DIACHI";
                    int data = DataProvider.Instance.ExecuteNonQuery(query,
                        new object[] { maNV, tbxMaNV2.Text, tbxTenNV2.Text, cbxGioiTinh2.Text.Trim(), tbxChucVu2.Text, tbxSDT2.Text, tbxDiaChi2.Text });
                    if (data > 0) MessageBox.Show("Cập nhật thành công", "Xác nhận");
                }
                else
                {
                    string query = "exec sp_SUA_NHANVIEN @MANV , @TENNV , @SEX , @CHUCVU , @SDT , @DIACHI";
                    int data = DataProvider.Instance.ExecuteNonQuery(query,
                        new object[] { tbxMaNV2.Text, tbxTenNV2.Text, cbxGioiTinh2.Text, tbxChucVu2.Text.Trim(), tbxSDT2.Text, tbxDiaChi2.Text });
                    if (data > 0) MessageBox.Show("Cập nhật thành công", "Xác nhận");
                }
                LoadTabCapNhat();
            }
        }
    }
}

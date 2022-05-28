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
    public partial class fSupplier : Form
    {
        public fSupplier()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec sp_TONG_NCC");
            dGVNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVNCC.DataSource = data;
            //Chỉnh header
            dGVNCC.EnableHeadersVisualStyles = false;
            dGVNCC.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dGVNCC.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
        }

        private void LoadTabThem()
        {
            tbxMaNCC.Text = "";
            tbxTenNCC.Text = "";
            tbxSDT.Text = "";
            tbxDiaChi.Text = "";
            cbxLoaiHang.DataSource = DataProvider.Instance.ExecuteQuery("select * from LOAIHANG");
            cbxLoaiHang.DisplayMember = "TENLH";
            tbxMaLH.DataBindings.Clear();
            tbxMaLH.DataBindings.Add(new Binding("Text", cbxLoaiHang.DataSource, "MALH"));
        }

        private void LoadTabCapNhat()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec sp_TONG_NCC");
            dGVNCC2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVNCC2.DataSource = data;
            //Chỉnh header
            dGVNCC2.EnableHeadersVisualStyles = false;
            dGVNCC2.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dGVNCC2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
            //Binding
            cbxLoaiHang2.DataSource = DataProvider.Instance.ExecuteQuery("select * from LOAIHANG");
            cbxLoaiHang2.DisplayMember = "TENLH";
            tbxMaLH2.DataBindings.Clear();
            tbxMaLH2.DataBindings.Add(new Binding("Text", cbxLoaiHang2.DataSource, "MALH"));
            if(data.Rows.Count > 0)
            {
                tbxMaNCC2.Text = dGVNCC2.Rows[0].Cells[0].Value.ToString();
                tbxTenNCC2.Text = dGVNCC2.Rows[0].Cells[1].Value.ToString();
                tbxSDT2.Text = dGVNCC2.Rows[0].Cells[2].Value.ToString();
                tbxDiaChi2.Text = dGVNCC2.Rows[0].Cells[3].Value.ToString();
                cbxLoaiHang2.Text = dGVNCC2.Rows[0].Cells[4].Value.ToString();
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
                data = DataProvider.Instance.ExecuteQuery("exec sp_TIM_NCC_MA @MA", new object[] { tbxTim.Text });
            else data = DataProvider.Instance.ExecuteQuery("exec sp_TIM_NCC_TEN @TEN", new object[] { tbxTim.Text });
            dGVNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVNCC.DataSource = data;
        }

        private void dGVNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int i = dGVNCC.CurrentRow.Index;
                string maNCC = dGVNCC.Rows[i].Cells[0].Value.ToString();
                string query = "delete from NHACUNGCAP where MANCC = @MANCC";

                int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNCC });
                if (data > 0)
                {
                    MessageBox.Show("Nhà cung ứng có mã " + maNCC + " đã được xóa", "Xác nhận");
                    LoadDataGridView();
                }
            }
        }

        private bool checkMaNCC_TabThem(string maNCC)
        {
            string query = "select * from NHACUNGCAP where MANCC = @MANCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNCC });
            if (data.Rows.Count > 0) return true;
            return false;
        }

        private void tbxMaNCC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxMaNCC.Text))
            {
                btnThemNCC.Enabled = false;
                errorProvider1.SetError(tbxMaNCC, "Không để trống ô này");
            }
            else if (checkMaNCC_TabThem(tbxMaNCC.Text))
            {
                btnThemNCC.Enabled = false;
                errorProvider1.SetError(tbxMaNCC, "Dữ liệu đã trùng");
            }
            else
            {
                errorProvider1.Clear();
                btnThemNCC.Enabled = true;
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            string query = "exec sp_THEM_NCC @MANCC , @TENNCC , @SDT , @DIACHI , @MALH";
            int data = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { tbxMaNCC.Text, tbxTenNCC.Text, tbxSDT.Text, tbxDiaChi.Text, tbxMaLH.Text });
            if (data > 0)
            {
                MessageBox.Show("Đã thêm một nhà cung ứng mới", "Xác nhận");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }

        private void dGVNCC2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGVNCC2.CurrentRow.Index;
            tbxMaNCC2.Text = dGVNCC2.Rows[i].Cells[0].Value.ToString();
            tbxTenNCC2.Text = dGVNCC2.Rows[i].Cells[1].Value.ToString();
            tbxSDT2.Text = dGVNCC2.Rows[i].Cells[2].Value.ToString();
            tbxDiaChi2.Text = dGVNCC2.Rows[i].Cells[3].Value.ToString();
            cbxLoaiHang2.Text = dGVNCC2.Rows[i].Cells[4].Value.ToString();
        }

        private bool checkMaNCC_TabCapNhat(string maNCC, string s)
        {
            string query = "select * from NHACUNGCAP where MANCC = @MANCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNCC });
            if (data.Rows.Count > 0)
            {
                if (data.Rows[0]["MANCC"].ToString() == s) return false;
                return true;
            }
            return false;
        }

        private void tbxMaNCC2_TextChanged(object sender, EventArgs e)
        {
            int i = dGVNCC2.CurrentRow.Index;
            string maNCC = dGVNCC2.Rows[i].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(tbxMaNCC2.Text))
            {
                btnCapNhat.Enabled = false;
                errorProvider2.SetError(tbxMaNCC2, "Không để trống ô này");
            }
            else if (checkMaNCC_TabCapNhat(tbxMaNCC2.Text, maNCC))
            {
                btnCapNhat.Enabled = false;
                errorProvider2.SetError(tbxMaNCC2, "Dữ liệu đã trùng");
            }
            else
            {
                errorProvider2.Clear();
                btnCapNhat.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhật nhà cung ứng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int i = dGVNCC2.CurrentRow.Index;
                string maNCC = dGVNCC2.Rows[i].Cells[0].Value.ToString();
                if (tbxMaNCC2.Text != maNCC)
                {
                    string query = "exec sp_SUA_NCC_ALL @MANCCCU ,  @MANCCMOI , @TENNCC , @SDT , @DIACHI , @MALH";
                    int data = DataProvider.Instance.ExecuteNonQuery(query,
                        new object[] { maNCC, tbxMaNCC2.Text, tbxTenNCC2.Text, tbxSDT2.Text, tbxDiaChi2.Text, tbxMaLH2.Text.Trim() });
                    if (data > 0) MessageBox.Show("Cập nhật thành công", "Xác nhận");
                }
                else
                {
                    string query = "exec sp_SUA_NCC @MANCC , @TENNCC , @SDT , @DIACHI , @MALH";
                    int data = DataProvider.Instance.ExecuteNonQuery(query,
                        new object[] { tbxMaNCC2.Text, tbxTenNCC2.Text, tbxSDT2.Text, tbxDiaChi2.Text, tbxMaLH2.Text.Trim() });
                    if (data > 0) MessageBox.Show("Cập nhật thành công", "Xác nhận");
                }
                LoadTabCapNhat();
            }
        }
    }
}

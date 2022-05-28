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
    public partial class fBranch : Form
    {
        public fBranch()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec sp_TONG_CHINHANH");
            dGVChiNhanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVChiNhanh.DataSource = data;
            //Chỉnh header
            dGVChiNhanh.EnableHeadersVisualStyles = false;
            dGVChiNhanh.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dGVChiNhanh.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
        }

        private void LoadTabThem()
        {
            tbxMaCN.Text = "";
            tbxTenCN.Text = "";
            tbxSDT.Text = "";
            tbxDiaChi.Text = "";
        }

        private void LoadTabCapNhat()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec sp_TONG_CHINHANH");
            dGVChiNhanh2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVChiNhanh2.DataSource = data;
            //Chỉnh header
            dGVChiNhanh2.EnableHeadersVisualStyles = false;
            dGVChiNhanh2.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dGVChiNhanh2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
            //Binding
            if (data.Rows.Count > 0)
            {
                tbxMaCN2.Text = dGVChiNhanh2.Rows[0].Cells[0].Value.ToString();
                tbxTenCN2.Text = dGVChiNhanh2.Rows[0].Cells[1].Value.ToString();
                tbxSDT2.Text = dGVChiNhanh2.Rows[0].Cells[2].Value.ToString();
                tbxDiaChi2.Text = dGVChiNhanh2.Rows[0].Cells[3].Value.ToString();
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
                data = DataProvider.Instance.ExecuteQuery("exec sp_TIM_CHINHANH_MA @MA", new object[] { tbxTim.Text });
            else data = DataProvider.Instance.ExecuteQuery("exec sp_TIM_CHINHANH_TEN @TEN", new object[] { tbxTim.Text });
            dGVChiNhanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVChiNhanh.DataSource = data;
        }

        private void dGVChiNhanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa thông tin chi nhánh?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int i = dGVChiNhanh.CurrentRow.Index;
                string maCN = dGVChiNhanh.Rows[i].Cells[0].Value.ToString();
                string query = "delete from CHINHANH where MACN = @MACN";

                int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCN });
                if (data > 0)
                {
                    MessageBox.Show("Chi nhánh có mã " + maCN + " đã được xóa", "Xác nhận");
                    LoadDataGridView();
                }
            }
        }

        private bool checkMaCN_TabThem(string maCN)
        {
            string query = "select * from CHINHANH where MACN = @MACN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maCN });
            if (data.Rows.Count > 0) return true;
            return false;
        }

        private void tbxMaCN_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxMaCN.Text))
            {
                btnThemCN.Enabled = false;
                errorProvider1.SetError(tbxMaCN, "Không để trống ô này");
            }
            else if (checkMaCN_TabThem(tbxMaCN.Text))
            {
                btnThemCN.Enabled = false;
                errorProvider1.SetError(tbxMaCN, "Dữ liệu đã trùng");
            }
            else
            {
                errorProvider1.Clear();
                btnThemCN.Enabled = true;
            }
        }

        private void btnThemCN_Click(object sender, EventArgs e)
        {
            string query = "exec sp_THEM_CHINHANH @MACN , @TENCN , @SDT , @DIACHI";
            int data = DataProvider.Instance.ExecuteNonQuery(query,
                                new object[] { tbxMaCN.Text, tbxTenCN.Text, tbxSDT.Text, tbxDiaChi.Text });
            if (data > 0)
            {
                MessageBox.Show("Đã thêm một chi nhánh mới", "Xác nhận");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }

        private void dGVChiNhanh2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGVChiNhanh2.CurrentRow.Index;
            tbxMaCN2.Text = dGVChiNhanh2.Rows[i].Cells[0].Value.ToString();
            tbxTenCN2.Text = dGVChiNhanh2.Rows[i].Cells[1].Value.ToString();
            tbxSDT2.Text = dGVChiNhanh2.Rows[i].Cells[2].Value.ToString();
            tbxDiaChi2.Text = dGVChiNhanh2.Rows[i].Cells[3].Value.ToString();
        }

        private bool checkMaCN_TabCapNhat(string maCN, string s)
        {
            string query = "select * from CHINHANH where MACN = @MACN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maCN });
            if (data.Rows.Count > 0)
            {
                if (data.Rows[0]["MACN"].ToString() == s) return false;
                return true;
            }
            return false;
        }

        private void tbxMaCN2_TextChanged(object sender, EventArgs e)
        {
            int i = dGVChiNhanh2.CurrentRow.Index;
            string maCN = dGVChiNhanh2.Rows[i].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(tbxMaCN2.Text))
            {
                btnCapNhat.Enabled = false;
                errorProvider2.SetError(tbxMaCN2, "Không để trống ô này");
            }
            else if (checkMaCN_TabCapNhat(tbxMaCN2.Text, maCN))
            {
                btnCapNhat.Enabled = false;
                errorProvider2.SetError(tbxMaCN2, "Dữ liệu đã trùng");
            }
            else
            {
                errorProvider2.Clear();
                btnCapNhat.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhật chi nhánh này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int i = dGVChiNhanh2.CurrentRow.Index;
                string maCN = dGVChiNhanh2.Rows[i].Cells[0].Value.ToString();
                if (tbxMaCN2.Text != maCN)
                {
                    string query = "exec sp_SUA_CHINHANH_ALL @MACNCU ,  @MACNMOI , @TENCN , @SDT , @DIACHI";
                    int data = DataProvider.Instance.ExecuteNonQuery(query,
                        new object[] { maCN, tbxMaCN2.Text, tbxTenCN2.Text, tbxSDT2.Text, tbxDiaChi2.Text });
                    if (data > 0) MessageBox.Show("Cập nhật thành công", "Xác nhận");
                }
                else
                {
                    string query = "exec sp_SUA_CHINHANH @MACN , @TENCN , @SDT , @DIACHI";
                    int data = DataProvider.Instance.ExecuteNonQuery(query,
                        new object[] { tbxMaCN2.Text, tbxTenCN2.Text, tbxSDT2.Text, tbxDiaChi2.Text });
                    if (data > 0) MessageBox.Show("Cập nhật thành công", "Xác nhận");
                }
                LoadTabCapNhat();
            }
        }
    }
}

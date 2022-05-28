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
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
            LoadDataReport();
        }

        void LoadDataReport()
        {
            dtgvReport.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM BAOCAO");
            //Đổi tên các cột Bảng Báo cáo
            dtgvReport.Columns["MAPBC"].HeaderText = "Mã phiếu";
            dtgvReport.Columns["TENBC"].HeaderText = "Tên phiếu";
            dtgvReport.Columns["NGAYBAOCAO"].HeaderText = "Ngày lập";
            dtgvReport.Columns[0].Width = 72;
            dtgvReport.Columns[1].Width = 170;
            //Chỉnh header
            dtgvReport.EnableHeadersVisualStyles = false;
            dtgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dtgvReport.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
        }
        void LoadDataDetail(string reportID)
        {
            
            string query = "EXEC sp_XEM_CTBC @MAPBC";
            dtgvDetail.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { reportID });
            //Chỉnh header
            dtgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDetail.EnableHeadersVisualStyles = false;
            dtgvDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dtgvDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
        }
        private void btnAddReport_Click(object sender, EventArgs e)
        {
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            string query = String.Format("SELECT MAPBC FROM BAOCAO WHERE TENBC = 'Báo cáo tháng {0}-{1}'", month, year);
            object ob = DataProvider.Instance.ExecuteScalar(query);
            if (ob == null)
            {
                if (ReportDAO.Instance.AddReport(month, year))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadDataReport();
                    string reportID = "";
                    object data = DataProvider.Instance.ExecuteScalar("SELECT TOP 1 MAPBC FROM BAOCAO ORDER BY MAPBC DESC");
                    if (data != null)
                    {
                        reportID = data.ToString();
                    }
                    else
                        reportID = "BC001";
                    LoadDataDetail(reportID);
                }
                else
                    MessageBox.Show("Có lỗi khi thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Không tồn tại phiếu nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (dtgvReport.RowCount > 1)
            {
                string reportID = dtgvReport.Rows[dtgvReport.CurrentRow.Index].Cells[0].Value.ToString();
                LoadDataDetail(reportID);
            }
            else
                MessageBox.Show("Chưa có phiếu báo cáo nào được tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa báo cáo này?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (dtgvReport.RowCount > 1)
                {
                    string reportID = dtgvReport.Rows[dtgvReport.CurrentRow.Index].Cells[0].Value.ToString();
                    if (dtgvDetail.RowCount > 1)
                    {
                        if (dtgvDetail.Rows[0].Cells[0].Value.ToString() == reportID)
                        {
                            dtgvDetail.DataSource = null;
                            dtgvDetail.Rows.Clear();
                        }
                    }
                    if (ReportDAO.Instance.DeleteReport(reportID))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        LoadDataReport();
                    }
                    else
                        MessageBox.Show("Có lỗi khi xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Chưa có phiếu báo cáo nào được tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (dtgvReport.RowCount > 1)
            {
                string filePath = "";
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                }
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Đường dẫn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string reportID = dtgvReport.Rows[dtgvReport.CurrentRow.Index].Cells[0].Value.ToString();
                if (ReportDAO.Instance.ExportToExcel(reportID, filePath))
                {
                    MessageBox.Show("Đã lưu file thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Có lỗi khi lưu file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Chưa có phiếu báo cáo nào được tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

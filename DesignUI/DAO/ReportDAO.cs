using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignUI.DAO
{
    class ReportDAO
    {
        private static ReportDAO instance;

        public static ReportDAO Instance
        {
            get { if (instance == null) instance = new ReportDAO(); return instance; }
            private set { instance = value; }
        }

        private ReportDAO() { }

        public string GetReportID()
        {
            //Tự tăng MAPBC 1 đơn vị so với phiếu cuối cùng
            string reportID = "";
            string query = "SELECT TOP 1 MAPBC FROM BAOCAO ORDER BY MAPBC DESC";
            object data = DataProvider.Instance.ExecuteScalar(query);
            if (data != null)
            {
                int tmp = Convert.ToInt32(data.ToString().Substring(2)); //Lấy hàng cuối cột 0 và lấy từ kí tự thứ 2 (vd BC003 --> 3)
                //Tăng 1 đơn vị cho MAPBC (trong vd này là 3 + 1 = 4)
                if (tmp < 99)
                {
                    if (tmp < 9)
                    {
                        reportID = "BC00" + Convert.ToString(tmp + 1); //Trong trường hợp này vd trên là đúng --> MAPBC = BC004
                    }
                    else
                        reportID = "BC0" + Convert.ToString(tmp + 1);
                }
            }
            else
                reportID = "BC001";
            return reportID;
        }

        public bool AddReport( string month, string year)
        {
            int result = 0;
            string reportID = GetReportID();
            string reportName = "Báo cáo tháng " + month + "-" + year;
            result += DataProvider.Instance.ExecuteNonQuery("EXEC sp_THEM_BAOCAO @MAPBC , @TENBC", new object[] { reportID, reportName });
            if (result > 0)
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HANG");
                foreach (DataRow row in data.Rows)
                {
                    string productID = row["MAHG"].ToString();
                    string query = "EXEC sp_THEM_CTBC @MAPBC , @MAHG , @NAM , @THANG";
                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { reportID, productID, year, month });
                }
            }
            return result > 0;
        }

        public bool DeleteReport(string reportID)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC sp_XOA_BAOCAO @MAPBC", new object[] { reportID });
            return result > 0;
        }

        public bool ExportToExcel(string reportID, string filePath)
        {
            string query = "EXEC sp_XEM_CTBC @MAPBC";
            DataTable reportDetail = DataProvider.Instance.ExecuteQuery(query, new object[] { reportID });

            DataTable report = DataProvider.Instance.ExecuteQuery("SELECT * FROM BAOCAO WHERE MAPBC = @MAPBC", new object[] { reportID });
            DataRow data = report.Rows[0];

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();

            // Đặt tên cho sheet
            var workSheet = excel.Workbook.Worksheets.Add("Sheet1");

            // Điều chỉnh worksheet
            workSheet.TabColor = System.Drawing.Color.Black;
            workSheet.DefaultRowHeight = 20;
            workSheet.Row(1).Height = 30;
            workSheet.Row(1).Style.Font.Bold = true;
            workSheet.Column(3).Width = 15;
            workSheet.Column(5).Width = 25;

            //Truyển dữ liệu cần ghi và điều chỉnh font, màu
            workSheet.Cells[1, 3].Value = "PHIẾU BÁO CÁO";
            workSheet.Cells[1, 3].Style.Font.Size = 22;
            workSheet.Cells[1, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Cells[1, 3].Style.Font.Color.SetColor(System.Drawing.Color.DarkBlue);
            workSheet.Cells[1, 3, 1, 6].Merge = true;

            workSheet.Cells[2, 1].Value = "Detail:";
            workSheet.Cells[2, 1].Style.Font.Bold = true;

            workSheet.Cells[3, 2].Value = "Mã:";
            workSheet.Cells[3, 2].Style.Font.Bold = true;
            workSheet.Cells[3, 3].Value = data[0].ToString();

            workSheet.Cells[4, 2].Value = "Tên:";
            workSheet.Cells[4, 2].Style.Font.Bold = true;
            workSheet.Cells[4, 3].Value = data[1].ToString();
            workSheet.Cells[4, 3, 4, 6].Merge = true;

            workSheet.Cells[5, 2].Value = "Ngày lập:";
            workSheet.Cells[5, 2].Style.Font.Bold = true;
            workSheet.Cells[5, 3].Value = data[2].ToString();
            workSheet.Cells[5, 3, 5, 5].Merge = true;

            workSheet.Cells[6, 1].Value = "Chi tiết bảng báo cáo:";
            workSheet.Cells[6, 1].Style.Font.Bold = true;
            workSheet.Cells[7, 1].LoadFromDataTable(reportDetail, true, OfficeOpenXml.Table.TableStyles.Medium13);

            // Tạo file 
            FileStream objFileStrm = File.Create(filePath);
            objFileStrm.Close();

            // Ghi dữ liệu vào file
            File.WriteAllBytes(filePath, excel.GetAsByteArray());

            excel.Dispose();

            return true;
        }
    }
}

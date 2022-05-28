using DesignUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignUI.DAO
{
    class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        private ProductDAO() { }

        public List<Product> GetProductList()       //Trả về list sản phẩm, dùng để truyền vào DataGridView với <Product> là đối tượng được tạo ở lớp Product (DTO)
        {
            List<Product> productList = new List<Product>();
            string query = "EXEC sp_TIM_HANG_TENHG @TENHG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { "" });

            foreach (DataRow item in data.Rows)          //Lấy từng hàng trong DataTable ( 1 hàng = 1 object)
            {
                Product product = new Product(item);    //Khởi tạo Product (hàm này được tạo ở lớp Product (DTO)
                productList.Add(product);               //Thêm vào list
            }
            return productList;                         //Trả về danh sách
        }

        public List<Product> SearchProductByShelvesID(string shelvesID)     //Tìm theo mã kệ
        {
            List<Product> productList = new List<Product>();
            string query = "EXEC sp_TIM_HANG_MAKEHG @MAKEHG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { shelvesID });

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }
            return productList;
        }

        public List<Product> SearchProductByProductID(string productID)     //Tìm theo mã hàng
        {
            List<Product> productList = new List<Product>();
            string query = "EXEC sp_TIM_HANG_MAHG @MAHG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { productID });

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }
            return productList;
        }

        public List<Product> SearchProductByProductName(string productName) //Tìm theo tên hàng
        {
            List<Product> productList = new List<Product>();
            string query = "EXEC sp_TIM_HANG_TENHG @TENHG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { productName });

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }
            return productList;
        }

        public List<Product> SearchProductByKindID(string kindID)           //Tìm theo mã loại hàng
        {
            List<Product> productList = new List<Product>();
            string query = "EXEC sp_TIM_HANG_MALH @MALH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { kindID });

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }
            return productList;
        }

        public List<Product> SearchProductByKindName(string kindName)       //Tìm theo tên loại hàng
        {
            List<Product> productList = new List<Product>();
            string query = "EXEC sp_TIM_HANG_TENLH @TENLH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { kindName });

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }
            return productList;
        }

        public List<Product> SearchProductBySupplierName(string supplierName)   //Tìm theo nhà cung cấp
        {
            List<Product> productList = new List<Product>();
            string query = "EXEC sp_TIM_HANG_TENNCC @TENNCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { supplierName });

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }
            return productList;
        }

        public bool AddProduct(string productKindID, string productID, string productName)
        {
            int result = 0;
            string query = "EXEC sp_THEM_HANG @MAHG , @TENHG , @MALH";
            result += DataProvider.Instance.ExecuteNonQuery(query, new object[] { productID, productName, productKindID });
            return result > 0;
        }

        public bool UpdateProduct(string oldShelvesID, string productShelvesID, string productKindID, string productKindName, string productID, string productName, string supplierName, string productAmount)
        {
            int result = 0;

            if (oldShelvesID != "" && productShelvesID != "" && oldShelvesID != productShelvesID)
            {
                result += DataProvider.Instance.ExecuteNonQuery("EXEC sp_UPDATE_KEHGHANG @OLDMAKEHG , @MAKEHG , @MAHG , @SL", new object[] { oldShelvesID, productShelvesID, productID, productAmount });
            }
            else
                result++;
            result += DataProvider.Instance.ExecuteNonQuery("EXEC sp_UPDATE_LOAIHANG @MALH , @TENLH", new object[] { productKindID, productKindName });

            result += DataProvider.Instance.ExecuteNonQuery("EXEC sp_UPDATE_NHACUNGCAP_MALH @MALH , @TENNCC", new object[] { productKindID, supplierName });

            result += DataProvider.Instance.ExecuteNonQuery("EXEC sp_UPDATE_HANG @MAHG , @TENHG", new object[] { productID, productName });
            return result > 3;
        }

        public bool DeleteProduct(string productShelvesID, string productID)
        {
            int result = 0;
            if (productShelvesID != "")
            {
                //Tìm quan hệ Kệ_Hàng theo Mã hàng
                result += DataProvider.Instance.ExecuteNonQuery("EXEC sp_DELETE_KEHGHANG @MAKEHG , @MAHG", new object[] { productShelvesID, productID });
                return result > 0;
            }
            else
            {
                DataTable listImport = DataProvider.Instance.ExecuteQuery("SELECT MAPN FROM PHIEUNHAP WHERE MAHG = @MAHG", new object[] { productID });
                DataTable listExport = DataProvider.Instance.ExecuteQuery("SELECT MAPX FROM PHIEUXUAT WHERE MAHG = @MAHG", new object[] { productID });
                //Chỉ xóa khi không có phiếu nhập/xuất nào của hàng
                if (listImport.Rows.Count == 0 && listExport.Rows.Count == 0)
                {
                    result += DataProvider.Instance.ExecuteNonQuery("EXEC sp_DELETE_HANG @MAHG", new object[] { productID });
                    return result > 0;
                }
                else
                    return false;
            }
        }
    }
}

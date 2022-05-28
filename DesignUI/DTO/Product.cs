using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignUI.DTO
{
    class Product
    {
        public Product(string MAKEHG, string MAHG, string TENHG, string MALH, string TENLH, string TENNCC, int SL)
        {
            this.productShelvesID = MAKEHG;
            this.productID = MAHG;
            this.productName = TENHG;
            this.productKindID = MALH;
            this.productKindName = TENLH;
            this.productSupplierName = TENNCC;
            this.productAmount = SL;
        }

        private string productShelvesID;
        private string productKindID;
        private string productKindName;
        private string productID;
        private string productName;
        private string productSupplierName;
        private int productAmount;
        ////////////////////////////////////
        //  Thay đổi thứ tự trong khung này sẽ thay đổi thứ tự các cột của list ==> các cột của DataGridView
        public string ProductShelvesID { get => productShelvesID; set => productShelvesID = value; }
        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductKindID { get => productKindID; set => productKindID = value; }
        public string ProductKindName { get => productKindName; set => productKindName = value; }
        public string ProductSupplierName { get => productSupplierName; set => productSupplierName = value; }
        public int ProductAmount { get => productAmount; set => productAmount = value; }
        ////////////////////////////////////
        public Product(DataRow row) //Tạo đối tượng với các giá trị lấy từ 1 hàng của DataTable
        {
            this.productShelvesID = row["MAKEHG"].ToString();
            this.productID = row["MAHG"].ToString();
            this.productName = row["TENHG"].ToString();
            this.productKindID = row["MALH"].ToString();
            this.productKindName = row["TENLH"].ToString();
            this.productSupplierName = row["TENNCC"].ToString();
            if (row["SL"].ToString() == "")
                this.productAmount = 0;
            else 
                this.productAmount = (int)row["SL"];
        }
    }
}

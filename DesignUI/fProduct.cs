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
    public partial class fProduct : Form
    {
        BindingSource productList = new BindingSource();
        private bool isAdd_Click = false;   //Dùng để phân biệt 2 nút "Lưu" và "Hủy" đang phục vụ chức năng Thêm hay Sửa

        public fProduct()
        {
            InitializeComponent();
            LoadDataProduct();
        }
        void LoadDataProduct()              //Gọi tất cả các hàm truyền dữ liệu, định dạng... để thiết lập Form
        {
            dtgvProduct.DataSource = productList;   //Truyền danh sách hàng vào DataGridView
            LoadProductList();
            AddProductBinding();
            DesignHeader();
            LoadComboBox();
        }

        void LoadProductList()              //Truyền danh sách cho danh sách hàng (phục vụ cho DataGridView, được gọi lúc đầu và mỗi khi có thay đổi dữ liệu)
        {
            productList.DataSource = ProductDAO.Instance.GetProductList();
        }

        void LoadComboBox()                 //Truyền Items cho các Combobox
        {
            List<String> listItem;
            listItem = new List<string>() { "Mã kệ hàng", "Mã hàng", "Tên hàng", "Mã loại hàng", "Tên loại hàng", "Tên nhà cung cấp" };
            cbSearchProduct.DataSource = listItem;
        }

        void DesignHeader()             //Thiết kế DataGridView các thuộc tính của bảng
        {
            //Đổi tên các cột của DataGridView
            dtgvProduct.Columns["productShelvesID"].HeaderText = "Mã kệ";
            dtgvProduct.Columns["ProductID"].HeaderText = "Mã hàng";
            dtgvProduct.Columns["productName"].HeaderText = "Tên hàng";
            dtgvProduct.Columns["productKindID"].HeaderText = "Mã loại hàng";
            dtgvProduct.Columns["productKindName"].HeaderText = "Tên loại hàng";
            dtgvProduct.Columns["productSupplierName"].HeaderText = "Tên nhà cung cấp";
            dtgvProduct.Columns["productAmount"].HeaderText = "Số lượng";
            //Chỉnh header
            dtgvProduct.EnableHeadersVisualStyles = false;
            dtgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dtgvProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.0F, FontStyle.Bold);
        }

        void AddProductBinding()            //Dùng để truyền dữ liệu từ DataSource cho Textbox
        {
            cbxShelvesID.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "productShelvesID", true, DataSourceUpdateMode.Never));
            cbxProductKindID.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "productKindID", true, DataSourceUpdateMode.Never));
            txbProductKindName.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "productKindName", true, DataSourceUpdateMode.Never));
            txbProductID.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "ProductID", true, DataSourceUpdateMode.Never));
            txbProductName.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "productName", true, DataSourceUpdateMode.Never));
            txbSupplierName.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "productSupplierName", true, DataSourceUpdateMode.Never));
            txbProductAmount.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "productAmount", true, DataSourceUpdateMode.Never));
        }

        void ClearProductBinding()
        {
            cbxShelvesID.DataBindings.Clear();
            cbxProductKindID.DataBindings.Clear();
            txbProductKindName.DataBindings.Clear();
            txbProductID.DataBindings.Clear();
            txbProductName.DataBindings.Clear();
            txbSupplierName.DataBindings.Clear();
            txbProductAmount.DataBindings.Clear();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)   //Hàm này được thực thi khi Click nút "Tìm"
        {
            if (txbSearchProduct.Text == "") //Người dùng không nhập gì, hệ thống sẽ xuất ra tất cả sản phẩm (trừ mã kệ)
            {
                LoadProductList();
            }
            //Các Selected Index dưới đây ứng với vị trí đã chọn (bắt đầu từ 0) trong listItem (phương thức tìm kiếm đã cài đặt sẵn ở LoadComboBox())
            else if (cbSearchProduct.SelectedIndex == 0)         //Người dùng chọn Tìm theo Mã kệ
            {
                productList.DataSource = ProductDAO.Instance.SearchProductByShelvesID(txbSearchProduct.Text);
            }
            else if (cbSearchProduct.SelectedIndex == 1)        //Người dùng chọn tìm theo Mã hàng
            {
                productList.DataSource = ProductDAO.Instance.SearchProductByProductID(txbSearchProduct.Text);
            }
            else if (cbSearchProduct.SelectedIndex == 2)        //Người dùng chọn tìm theo Tên hàng
            {
                productList.DataSource = ProductDAO.Instance.SearchProductByProductName(txbSearchProduct.Text);
            }
            else if (cbSearchProduct.SelectedIndex == 3)        //Người dùng chọn tìm theo Mã loại hàng
            {
                productList.DataSource = ProductDAO.Instance.SearchProductByKindID(txbSearchProduct.Text);
            }
            else if (cbSearchProduct.SelectedIndex == 4)        //Người dùng chọn tìm theo Tên loại h
            {
                productList.DataSource = ProductDAO.Instance.SearchProductByKindName(txbSearchProduct.Text);
            }
            else                                                //Người dùng chọn tìm theo tên nhà cung cấp (index = 5)
            {
                productList.DataSource = ProductDAO.Instance.SearchProductBySupplierName(txbSearchProduct.Text);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)        //TextBox --> có thể nhập, Vô hiệu nút thêm và xóa, Hiện nút Lưu và Hủy
        {
            this.isAdd_Click = true;
            ClearProductBinding();
            //Định dạng và truyền item cho combobox loại hàng
            cbxProductKindID.DropDownStyle = ComboBoxStyle.DropDown;
            cbxProductKindID.BackColor = Color.White;
            cbxProductKindID.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MALH FROM LOAIHANG");
            cbxProductKindID.DisplayMember = "MALH";
            //TextBox --> có thể nhập
            txbProductID.ReadOnly = false;
            txbProductName.ReadOnly = false;
            cbxShelvesID.Text = "";
            txbProductID.Text = "";
            txbProductName.Text = "";
            txbProductAmount.Text = "0";
            label2.Visible = false;
            txbProductAmount.Visible = false;
            //Vô hiệu nút thêm và xóa
            btnUpdateProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            //Hiện nút Lưu và Hủy
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)     //TextBox --> có thể nhập, Vô hiệu nút thêm và xóa, Hiện nút Lưu và Hủy
        {
            this.isAdd_Click = false;
            ClearProductBinding();
            //Truyền Item cho combobox Mã kệ
            if (dtgvProduct.Rows[dtgvProduct.CurrentRow.Index].Cells[0].Value.ToString() != "")
            {
                string tmp = cbxShelvesID.Text;
                cbxShelvesID.DropDownStyle = ComboBoxStyle.DropDown;
                cbxShelvesID.BackColor = Color.White;
                cbxShelvesID.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MAKEHG FROM KEHANG WHERE MALH = @MALH", new object[] { cbxProductKindID.Text });
                cbxShelvesID.DisplayMember = "MAKEHG";
                cbxShelvesID.Text = tmp;
            }
            else
                cbxShelvesID.Text = "";
            //TextBox --> có thể nhập
            txbProductKindName.ReadOnly = false;
            txbProductName.ReadOnly = false;
            txbSupplierName.ReadOnly = false;
            //Vô hiệu nút thêm và xóa
            btnAddProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            //Hiện nút Lưu và Hủy
            btnSave.Visible = true;
            btnCancel.Visible = true;

        }

        private void btnSave_Click(object sender, EventArgs e)  //Nút "Lưu" dùng để lưu dữ liệu, dùng chung cho cả Thêm và Sửa
        {
            if (this.isAdd_Click)
            {
                SaveAddProduct();
            }
            else
            {
                SaveUpdateProduct();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)    //Nút "Hủy" dùng dể hủy chức năng, dùng chung cho cả Thêm và Sửa
        {
            if (MessageBox.Show("Bạn có muốn đóng chức năng?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (this.isAdd_Click)
                {
                    this.isAdd_Click = false;
                }
                //Add Binding
                AddProductBinding();
                //TextBox --> có thể nhập
                cbxShelvesID.DropDownStyle = ComboBoxStyle.Simple;
                cbxShelvesID.BackColor = SystemColors.Control;
                cbxProductKindID.DropDownStyle = ComboBoxStyle.Simple;
                cbxProductKindID.BackColor = SystemColors.Control;
                txbProductKindName.ReadOnly = true;
                txbProductID.ReadOnly = true;
                txbProductName.ReadOnly = true;
                txbSupplierName.ReadOnly = true;
                //Enable các nút thêm, xóa, sửa
                btnUpdateProduct.Enabled = true;
                btnAddProduct.Enabled = true;
                btnDeleteProduct.Enabled = true;
                //Xóa nút Lưu và Hủy
                btnSave.Visible = false;
                btnCancel.Visible = false;
                label2.Visible = true;
                txbProductAmount.Visible = true;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (txbProductAmount.Text == "0")
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (ProductDAO.Instance.DeleteProduct(cbxShelvesID.Text, txbProductID.Text))
                    {
                        LoadProductList();
                    }
                    else
                        MessageBox.Show("Sản phẩm được tham chiếu ở phiếu nhập / xuất hoặc có lỗi khi xóa sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Chỉ có thể xóa sản phẩm có số lượng bằng 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveAddProduct()
        {
            string productKindID = cbxProductKindID.Text;
            string productID = txbProductID.Text;
            string productName = txbProductName.Text;
            //Xét các textbox nhập vào (không được rỗng)
            if (productKindID == "" || productID == "" || productName == "")
            {
                MessageBox.Show("Không được bỏ trống dữ liệu nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = String.Format("SELECT * FROM LOAIHANG WHERE MALH = N'{0}'", productKindID); //Kiểm tra loại hàng đã tồn tại chưa
                DataTable listKind = DataProvider.Instance.ExecuteQuery(query);
                query = String.Format("SELECT * FROM HANG WHERE MAHG = N'{0}'", productID);  //Kiểm tra hàng đã tồn tại chưa
                DataTable listProduct = DataProvider.Instance.ExecuteQuery(query);
                if (listKind.Rows.Count == 1)   //Nếu tồn tại loại hàng và hàng chưa tồn tại thì thêm mới hàng
                {
                    if (listProduct.Rows.Count == 0)
                    {
                        if (ProductDAO.Instance.AddProduct(productKindID, productID, productName))
                        {
                            MessageBox.Show("Thêm thành công!");
                            LoadProductList();
                            AddProductBinding();
                            //TextBox --> không thể nhập
                            cbxProductKindID.DropDownStyle = ComboBoxStyle.Simple;
                            cbxProductKindID.BackColor = SystemColors.Control;
                            txbProductKindName.ReadOnly = true;
                            txbProductID.ReadOnly = true;
                            txbProductName.ReadOnly = true;
                            //Vô hiệu nút thêm và xóa
                            btnUpdateProduct.Enabled = true;
                            btnDeleteProduct.Enabled = true;
                            //Hiện nút Lưu và Hủy
                            btnSave.Visible = false;
                            btnCancel.Visible = false;
                            label2.Visible = true;
                            txbProductAmount.Visible = true;
                            this.isAdd_Click = false;
                        }
                        else
                            MessageBox.Show("Có lỗi khi thêm sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Mã hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Không tìm thấy loại hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveUpdateProduct()
        {
            //Lấy các giá trị từ các TextBox
            string oldShelvesID = dtgvProduct.Rows[dtgvProduct.CurrentRow.Index].Cells[0].Value.ToString();
            string productShelvesID = cbxShelvesID.Text;
            string productKindID = cbxProductKindID.Text;
            string productKindName = txbProductKindName.Text;
            string productID = txbProductID.Text;
            string productName = txbProductName.Text;
            string supplierName = txbSupplierName.Text;
            string productAmount = txbProductAmount.Text;
            if (oldShelvesID != "" && productShelvesID == "" || productKindID == "" || productKindName == "" || productID == "" || productName == "" || supplierName == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống dữ liệu nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (oldShelvesID != "" && DataProvider.Instance.ExecuteScalar("SELECT MAKEHG FROM KEHANG WHERE MAKEHG = @MAKEHG", new object[] { productShelvesID }) != null || oldShelvesID == "" && productShelvesID == "")
            {
                if (ProductDAO.Instance.UpdateProduct(oldShelvesID, productShelvesID, productKindID, productKindName, productID, productName, supplierName, productAmount))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    LoadProductList();
                    AddProductBinding();
                    //TextBox --> Chỉ đọc
                    txbProductKindName.ReadOnly = true;
                    txbProductID.ReadOnly = true;
                    txbProductName.ReadOnly = true;
                    txbSupplierName.ReadOnly = true;
                    cbxShelvesID.DropDownStyle = ComboBoxStyle.Simple;
                    cbxShelvesID.BackColor = SystemColors.Control;
                    cbxProductKindID.DropDownStyle = ComboBoxStyle.Simple;
                    cbxProductKindID.BackColor = SystemColors.Control;
                    //Cho phép ấn nút thêm và xóa
                    btnAddProduct.Enabled = true;
                    btnDeleteProduct.Enabled = true;
                    //Tắt nút Lưu và Hủy
                    btnSave.Visible = false;
                    btnCancel.Visible = false;
                    label2.Visible = true;
                    txbProductAmount.Visible = true;
                }
                else
                    MessageBox.Show("Có lỗi khi cập nhật thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Kệ hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbxProductKindID_SelectedValueChanged(object sender, EventArgs e)
        {
            object ob = DataProvider.Instance.ExecuteScalar("SELECT TENLH FROM LOAIHANG WHERE MALH = @MALH", new object[] { cbxProductKindID.Text });
            if (ob != null)
                txbProductKindName.Text = ob.ToString();
            else
                txbProductKindName.Text = "";
            ob = DataProvider.Instance.ExecuteScalar("SELECT TENNCC FROM NHACUNGCAP WHERE MALH = @MALH", new object[] { cbxProductKindID.Text });
            if (ob != null)
                txbSupplierName.Text = ob.ToString();
            else
                txbSupplierName.Text = "";
        }

        private void cbxShelvesID_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxProductKindID.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MALH FROM KEHANG WHERE MAKEHG = @MAKEHG", new object[] { cbxShelvesID.Text });
            cbxProductKindID.DisplayMember = "MALH";
        }

        private void cbxShelvesID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbxShelvesID.DropDownStyle == ComboBoxStyle.Simple)
            {
                e.Handled = true;
            }
        }
    }
}
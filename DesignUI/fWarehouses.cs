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
    public partial class fWarehouses : Form
    {
        public fWarehouses()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMNProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new fProduct());
            btnMNProduct.BackColor = Color.SkyBlue;
            btnMNImport.BackColor = Color.Gainsboro;
            btnMNExport.BackColor = Color.Gainsboro;
            btnMNEmployee.BackColor = Color.Gainsboro;
            btnMNReport.BackColor = Color.Gainsboro;
            btnMNSupplier.BackColor = Color.Gainsboro;
            btnMNBranch.BackColor = Color.Gainsboro;
        }

        private void btnMNImport_Click(object sender, EventArgs e)
        {
            openChildForm(new fImport());
            btnMNProduct.BackColor = Color.Gainsboro;
            btnMNImport.BackColor = Color.SkyBlue;
            btnMNExport.BackColor = Color.Gainsboro;
            btnMNEmployee.BackColor = Color.Gainsboro;
            btnMNReport.BackColor = Color.Gainsboro;
            btnMNSupplier.BackColor = Color.Gainsboro;
            btnMNBranch.BackColor = Color.Gainsboro;
        }

        private void btnMNExport_Click(object sender, EventArgs e)
        {
            openChildForm(new fExport());
            btnMNProduct.BackColor = Color.Gainsboro;
            btnMNImport.BackColor = Color.Gainsboro;
            btnMNExport.BackColor = Color.SkyBlue;
            btnMNEmployee.BackColor = Color.Gainsboro;
            btnMNReport.BackColor = Color.Gainsboro;
            btnMNSupplier.BackColor = Color.Gainsboro;
            btnMNBranch.BackColor = Color.Gainsboro;
        }

        private void btnMNEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new fEmployee());
            btnMNProduct.BackColor = Color.Gainsboro;
            btnMNImport.BackColor = Color.Gainsboro;
            btnMNExport.BackColor = Color.Gainsboro;
            btnMNEmployee.BackColor = Color.SkyBlue;
            btnMNReport.BackColor = Color.Gainsboro;
            btnMNSupplier.BackColor = Color.Gainsboro;
            btnMNBranch.BackColor = Color.Gainsboro;
        }

        private void btnMNReport_Click(object sender, EventArgs e)
        {
            openChildForm(new fReport());
            btnMNProduct.BackColor = Color.Gainsboro;
            btnMNImport.BackColor = Color.Gainsboro;
            btnMNExport.BackColor = Color.Gainsboro;
            btnMNEmployee.BackColor = Color.Gainsboro;
            btnMNReport.BackColor = Color.SkyBlue;
            btnMNSupplier.BackColor = Color.Gainsboro;
            btnMNBranch.BackColor = Color.Gainsboro;
        }

        private void btnMNSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new fSupplier());
            btnMNProduct.BackColor = Color.Gainsboro;
            btnMNImport.BackColor = Color.Gainsboro;
            btnMNExport.BackColor = Color.Gainsboro;
            btnMNEmployee.BackColor = Color.Gainsboro;
            btnMNReport.BackColor = Color.Gainsboro;
            btnMNSupplier.BackColor = Color.SkyBlue;
            btnMNBranch.BackColor = Color.Gainsboro;
        }

        private void btnMNBranch_Click(object sender, EventArgs e)
        {
            openChildForm(new fBranch());
            btnMNProduct.BackColor = Color.Gainsboro;
            btnMNImport.BackColor = Color.Gainsboro;
            btnMNExport.BackColor = Color.Gainsboro;
            btnMNEmployee.BackColor = Color.Gainsboro;
            btnMNReport.BackColor = Color.Gainsboro;
            btnMNSupplier.BackColor = Color.Gainsboro;
            btnMNBranch.BackColor = Color.SkyBlue;
        }

        private void fWarehouses_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

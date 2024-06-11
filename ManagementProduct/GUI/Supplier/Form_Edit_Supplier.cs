using ManagementProduct.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementProduct.GUI.Supplier
{
    public partial class Form_Edit_Supplier : Form
    {
        private int suppliersId;
        private Suppliers Suppliers;

        public event EventHandler SuppliersUpdated;

        public Form_Edit_Supplier(int suppliersId)
        {
            InitializeComponent();
            this.suppliersId = suppliersId;
            Suppliers = new Suppliers();
            LoadUserData();
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUserData()
        {
            DataRow suppliers = Suppliers.GetSuppliersById(suppliersId);
            if (suppliers != null)
            {
                txtName.Text = suppliers["name"].ToString();
                txtEmail.Text = suppliers["email"].ToString();
                txtPhone.Text = suppliers["phone"].ToString();
                txtAddress.Text = suppliers["address"].ToString();
            }
            else
            {
                MessageBox.Show("Supplier not found.");
            }
        }

        private void buttonUpdate(object sender, EventArgs e)
        {
            string nameValue = txtName.Text;
            string addressValue = txtAddress.Text;
            string emailValue = txtEmail.Text;
            string phoneValue = txtPhone.Text;

            if (string.IsNullOrEmpty(nameValue) || string.IsNullOrEmpty(addressValue) || string.IsNullOrEmpty(emailValue) || string.IsNullOrEmpty(phoneValue))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool success = Suppliers.UpdateSuppliers(suppliersId, nameValue, addressValue, emailValue, phoneValue);
            if (success)
            {
                MessageBox.Show("Data updated successfully.");
                SuppliersUpdated?.Invoke(this, EventArgs.Empty); // Trigger the event
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating data.");
            }
        }
    }
}

using ManagementProduct.Class;
using ManagementProduct.GUI.Customer;
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
    public partial class Form_Add_Supplier : Form
    {
        private Suppliers Suppliers;
        public Form_Add_Supplier()
        {
            InitializeComponent();
            Suppliers = new Suppliers();
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }



        private void buttonAdd(object sender, EventArgs e)
        {
            string name = inputName.Text;
            string address = inputAddress.Text;
            string email = inputEmail.Text;
            string phone = inputPhone.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            bool success = Suppliers.CreateSuppliers(name, address, email, phone);

            if (success)
            {
                MessageBox.Show("Supplier data has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Owner is List_Supplier crudForm)
                {
                    crudForm.LoadData();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Supplier data was not successfully added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

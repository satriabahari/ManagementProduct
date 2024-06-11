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

namespace ManagementProduct.GUI.Customer
{
    public partial class Form_Add_Customer : Form
    {
        private Customers Customers;
        public Form_Add_Customer()
        {
            InitializeComponent();
            Customers = new Customers();
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
            bool success = Customers.CreateCustomers(name, address, email, phone);

            if (success)
            {
                MessageBox.Show("Customer data has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Owner is List_Customer crudForm)
                {
                    crudForm.LoadData();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("User data was not successfully added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

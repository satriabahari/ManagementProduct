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
    public partial class Form_Edit_Customer : Form
    {
        private int customersId;
        private Customers Customers;

        public event EventHandler CustomersUpdated;

        public Form_Edit_Customer(int customersId)
        {
            InitializeComponent();
            this.customersId = customersId;
            Customers = new Customers();
            LoadUserData();
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUserData()
        {
            DataRow customers = Customers.GetCustomersById(customersId);
            if (customers != null)
            {
                txtName.Text = customers["name"].ToString();
                txtEmail.Text = customers["email"].ToString();
                txtPhone.Text = customers["phone"].ToString();
                txtAddress.Text = customers["address"].ToString();
            }
            else
            {
                MessageBox.Show("User not found.");
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

            bool success = Customers.UpdateCustomers(customersId, nameValue, addressValue, emailValue, phoneValue);
            if (success)
            {
                MessageBox.Show("Data updated successfully.");
                CustomersUpdated?.Invoke(this, EventArgs.Empty); // Trigger the event
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating data.");
            }
        }

    }
}

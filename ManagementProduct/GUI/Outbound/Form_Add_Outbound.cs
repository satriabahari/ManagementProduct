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

namespace ManagementProduct.GUI.Outbound
{
    public partial class Form_Add_Outbound : Form
    {
        private Outbounds outbounds;
        public Form_Add_Outbound()
        {
            InitializeComponent();
            outbounds = new Outbounds();
            LoadCustomers();
            LoadProducts();
        }

        private void LoadCustomers()
        {
            List<string> customers = outbounds.GetCustomers();
            foreach (string customer in customers)
            {
                inputCustomer.Items.Add(customer);
            }
        }

        private void LoadProducts()
        {
            List<string> products = outbounds.GetProducts();
            foreach (string product in products)
            {
                inputProduct.Items.Add(product);
            }
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            string product = inputProduct.Text;
            string customer = inputCustomer.Text;
            string quantity = inputQuantity.Text;
            string date = inputDate.Text;

            if (string.IsNullOrEmpty(product) || string.IsNullOrEmpty(customer) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(date))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Convert supplier name to supplier ID
            int customerId = GetCustomerIdByName(customer);
            if (customerId == -1)
            {
                MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int productId = GetProductIdByName(product);
            if (productId == -1)
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = outbounds.CreateOutbound(productId.ToString(), customerId.ToString(), quantity, date);

            if (success)
            {
                MessageBox.Show("Outbound data has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Owner is List_User crudForm)
                {
                    crudForm.LoadData();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Outbound data was not successfully added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCustomerIdByName(string customerName)
        {
            // Implement logic to get supplier ID by name
            // You can add a method in Inbounds class to fetch supplier ID by name from the database
            return outbounds.GetCustomerIdByName(customerName);
        }

        private int GetProductIdByName(string productName)
        {
            // Implement logic to get supplier ID by name
            // You can add a method in Inbounds class to fetch supplier ID by name from the database
            return outbounds.GetProductIdByName(productName);
        }
    }
}

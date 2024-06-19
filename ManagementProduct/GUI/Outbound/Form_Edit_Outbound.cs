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
    public partial class Form_Edit_Outbound : Form
    {
        private int outboundId;
        private Outbounds outbounds;
        private bool isLoading; // Flag to prevent events during initialization

        public event EventHandler OutboundUpdated;

        public Form_Edit_Outbound(int outboundId)
        {
            InitializeComponent();
            this.outboundId = outboundId;
            outbounds = new Outbounds();
            isLoading = true;
            LoadUserData();
            LoadProducts();
            LoadCustomers(); // Load suppliers into ComboBox
            isLoading = false;
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUserData()
        {
            DataRow outbound = outbounds.GetOutboundById(outboundId);
            if (outbound != null)
            {
                inputProduct.Text = outbounds.GetProductNameById(Convert.ToInt32(outbound["product_id"]));
                // Set supplier name instead of ID for display
                inputCustomer.Text = outbounds.GetCustomerNameById(Convert.ToInt32(outbound["customer_id"]));
                inputQuantity.Text = outbound["quantity"].ToString();
                inputDate.Text = outbound["date"].ToString();
            }
            else
            {
                MessageBox.Show("Outbound data not found.");
                Close();
            }
        }

        private void LoadCustomers()
        {
            // Load suppliers into ComboBox
            inputCustomer.Items.Clear();
            List<string> customers = outbounds.GetCustomers();
            foreach (string customer in customers)
            {
                inputCustomer.Items.Add(customer);
            }
        }

        private void LoadProducts()
        {
            // Load suppliers into ComboBox
            inputProduct.Items.Clear();
            List<string> products = outbounds.GetProducts();
            foreach (string product in products)
            {
                inputProduct.Items.Add(product);
            }
        }

        private void buttonUpdate(object sender, EventArgs e)
        {
            string productName = inputProduct.Text;
            string customerName = inputCustomer.Text;
            string quantityValue = inputQuantity.Text;
            string dateValue = inputDate.Text;

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(quantityValue) || string.IsNullOrEmpty(dateValue))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Convert supplier name to supplier ID
            int customerId = outbounds.GetCustomerIdByName(customerName);
            if (customerId == -1)
            {
                MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int productId = outbounds.GetProductIdByName(productName);
            if (productId == -1)
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = outbounds.UpdateOutbound(outboundId, productId.ToString(), customerId.ToString(), quantityValue, dateValue);
            if (success)
            {
                MessageBox.Show("Data updated successfully.");
                OutboundUpdated?.Invoke(this, EventArgs.Empty); // Trigger the event
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating data.");
            }
        }

        private void inputSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This event will fire when the user selects a different supplier from ComboBox
            if (!isLoading)
            {
                // Implement any additional logic needed when supplier selection changes
            }
        }
    }
}

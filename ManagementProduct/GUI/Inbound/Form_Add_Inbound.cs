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

namespace ManagementProduct.GUI.Inbound
{
    public partial class Form_Add_Inbound : Form
    {

        private Inbounds inbounds;
        public Form_Add_Inbound()
        {
            InitializeComponent();
            inbounds = new Inbounds();
            LoadSuppliers();
            LoadProducts();
        }

        private void LoadSuppliers()
        {
            List<string> suppliers = inbounds.GetSuppliers();
            foreach (string supplier in suppliers)
            {
                inputSupplier.Items.Add(supplier);
            }
        }

        private void LoadProducts()
        {
            List<string> products = inbounds.GetProducts();
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
            string supplier = inputSupplier.Text;
            string quantity = inputQuantity.Text;
            string date = inputDate.Text;

            if (string.IsNullOrEmpty(product) || string.IsNullOrEmpty(supplier) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(date))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Convert supplier name to supplier ID
            int supplierId = GetSupplierIdByName(supplier);
            if (supplierId == -1)
            {
                MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int productId = GetProductIdByName(product);
            if (productId == -1)
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = inbounds.CreateInbound(productId.ToString(), supplierId.ToString(), quantity, date);

            if (success)
            {
                MessageBox.Show("Inbound data has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Owner is List_User crudForm)
                {
                    crudForm.LoadData();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Inbound data was not successfully added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSupplierIdByName(string supplierName)
        {
            // Implement logic to get supplier ID by name
            // You can add a method in Inbounds class to fetch supplier ID by name from the database
            return inbounds.GetSupplierIdByName(supplierName);
        }

        private int GetProductIdByName(string productName)
        {
            // Implement logic to get supplier ID by name
            // You can add a method in Inbounds class to fetch supplier ID by name from the database
            return inbounds.GetProductIdByName(productName);
        }
    }
}

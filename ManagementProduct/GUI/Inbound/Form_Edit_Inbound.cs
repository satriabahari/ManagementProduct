﻿using ManagementProduct.Class;
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
    public partial class Form_Edit_Inbound : Form
    {
        private int inboundId;
        private Inbounds inbounds;
        private bool isLoading; // Flag to prevent events during initialization

        public event EventHandler InboundUpdated;

        public Form_Edit_Inbound(int inboundId)
        {
            InitializeComponent();
            this.inboundId = inboundId;
            inbounds = new Inbounds();
            isLoading = true;
            LoadUserData();
            LoadSuppliers(); // Load suppliers into ComboBox
            isLoading = false;
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUserData()
        {
            DataRow inbound = inbounds.GetInboundById(inboundId);
            if (inbound != null)
            {
                inputProduct.Text = inbound["product_id"].ToString();
                // Set supplier name instead of ID for display
                inputSupplier.Text = inbounds.GetSupplierNameById(Convert.ToInt32(inbound["supplier_id"]));
                inputQuantity.Text = inbound["quantity"].ToString();
                inputDate.Text = inbound["date"].ToString();
            }
            else
            {
                MessageBox.Show("Inbound data not found.");
                Close();
            }
        }

        private void LoadSuppliers()
        {
            // Load suppliers into ComboBox
            inputSupplier.Items.Clear();
            List<string> suppliers = inbounds.GetSuppliers();
            foreach (string supplier in suppliers)
            {
                inputSupplier.Items.Add(supplier);
            }
        }

        private void buttonUpdate(object sender, EventArgs e)
        {
            string productValue = inputProduct.Text;
            string supplierName = inputSupplier.Text; // Get supplier name from ComboBox
            string quantityValue = inputQuantity.Text;
            string dateValue = inputDate.Text;

            if (string.IsNullOrEmpty(productValue) || string.IsNullOrEmpty(supplierName) || string.IsNullOrEmpty(quantityValue) || string.IsNullOrEmpty(dateValue))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Convert supplier name to supplier ID
            int supplierId = inbounds.GetSupplierIdByName(supplierName);
            if (supplierId == -1)
            {
                MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = inbounds.UpdateInbound(inboundId, productValue, supplierId.ToString(), quantityValue, dateValue);
            if (success)
            {
                MessageBox.Show("Data updated successfully.");
                InboundUpdated?.Invoke(this, EventArgs.Empty); // Trigger the event
                Close();
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
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

        public event EventHandler OutboundUpdated;

        public Form_Edit_Outbound(int outboundId)
        {
            InitializeComponent();
            this.outboundId = outboundId;
            outbounds = new Outbounds();
            LoadUserData();
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
                inputProduct.Text = outbound["product_id"].ToString();
                inputCustomer.Text = outbound["customer_id"].ToString();
                inputQuantity.Text = outbound["quantity"].ToString();
                inputDate.Text = outbound["date"].ToString();
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void buttonUpdate(object sender, EventArgs e)
        {
            string productValue = inputProduct.Text;
            string customerValue = inputCustomer.Text;
            string quantityValue = inputQuantity.Text;
            string dateValue = inputDate.Text;

            if (string.IsNullOrEmpty(productValue) || string.IsNullOrEmpty(customerValue) || string.IsNullOrEmpty(quantityValue) || string.IsNullOrEmpty(dateValue))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool success = outbounds.UpdateOutbound(outboundId, productValue, customerValue, quantityValue, dateValue);
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
    }
}

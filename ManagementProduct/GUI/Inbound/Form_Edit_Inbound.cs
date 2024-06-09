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
    public partial class Form_Edit_Inbound : Form
    {
        private int inboundId;
        private Inbounds inbounds;

        public event EventHandler InboundUpdated;

        public Form_Edit_Inbound(int inboundId)
        {
            InitializeComponent();
            this.inboundId = inboundId;
            inbounds = new Inbounds();
            LoadUserData();
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
                inputSupplier.Text = inbound["supplier_id"].ToString();
                inputQuantity.Text = inbound["quantity"].ToString();
                inputDate.Text = inbound["date"].ToString();
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void buttonUpdate(object sender, EventArgs e)
        {
            string productValue = inputProduct.Text;
            string supplierValue = inputSupplier.Text;
            string quantityValue = inputQuantity.Text;
            string dateValue = inputDate.Text;

            if (string.IsNullOrEmpty(productValue) || string.IsNullOrEmpty(supplierValue) || string.IsNullOrEmpty(quantityValue) || string.IsNullOrEmpty(dateValue))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool success = inbounds.UpdateInbound(inboundId, productValue, supplierValue, quantityValue, dateValue);
            if (success)
            {
                MessageBox.Show("Data updated successfully.");
                InboundUpdated?.Invoke(this, EventArgs.Empty); // Trigger the event
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating data.");
            }
        }
    }
}

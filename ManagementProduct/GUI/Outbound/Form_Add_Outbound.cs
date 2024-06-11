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
            bool success = outbounds.CreateOutbound(product, customer, quantity, date);

            if (success)
            {
                MessageBox.Show("User data has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Owner is List_User crudForm)
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

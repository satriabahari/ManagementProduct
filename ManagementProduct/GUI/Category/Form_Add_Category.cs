using ManagementProduct.Class;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementProduct.GUI.Category
{
    public partial class Form_Add_Category : Form
    {
        private Categories categories;
        public Form_Add_Category()
        {
            InitializeComponent();
            categories = new Categories();
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            string name = inputName.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            bool success = categories.CreateCategory(name);

            if (success)
            {
                MessageBox.Show("Category data has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Owner is List_Category crudForm)
                {
                    crudForm.LoadData();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Category data was not successfully added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

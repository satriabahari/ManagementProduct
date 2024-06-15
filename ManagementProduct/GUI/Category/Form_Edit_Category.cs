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

namespace ManagementProduct.GUI.Category
{
    public partial class Form_Edit_Category : Form
    {
        private int categoryId;
        private Categories categories;

        public event EventHandler CategoryUpdated;

        public Form_Edit_Category(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;
            categories = new Categories();
            LoadUserData();
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUserData()
        {
            DataRow category = categories.GetCategoryById(categoryId);
            if (category != null)
            {
                inputName.Text = category["name"].ToString();
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void buttonUpdate(object sender, EventArgs e)
        {
            string nameValue = inputName.Text;

            if (string.IsNullOrEmpty(nameValue))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool success = categories.UpdateCategory(categoryId, nameValue);
            if (success)
            {
                MessageBox.Show("Data updated successfully.");
                CategoryUpdated?.Invoke(this, EventArgs.Empty); // Trigger the event
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating data.");
            }
        }
    }
}

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
    public partial class List_Category : Form
    {
        public List_Category()
        {
            InitializeComponent();
        }

        internal void LoadData()
        {
            throw new NotImplementedException();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_Add_Category formAddCategory = new Form_Add_Category
            {
                Owner = this
            };
            formAddCategory.ShowDialog();
        }
    }
}

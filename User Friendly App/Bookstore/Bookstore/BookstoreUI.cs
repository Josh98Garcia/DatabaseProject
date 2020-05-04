using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Bookstore : Form
    {
        public Bookstore()
        {
            InitializeComponent();
        }

        private void uxInsert_MouseHover(object sender, EventArgs e)
        {
            uxInsFinDescription.Text = "Create your own Books, Authors, and Publishers to populate the Bookstore Database.";
        }

        private void uxSelect_MouseMove(object sender, MouseEventArgs e)
        {
            uxInsFinDescription.Text = "Search for Books, Authors, and Publishers using Keywords and other information.";
        }

        private void uxInsert_Click(object sender, EventArgs e)
        {
            InsertNewItem INI = new InsertNewItem();
            INI.Show();
            Enabled = false;
        }

        private void uxSelect_Click(object sender, EventArgs e)
        {
            FindExistingItems FEI = new FindExistingItems(this);
            FEI.Show();
            Enabled = false;
        }
    }
}
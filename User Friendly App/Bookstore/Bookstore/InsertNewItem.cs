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
    public partial class InsertNewItem : Form
    {
        Bookstore bookstore;
        public InsertNewItem(Bookstore parent)
        {
            InitializeComponent();
            bookstore = parent;
        }

        private void InsertNewItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            bookstore.Enabled = true;
        }
    }
}

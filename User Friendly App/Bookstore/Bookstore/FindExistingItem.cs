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
    public partial class FindExistingItems : Form
    {
        Bookstore bookstore;
        public FindExistingItems(Bookstore parent)
        {
            InitializeComponent();
            bookstore = parent;
        }

        private void FindExistingItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            bookstore.Enabled = true;
        }
    }
}

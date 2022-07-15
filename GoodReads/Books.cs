using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodReads
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            AddBooks addBooks = new AddBooks();
            addBooks.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            ViewBooks viewBooks = new ViewBooks();
            viewBooks.Show();
            this.Hide();
        }
    }
}

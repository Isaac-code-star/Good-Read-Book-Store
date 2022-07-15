using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GoodReads
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=App;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(newConnection);
                sqlConnection.Open();

                string sqlInsert = "select * from booksData";
                SqlCommand sqlCommand = new SqlCommand(sqlInsert, sqlConnection);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }
    }
}

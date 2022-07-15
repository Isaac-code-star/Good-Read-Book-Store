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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string bookTitle = txtTitle.Text;
            string bookAuthor = txtAuthor.Text;
            string bookPublisher = txtPublisher.Text;
            string bookPrice = txtPrice.Text;
            string bookPurchaseDate = txtPurchaseDate.Text;
            DateTime pdate = DateTime.Parse(bookPurchaseDate);
            try
            {
                string newConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=App;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(newConnection);
                sqlConnection.Open();

                string sqlInsert = "insert into booksData(Title, Author, Publisher, Price, PurchaseDate) " +
                    "values(@Title, @Author, @Publisher, @Price, @PurchaseDate)";

                SqlCommand sql = new SqlCommand(sqlInsert, sqlConnection);

                sql.Parameters.AddWithValue("@Title", bookTitle);
                sql.Parameters.AddWithValue("@Author", bookAuthor);
                sql.Parameters.AddWithValue("@Publisher", bookPublisher);
                sql.Parameters.AddWithValue("@Price", bookPrice);
                sql.Parameters.AddWithValue("@PurchaseDate", pdate);

                sql.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");

                sqlConnection.Close();

                Clear();
                 

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Clear()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtPrice.Text = "";
            txtPurchaseDate.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

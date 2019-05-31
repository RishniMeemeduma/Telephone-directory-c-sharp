using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Directory
{
    public partial class Form1 : Form
    {

        // Connect to sql server
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-006K9U7\SQLSERVER;Initial Catalog=Telephone_book;User Id=sa;Password=root");
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            cnn.Open();
            //MessageBox.Show("Connected");
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();   // This adapter object is for specific sql command such as insert,update,delete.
            String sql;
           
            sql = @"Insert into directory(firstname,lastname,email,category,mobile) values('"+ textfirstname.Text + "','"+textlastname.Text+"','"+textemail.Text+"','"+textgroup.Text+"','"+textmobile.Text+"')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);  // Associate Insert Command
            adapter.InsertCommand.ExecuteNonQuery();

            adapter.Dispose();  // Close adapter and sql connection.
            cnn.Close();

            MessageBox.Show("Record Inserted");
            display();




        }
        void display()
        {
            string sql;
            SqlCommand command;

            cnn.Open();
            sql = @"Select * from directory";
            command = new SqlCommand(sql, cnn);

            SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                
                dataGridView1.Rows[n].Cells["firstnameDataGridViewTextBoxColumn"].Value = row["firstname"].ToString();
                dataGridView1.Rows[n].Cells["lastnameDataGridViewTextBoxColumn"].Value = row["lastname"].ToString();
                dataGridView1.Rows[n].Cells["emailDataGridViewTextBoxColumn"].Value = row["email"].ToString();
                dataGridView1.Rows[n].Cells["mobileDataGridViewTextBoxColumn"].Value = row["mobile"].ToString();
                dataGridView1.Rows[n].Cells["groupDataGridViewTextBoxColumn"].Value = row["category"].ToString();
            }

            cnn.Close();
        }

        private void View_Click(object sender, EventArgs e)
        {
            display();
            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textfirstname.Text = dataGridView1.SelectedRows[0].Cells["firstnameDataGridViewTextBoxColumn"].Value.ToString();
            textlastname.Text = dataGridView1.SelectedRows[0].Cells["lastnameDataGridViewTextBoxColumn"].Value.ToString();
            textmobile.Text = dataGridView1.SelectedRows[0].Cells["mobileDataGridViewTextBoxColumn"].Value.ToString();
            textemail.Text = dataGridView1.SelectedRows[0].Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
            textgroup.Text = dataGridView1.SelectedRows[0].Cells["groupDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter(); // define adapter object update database
            String sql;

            cnn.Open();
            sql = @"Update directory set firstname='" + textfirstname.Text + "',lastname='" + textlastname.Text + "',email='" + textemail.Text + "',mobile='" + textmobile.Text + "',category='" + textgroup.Text + "' where mobile='"+textmobile.Text+"'";
            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);  // Associate Update Command
            adapter.UpdateCommand.ExecuteNonQuery();

            MessageBox.Show("Record Updated.");

            adapter.Dispose();  // close the adapter and connection.
            cnn.Close();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            String sql;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            cnn.Open();
            sql = @"Delete from directory where mobile='" + textmobile.Text + "'";
            command = new SqlCommand(sql,cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show("Record Deleted Successfully");

            adapter.Dispose();
            cnn.Close();

        }

        private void New_Click(object sender, EventArgs e)
        {
            textfirstname.Clear();
            textlastname.Text = "";
            textemail.Clear();
            textmobile.Clear();
            textgroup.SelectedIndex = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telephone_bookDataSet2.directory' table. You can move, or remove it, as needed.
            this.directoryTableAdapter2.Fill(this.telephone_bookDataSet2.directory);

        }
    }
}

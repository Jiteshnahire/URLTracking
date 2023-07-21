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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Configuration;

namespace DeskTimeWindowsForms
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Insert into Department values(@Deptname)";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Deptname", depName.Text);
            
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Inserted");
                }
                else
                {
                    MessageBox.Show("Record not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Department set Deptname=@Deptname where Deptid=@id";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Deptname", depName.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(depId.Text));
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void getAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Department";
                cmd = new SqlCommand(qry, connection);
                connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    dataGridView1.DataSource = table;


                }
                else
                {
                    MessageBox.Show("Records not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Department where Deptid=@id";
                cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(depId.Text));
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Deleted");
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

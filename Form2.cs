using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskTimeWindowsForms
{
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}

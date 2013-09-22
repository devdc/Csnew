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
namespace the_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //*********** disconnected mode to db 
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=dbStudents;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter("select * from students", cn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}

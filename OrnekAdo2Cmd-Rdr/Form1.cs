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

namespace OrnekAdo2Cmd_Rdr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

            SqlCommand cmd = new SqlCommand("Select * from Personels",connection);

            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();

            }



            SqlDataReader rdr = cmd.ExecuteReader();

            


            if (rdr.HasRows) 
            
            {

                while (rdr.Read())
                {


                    listBox1.Items.Add(rdr[1].ToString());  


                }
            
            
            
            
            }





        }
    }
}

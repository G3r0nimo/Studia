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

namespace Zajecia02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {          
            
            string query = "INSERT INTO [Table]([Title], Description, [When] ) " +
               " VALUES ('" + txtBTitle.Text + "', '" + txtBDesc.Text + "', "
               + " '" + txtBWhen.Text + "') ";
            
            
            using (SqlConnection connect = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    connect.Open();
                    command.ExecuteNonQuery();                   
                    connect.Close();
                }
            }

            MessageBox.Show("Zapisano", "Achtung", MessageBoxButtons.OK);
        }
    }
}
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
    public partial class SelectId : Form
    {
        public SelectId()
        {
            InitializeComponent();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(Program.ConnectionString))
            {
               
                string query = "Delete from [Table] Where ID= " +
                   txtBID.Text;
                
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }
                MessageBox.Show("Usunięto", "Achtung", MessageBoxButtons.OK);

            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            p.Show();
        }
    }
}

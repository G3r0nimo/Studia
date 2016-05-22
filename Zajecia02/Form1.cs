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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }  */
        /*   private void dgv_CellValueChanged(

               object sender, DataGridViewCellEventArgs e)
           {
               // Update the balance column whenever the value of any cell changes.
               UpdateEvent();
           }

           private void UpdateEvent() //balance
           {
               int counter;
               string Title;
               string Desc;
               DateTime When;

               // Iterate through the rows, skipping the Starting Balance row.
               for (counter = 1; counter < (dgv.Rows.Count - 1);
                   counter++)
               {
                   Title = null;
                   Desc = null;
                   When = DateTime.Parse(dgv.Rows[counter - 1]
                       .Cells["Balance"].Value.ToString());

                   if (dgv.Rows[counter].Cells["Deposits"].Value != null)
                   {
                       // Verify that the cell value is not an empty string.
                       if (dgv.Rows[counter]
                           .Cells["Deposits"].Value.ToString().Length != 0)
                       {
                           When = DateTime.Parse(dgv.Rows[counter]
                               .Cells["Deposits"].Value.ToString());
                       }
                   }

                   if (dgv.Rows[counter].Cells["Withdrawals"].Value != null)
                   {
                       if (dgv.Rows[counter]
                           .Cells["Withdrawals"].Value.ToString().Length != 0)
                       {
                           withdrawal = int.Parse(dgv.Rows[counter]
                               .Cells["Withdrawals"].Value.ToString());
                       }
                   }
                   dgv.Rows[counter].Cells["Balance"].Value =
                       (balance + deposit + withdrawal).ToString();
               }
           }
           */
        private void Form1_Load(object sender, EventArgs e)
        {

        //    var connectpath = @"Data Source=(LocalDB)\v12.0;AttachDbFilename=|DataDirectory|App_Data\Database1.mdf;Integrated Security=True";

            using (SqlConnection connect = new SqlConnection(Program.ConnectionString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", connect);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;                             
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectId x = new SelectId();
            x.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.Show();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SelectId x = new SelectId();
            x.Show();        
        }
    }
}
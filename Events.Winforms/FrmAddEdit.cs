using Events.Winforms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events.Winforms
{
    public partial class FrmAddEdit : Form
    {
        
        private AddEditViewModel _addEditViewModel;
        public FrmAddEdit(AddEditViewModel addEditViewModel)
        {
            InitializeComponent();
            _addEditViewModel = addEditViewModel;
            txtTitle.DataBindings.Add("Text",
                _addEditViewModel,
                "Title",
                false,
                DataSourceUpdateMode.OnPropertyChanged);


        }



        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

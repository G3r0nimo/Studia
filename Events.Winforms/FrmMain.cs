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
    public partial class FrmMain : Form
    {
        private MainWindowViewModel _mainWindowViewModel;
        public FrmMain()
        {
            InitializeComponent();
            _mainWindowViewModel = new MainWindowViewModel();
            dgvEvents.DataSource = _mainWindowViewModel.Events;


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmAddEdit frmAddEdit = new FrmAddEdit();
            AddEditViewModel addEditViewModel = new AddEditViewModel();
            if
            (frmAddEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}

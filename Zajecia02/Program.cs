using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zajecia02
{
    static class Program
    {
        public static string ConnectionString
        {
            get
            {
                return @"Data Source=(LocalDB)\v12.0;AttachDbFilename=|DataDirectory|App_Data\Events.mdf;Integrated Security=True";
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starter
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
                //start the application
                Application.Run(new MovieClass.MainFrame());
        }
    }
}

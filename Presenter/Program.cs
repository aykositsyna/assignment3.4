using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLayer;

namespace Presenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form1 form = new Form1();
            Presenter presenter = new Presenter(new Model(), form);

            Application.Run(form);
            

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Form form1 = new Form1();
            //form1.Show();
            //Application.Run();
            //Environment.Exit(0);
        }
    }
}

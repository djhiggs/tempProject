using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here's a comment
            //Here's another comment
            Console.WriteLine("Hello world.");
            Console.WriteLine("This is the first time this code has seen the Internet.");
            Console.ReadKey();
            WindowsFormsApplication3.Form1 form = new WindowsFormsApplication3.Form1();
            form.Show();

            Console.ReadKey();
        }
    }
}

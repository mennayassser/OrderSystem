using System;
using System.Windows.Forms;

namespace Market_Winform
{
     static class Program
    {

        [STAThread]
        static void Main() 
        {
            ApplicationConfiguration.Initialize();


            

            Application.Run(new Login());
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouSourceApp.Controller;

namespace YouSourceApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            TextSorterView textSorterView = new TextSorterView();
            TextSorterController textSorterController = new TextSorterController(textSorterView);
            textSorterView.ShowDialog();
        }

    }
}

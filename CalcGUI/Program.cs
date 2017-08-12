using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Name: Sahal Mohamed
 * Student Number: 300895007
 * Lab 26
 */
namespace CalcGUI
{
    public static class Program
    {
        // FORM INSTANTIATION
        public static CalculatorForm calculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
            calculatorForm = new CalculatorForm(); // instantiates object of type Calculator Form


        }
    }
}

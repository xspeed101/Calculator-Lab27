using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Name: Sahal Mohamed
 * Student Number: 300895007
 * Description: Lab 27 of COMP123 Section - 001. Adding the remaining functions of the CalculatorForm done in class.
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

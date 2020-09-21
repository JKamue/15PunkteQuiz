using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _15PunkteQuiz.Data;
using _15PunkteQuiz.Forms;

namespace _15PunkteQuiz
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var test = new SqliteDb();
            Application.Run(new CourseSelection());
        }
    }
}

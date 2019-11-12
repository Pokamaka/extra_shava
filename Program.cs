using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шава_мейкер_2._0
{
    static class Data
    {
        public static double Summ { get; set; } //Глобальная переменная для подсчета стоимости шавы
        public static int Ost { get; set; } //Глобальная переменная для шкалы остраты
        public static int Callories { get; set; } //Глобальная переменная для подсчета калорийности шавы
}
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

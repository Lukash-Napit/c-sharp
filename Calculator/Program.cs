using MyCalculatorApp;
using System;
using System.Windows.Forms;

namespace MyCalculatorApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
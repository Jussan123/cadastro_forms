/* Módulo Menu Principal
* Descrição : Classe responsável pela criação do menu principal
* Autor : Jussan Igor da Silva
* Data : 17/04/2023
* Versão : 1.1
*/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;



namespace cadastro_forms
{
    


    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }    
    }
}
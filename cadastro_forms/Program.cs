using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using cadastro_forms.View.Forms.Produto;

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
			Application.EnableVisualStyles();
            Application.Run(new FormProduto());
        }
    }

	public class FormularioCadastro : Form 
    {
        
	}
}
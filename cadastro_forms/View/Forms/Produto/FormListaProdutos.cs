using ControllerProduto;
using ModelProduto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace cadastro_forms.View.Forms.Produto
{
    public class FormListaProdutos : Form
    {
        public FormListaProdutos()
        {
        }
        
        Label lblTituloLista;
        Label lblTxtLista;
        Button btnincluiProduto;
        Button btnexcluiProduto;
        Button btneditaProduto;
        Button btnVoltarMenu;
        
        public void IniciaFormulario()
        {
            lblTituloLista = new Label();
            lblTituloLista.Text = "Lista de Produtos";
            lblTituloLista.Location = new Point(10, 10);
            lblTituloLista.Size = new Size(200, 20);
            lblTituloLista.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            lblTituloLista.ForeColor = Color.Black;
            this.Controls.Add(lblTituloLista);

            lblTxtLista = new Label();
            lblTxtLista.Text = "Lista:";
            lblTxtLista.Location = new Point(10, 40);
            lblTxtLista.Size = new Size(200, 20);
            lblTxtLista.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            lblTxtLista.ForeColor = Color.Black;
            this.Controls.Add(lblTxtLista);

            btnincluiProduto = new Button();
            btnincluiProduto.Text = "Incluir";
            btnincluiProduto.Location = new Point(10, 70);
            btnincluiProduto.Size = new Size(200, 20);
            btnincluiProduto.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnincluiProduto.ForeColor = Color.Black;
            this.Controls.Add(btnincluiProduto);

            btnexcluiProduto = new Button();
            btnexcluiProduto.Text = "Excluir";
            btnexcluiProduto.Location = new Point(10, 100);
            btnexcluiProduto.Size = new Size(200, 20);
            btnexcluiProduto.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnexcluiProduto.ForeColor = Color.Black;
            this.Controls.Add(btnexcluiProduto);

            btneditaProduto = new Button();
            btneditaProduto.Text = "Editar";
            btneditaProduto.Location = new Point(10, 130);
            btneditaProduto.Size = new Size(200, 20);
            btneditaProduto.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btneditaProduto.ForeColor = Color.Black;
            this.Controls.Add(btneditaProduto);

            btnVoltarMenu = new Button();
            btnVoltarMenu.Text = "Voltar";
            btnVoltarMenu.Location = new Point(10, 160);
            btnVoltarMenu.Size = new Size(200, 20);
            btnVoltarMenu.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnVoltarMenu.ForeColor = Color.Black;
            this.Controls.Add(btnVoltarMenu);

            btnincluiProduto.Click += new EventHandler(btnincluiProduto_Click);
            btnexcluiProduto.Click += new EventHandler(btnexcluiProduto_Click);
            btneditaProduto.Click += new EventHandler(btneditaProduto_Click);
            btnVoltarMenu.Click += new EventHandler(btnVoltarMenu_Click);

            this.Text = "Lista de Produtos";
            this.Size = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowDialog();
        }
        public FormListaProdutos(List<ModelProduto.Produto> listaProdutos)
        {
            IniciaFormulario();
        }

        public static void btnincluiProduto_Click(object o, System.EventArgs e) {

        }

        public static void btnexcluiProduto_Click(object o, System.EventArgs e) {

        }

        public static void btneditaProduto_Click(object o, System.EventArgs e) {

        }

        public static void btnVoltarMenu_Click(object o, System.EventArgs e) {

        }
        
    }
}
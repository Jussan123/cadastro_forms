using ControllerProduto;
using ModelProduto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cadastro_forms.View.Forms.Produto
{
    public class FormListaProdutos : Form
    {
        
        Label lblTituloLista;
        Label lblTxtLista;
        ListBox lbListaProdutos;
        Button btnincluiProduto;
        Button btnexcluiProduto;
        Button btneditaProduto;
        Button btnVoltarMenu;
        Button btnRefresh;
        
        public void IniciaFormulario()
        {
            lblTituloLista = new Label();
            lblTituloLista.Text = "Lista de Produtos";
            lblTituloLista.Location = new Point(10, 10);
            lblTituloLista.Size = new Size(200, 20);
            lblTituloLista.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTituloLista.ForeColor = Color.Black;
            this.Controls.Add(lblTituloLista);

            //lbListaProdutos = new ListBox();
            //lbListaProdutos.Location = new Point(10, 40);
            //lbListaProdutos.Size = new Size(450, 300);
            //lbListaProdutos.Font = new Font("TrebuchetMS", 8, FontStyle.Regular);
            //lbListaProdutos.ForeColor = Color.Black;
            ////Listar em uma tabela preenchida nessa Listbox os produtos cadastrados tabela Produtos do banco de dados
            //lbListaProdutos.Layout += (sender, e) => {
            //    lbListaProdutos.Items.Clear();
            //    foreach (var produto in ControllerProduto.Produto.ListaProdutos())
            //    {
            //        lbListaProdutos.Items.Add(produto);
            //    }
            //};

            var dataGridView = new DataGridView();
            dataGridView.Location = new Point(10, 40);
            dataGridView.Size = new Size(800, 340);

            // Configura as colunas da tabela
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Nome", "Nome");
            dataGridView.Columns.Add("Descricao", "Descrição");
            dataGridView.Columns.Add("Preco", "Preço");
            dataGridView.Columns.Add("Quantidade", "Quantidade");

            foreach (var produto in ControllerProduto.Produto.ListaProdutos())
            {
            // Adiciona uma nova linha à tabela com os dados do produto
                dataGridView.Rows.Add(produto.Id, produto.Nome, produto.Descricao, produto.Preco, produto.Quantidade);
            }

            // Configura a formatação das células da tabela
            dataGridView.DefaultCellStyle.Font = new Font("TrebuchetMS", 8, FontStyle.Regular);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            this.Controls.Add(dataGridView);

            //this.Controls.Add(lbListaProdutos);

            btnincluiProduto = new Button();
            btnincluiProduto.Text = "Incluir";
            btnincluiProduto.Location = new Point(10, 400);
            btnincluiProduto.Size = new Size(100, 30);
            btnincluiProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnincluiProduto.ForeColor = Color.Black;
            btnincluiProduto.Click += (sender, e) => {
                AbrirForm( new FormProduto());
            };
            this.Controls.Add(btnincluiProduto);

            btnexcluiProduto = new Button();
            btnexcluiProduto.Text = "Excluir";
            btnexcluiProduto.Location = new Point(120, 400);
            btnexcluiProduto.Size = new Size(100, 30);
            btnexcluiProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnexcluiProduto.ForeColor = Color.Black;
            btnexcluiProduto.Click += (sender, e) => {
                var id = dataGridView.CurrentRow.Cells[0].Value;
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                AbrirForm( new FormConfirmDelete(Convert.ToInt32(id)));
            };
            this.Controls.Add(btnexcluiProduto);

            btneditaProduto = new Button();
            btneditaProduto.Text = "Editar";
            btneditaProduto.Location = new Point(230, 400);
            btneditaProduto.Size = new Size(100, 30);
            btneditaProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btneditaProduto.ForeColor = Color.Black;
            btneditaProduto.Click += (sender, e) => {
                AbrirForm( new FormEditaProdutos());
            };
            this.Controls.Add(btneditaProduto);

            btnVoltarMenu = new Button();
            btnVoltarMenu.Text = "Voltar";
            btnVoltarMenu.Location = new Point(340, 400);
            btnVoltarMenu.Size = new Size(100, 30);
            btnVoltarMenu.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnVoltarMenu.ForeColor = Color.Black;
            btnVoltarMenu.Click += (sender, e) => this.Close();
            this.Controls.Add(btnVoltarMenu);

            btnRefresh = new Button();
            btnRefresh.Text = "Refresh";
            btnRefresh.Location = new Point(450, 400);
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Click += (sender, e) => {
                dataGridView.Rows.Clear();
                foreach (var produto in ControllerProduto.Produto.ListaProdutos())
                {
                    dataGridView.Rows.Add(produto.Id, produto.Nome, produto.Descricao, produto.Preco, produto.Quantidade);
                }
            };
            this.Controls.Add(btnRefresh);

            this.Text = "Lista de Produtos";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowDialog();
        }
        //public FormListaProdutos(List<ModelProduto.Produto> listaProdutos)
        //{
        //    IniciaFormulario();
        //}
        public FormListaProdutos()
        {
            IniciaFormulario();
        }
        
        public void AbrirForm(Form form){
            form.ShowDialog();
        }
        
    }
}
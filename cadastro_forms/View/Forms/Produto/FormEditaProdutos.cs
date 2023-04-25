/* Módulo Formulário para editar produtos
 * Formulário para editar produtos
 * Autor: Jussan Igor da Silva
 * Data: 15/04/2023
 * Versão: 1.4
*/
namespace cadastro_forms.View.Forms.Produto
{
    public class FormEditaProdutos : Form
    {
        Label lblTituloEditaProduto;
        Button btnEditarProduto;
        Button btnEditaNomeProduto;
        Button btnEditaDescricaoProduto;
        Button btnEditaPrecoProduto;
        Button btnVoltarAoMenuProduto;

        public void IniciaFormulario()
        {
            lblTituloEditaProduto = new Label();
            lblTituloEditaProduto.Text = "Editar Cadastro de Produtos";
            lblTituloEditaProduto.Location = new Point(10, 10);
            lblTituloEditaProduto.Size = new Size(300, 30);
            lblTituloEditaProduto.Font = new Font("TrebuchetMS", 12, FontStyle.Bold);
            lblTituloEditaProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTituloEditaProduto);

            btnEditarProduto = new Button();
            btnEditarProduto.Text = "Editar";
            btnEditarProduto.Location = new Point(10, 40);
            btnEditarProduto.Size = new Size(100, 40);
            btnEditarProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnEditarProduto.ForeColor = Color.Black;
            btnEditarProduto.Click += (sender, e) => {
                AbrirFormEditaCompleto(new EditarProduto());
            };
            this.Controls.Add(btnEditarProduto);

            btnEditaNomeProduto = new Button();
            btnEditaNomeProduto.Text = "Editar Nome";
            btnEditaNomeProduto.Location = new Point(120, 40);
            btnEditaNomeProduto.Size = new Size(100, 40);
            btnEditaNomeProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnEditaNomeProduto.ForeColor = Color.Black;
            btnEditaNomeProduto.Click += (sender, e) => {
                AbrirFormEditaNome( new EditaNomeProduto());
            };
            this.Controls.Add(btnEditaNomeProduto);

            btnEditaDescricaoProduto = new Button();
            btnEditaDescricaoProduto.Text = "Editar Descrição";
            btnEditaDescricaoProduto.Location = new Point(230, 40);
            btnEditaDescricaoProduto.Size = new Size(100, 40);
            btnEditaDescricaoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnEditaDescricaoProduto.ForeColor = Color.Black;
            btnEditaDescricaoProduto.Click += (sender, e) => {
                AbrirFormEditaDescricao(new EditaDescricaoProduto());
            };
            this.Controls.Add(btnEditaDescricaoProduto);

            btnEditaPrecoProduto = new Button();
            btnEditaPrecoProduto.Text = "Editar Preço";
            btnEditaPrecoProduto.Location = new Point(10, 90);
            btnEditaPrecoProduto.Size = new Size(100, 40);
            btnEditaPrecoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnEditaPrecoProduto.ForeColor = Color.Black;
            btnEditaPrecoProduto.Click += (sender, e) => {
                AbrirFormEditaPreco( new EditaPrecoProduto());
            };
            this.Controls.Add(btnEditaPrecoProduto);

            btnVoltarAoMenuProduto = new Button();
            btnVoltarAoMenuProduto.Text = "Voltar";
            btnVoltarAoMenuProduto.Location = new Point(230,90);
            btnVoltarAoMenuProduto.Size = new Size(100, 40);
            btnVoltarAoMenuProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnVoltarAoMenuProduto.ForeColor = Color.Black;
            btnVoltarAoMenuProduto.Click += (sender, e) => this.Close();
            this.Controls.Add(btnVoltarAoMenuProduto);

            this.Text = "Editar Produtos";
            this.Size = new Size(500, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void AbrirFormEditaCompleto(Form form)
        {
            form.ShowDialog();
        }

        public void AbrirFormEditaNome(Form form)
        {
            form.ShowDialog();
        }

        public void AbrirFormEditaDescricao(Form form)
        {
            form.ShowDialog();
        }

        public void AbrirFormEditaPreco(Form form)
        {
            form.ShowDialog();
        }

        public void AbrirFormEditaQuantidade(Form form)
        {
            form.ShowDialog();
        }

        public FormEditaProdutos()
        {
            IniciaFormulario();
        }
    }
}
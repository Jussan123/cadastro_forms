using ControllerProduto;
using ModelProduto;

namespace cadastro_forms.View.Forms.Produto
{
    public class FormProduto : Form
    {
        Label lblTituloProduto;

        Label lblTxtNomeProduto;

        Label lblTxtDescricaoProduto;
        Label lblTxtPrecoProduto;
        Label lblTxtQuantidadeProduto;

        TextBox tbNomeProduto;
        TextBox tbDescricaoProduto;
        TextBox tbPrecoProduto;
        TextBox tbQuantidadeProduto;

        Button btnSalvarProduto;

        Button btnCancelarProduto;        


        public void IniciaFormulario(){
            lblTituloProduto = new Label();
            lblTituloProduto.Text = "Cadastro de Produto";
            lblTituloProduto.Location = new Point(10, 10);
            lblTituloProduto.Size = new Size(200, 20);
            lblTituloProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTituloProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTituloProduto);

            lblTxtNomeProduto = new Label();
            lblTxtNomeProduto.Text = "Nome:";
            lblTxtNomeProduto.Location = new Point(10, 40);
            lblTxtNomeProduto.Size = new Size(200, 20);
            lblTxtNomeProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTxtNomeProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtNomeProduto);

            tbNomeProduto = new TextBox();
            tbNomeProduto.Location = new Point(10, 60);
            tbNomeProduto.Size = new Size(200, 20);
            tbNomeProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            tbNomeProduto.ForeColor = Color.Black;
            this.Controls.Add(tbNomeProduto);

            lblTxtDescricaoProduto = new Label();
            lblTxtDescricaoProduto.Text = "Descrição:";
            lblTxtDescricaoProduto.Location = new Point(10, 90);
            lblTxtDescricaoProduto.Size = new Size(200, 20);
            lblTxtDescricaoProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTxtDescricaoProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtDescricaoProduto);

            tbDescricaoProduto = new TextBox();
            tbDescricaoProduto.Location = new Point(10, 110);
            tbDescricaoProduto.Size = new Size(200, 20);
            tbDescricaoProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            tbDescricaoProduto.ForeColor = Color.Black;
            this.Controls.Add(tbDescricaoProduto);

            lblTxtPrecoProduto = new Label();
            lblTxtPrecoProduto.Text = "Preço:";
            lblTxtPrecoProduto.Location = new Point(10, 140);
            lblTxtPrecoProduto.Size = new Size(200, 20);
            lblTxtPrecoProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTxtPrecoProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtPrecoProduto);

            tbPrecoProduto = new TextBox();
            tbPrecoProduto.Location = new Point(10, 160);
            tbPrecoProduto.Size = new Size(200, 20);
            tbPrecoProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            tbPrecoProduto.ForeColor = Color.Black;
            this.Controls.Add(tbPrecoProduto);

            lblTxtQuantidadeProduto = new Label();
            lblTxtQuantidadeProduto.Text = "Quantidade:";
            lblTxtQuantidadeProduto.Location = new Point(10, 190);

            lblTxtQuantidadeProduto.Size = new Size(200, 20);
            lblTxtQuantidadeProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTxtQuantidadeProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtQuantidadeProduto);

            tbQuantidadeProduto = new TextBox();
            tbQuantidadeProduto.Location = new Point(10, 210);
            tbQuantidadeProduto.Size = new Size(200, 20);
            tbQuantidadeProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            tbQuantidadeProduto.ForeColor = Color.Black;
            this.Controls.Add(tbQuantidadeProduto);

            btnSalvarProduto = new Button();
            btnSalvarProduto.Text = "Salvar";
            btnSalvarProduto.Location = new Point(10, 240);
            btnSalvarProduto.Size = new Size(90, 20);
            btnSalvarProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            btnSalvarProduto.ForeColor = Color.Black;
            this.Controls.Add(btnSalvarProduto);

            btnCancelarProduto = new Button();
            btnCancelarProduto.Text = "Cancelar";
            btnCancelarProduto.Location = new Point(120, 240);
            btnCancelarProduto.Size = new Size(90, 20);
            btnCancelarProduto.Font = new Font("Arial", 12, FontStyle.Bold);
            btnCancelarProduto.ForeColor = Color.Black;
            btnCancelarProduto.Click += (sender, e) => {
                this.Close();
            };
            this.Controls.Add(btnCancelarProduto);

            this.Text = "Cadastro de Produto";
            this.Size = new Size(300, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        public FormProduto(){
            IniciaFormulario();
        }

        public void SalvarProduto(){
            ModelProduto.Produto produto = new ModelProduto.Produto();
            produto.Nome = tbNomeProduto.Text;
            produto.Descricao = tbDescricaoProduto.Text;
            produto.Preco = Convert.ToDecimal(tbPrecoProduto.Text);
            produto.Quantidade = Convert.ToInt32(tbQuantidadeProduto.Text);

            ControllerProduto.Produto.CadastraProduto(produto.Nome, produto.Descricao, produto.Preco.ToString(), produto.Quantidade.ToString());
        }

    }
}
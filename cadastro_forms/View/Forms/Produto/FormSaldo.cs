/* Módulo de Formulário de Saldos
 * Descrição : Classe responsável pela criação do formulário de saldos
 * Autor : Jussan Igor da Silva
 * Data : 22/04/2023
 * Versão : 1.0
 */

namespace cadastro_forms.View.Forms.Produto
{
    public class FormSaldo : Form
    {
        Label lblTitulo;
        Label lblTxtProdutoId;
        Label lblTxtAlmoxarifadoId;
        TextBox txtProdutoId;
        TextBox txtAlmoxarifadoId;
        Button btnSalvar;
        Button btnCancelar;
        Button btnSair;

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Cadastrar Saldo";
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Size = new Size(200, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            lblTxtProdutoId = new Label();
            lblTxtProdutoId.Text = "Id Produto:";
            lblTxtProdutoId.Location = new Point(10, 30);
            lblTxtProdutoId.Size = new Size(200, 20);
            lblTxtProdutoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtProdutoId.ForeColor = Color.Black;
            this.Controls.Add(lblTxtProdutoId);

            txtProdutoId = new TextBox();
            txtProdutoId.Location = new Point(10, 50);
            txtProdutoId.Size = new Size(200, 20);
            txtProdutoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            txtProdutoId.ForeColor = Color.Black;
            this.Controls.Add(txtProdutoId);

            lblTxtAlmoxarifadoId = new Label();
            lblTxtAlmoxarifadoId.Text = "Id Almoxarifado:";
            lblTxtAlmoxarifadoId.Location = new Point(10, 80);
            lblTxtAlmoxarifadoId.Size = new Size(200, 20);
            lblTxtAlmoxarifadoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtAlmoxarifadoId.ForeColor = Color.Black;
            this.Controls.Add(lblTxtAlmoxarifadoId);

            txtAlmoxarifadoId = new TextBox();
            txtAlmoxarifadoId.Location = new Point(10, 100);
            txtAlmoxarifadoId.Size = new Size(200, 20);
            txtAlmoxarifadoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            txtAlmoxarifadoId.ForeColor = Color.Black;
            this.Controls.Add(txtAlmoxarifadoId);

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new Point(10, 130);
            btnSalvar.Size = new Size(90, 20);
            btnSalvar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Click += (sender, e) => {
                SalvarSaldo();
                LimpaTela();
            };
            this.Controls.Add(btnSalvar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(110, 130);
            btnCancelar.Size = new Size(90, 20);
            btnCancelar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Click += (sender, e) => LimpaTela();
            this.Controls.Add(btnCancelar);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(210, 130);
            btnSair.Size = new Size(90, 20);
            btnSair.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Click += (sender, e) => this.Close();
            this.Controls.Add(btnSair);

            this.Text = "Cadastrar Saldo";
            this.Size = new Size(320, 240);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public FormSaldo()
        {
            IniciaFormulario();
        }

        public void SalvarSaldo()
        {
            ModelProduto.Saldo saldo = new ModelProduto.Saldo();
            saldo.ProdutoId = Convert.ToInt32(txtProdutoId.Text);
            saldo.AlmoxarifadoId = Convert.ToInt32(txtAlmoxarifadoId.Text);
            try
            {
                ModelProduto.Produto produto = ControllerProduto.Produto.BuscaProduto(saldo.ProdutoId);
                saldo.Produto = produto;
                saldo.Quantidade= Convert.ToInt32(produto.Quantidade);
            }
            catch (Exception)
            {
                MessageBox.Show("Id Produto Inválido");
                return;
            }
            try
            {
                ModelProduto.Almoxarifado almoxarifado = ModelProduto.Almoxarifado.ReadAlmoxarifado(saldo.AlmoxarifadoId);
                saldo.Almoxarifado = almoxarifado;
            }
            catch (Exception)
            {
                MessageBox.Show("Id Almoxarifado inválido");
                return;
            }
            ControllerProduto.Saldo.CadastraSaldo(saldo.ProdutoId, saldo.Produto, saldo.AlmoxarifadoId, saldo.Almoxarifado, saldo.Quantidade);
            MessageBox.Show("Saldo cadastrado com sucesso");
            LimpaTela();
        }

        public void LimpaTela()
        {
            txtProdutoId.Text = "";
            txtAlmoxarifadoId.Text = "";
        }
    }
}
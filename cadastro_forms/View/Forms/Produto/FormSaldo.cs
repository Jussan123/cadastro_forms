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
        Label lblTxtIdProduto;
        Label lblTxtIdAlmoxarifado;
        TextBox txtIdProduto;
        TextBox txtIdAlmoxarifado;
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

            lblTxtIdProduto = new Label();
            lblTxtIdProduto.Text = "Id Produto:";
            lblTxtIdProduto.Location = new Point(10, 30);
            lblTxtIdProduto.Size = new Size(200, 20);
            lblTxtIdProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtIdProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtIdProduto);

            txtIdProduto = new TextBox();
            txtIdProduto.Location = new Point(10, 50);
            txtIdProduto.Size = new Size(200, 20);
            txtIdProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            txtIdProduto.ForeColor = Color.Black;
            this.Controls.Add(txtIdProduto);

            lblTxtIdAlmoxarifado = new Label();
            lblTxtIdAlmoxarifado.Text = "Id Almoxarifado:";
            lblTxtIdAlmoxarifado.Location = new Point(10, 80);
            lblTxtIdAlmoxarifado.Size = new Size(200, 20);
            lblTxtIdAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtIdAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(lblTxtIdAlmoxarifado);

            txtIdAlmoxarifado = new TextBox();
            txtIdAlmoxarifado.Location = new Point(10, 100);
            txtIdAlmoxarifado.Size = new Size(200, 20);
            txtIdAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            txtIdAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(txtIdAlmoxarifado);

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
            btnCancelar.Click += (sender, e) => {
                LimpaTela();
            };
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
            saldo.IdProduto = Convert.ToInt32(txtIdProduto.Text);
            saldo.IdAlmoxarifado = Convert.ToInt32(txtIdAlmoxarifado.Text);
            try
            {
                ModelProduto.Produto produto = ControllerProduto.Produto.BuscaProduto(saldo.IdProduto);
                saldo.NomeProduto = produto.Nome;
                saldo.Quantidade= Convert.ToInt32(produto.Quantidade);
            }
            catch (Exception)
            {
                MessageBox.Show("Id Produto Inválido");
                return;
            }
            try
            {
                ModelProduto.Almoxarifado almoxarifado = ModelProduto.Almoxarifado.ReadAlmoxarifado(saldo.IdAlmoxarifado);
                saldo.NomeAlmoxarifado = almoxarifado.Nome;
            }
            catch (Exception)
            {
                MessageBox.Show("Id Almoxarifado inválido");
                return;
            }
            ControllerProduto.Saldo.CadastraSaldo(saldo.IdProduto, saldo.NomeProduto, saldo.IdAlmoxarifado, saldo.NomeAlmoxarifado, saldo.Quantidade);
            MessageBox.Show("Saldo cadastrado com sucesso");
            LimpaTela();
        }


        public void LimpaTela()
        {
            txtIdProduto.Text = "";
            txtIdAlmoxarifado.Text = "";
        }
    }
}
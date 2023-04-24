/* Módulo Formulário de Editar Saldos
* Descrição : Classe responsável pela criação do formulário de edição de saldos
* Autor : Jussan Igor da Silva
* Data : 22/04/2023
* Versão : 1.0
*/

namespace cadastro_forms.View.Forms.Produto
{
    public class EditarSaldo : Form
    {
        Label lblTitulo;
        Label lblTxtIdSaldo;
        Label lblTxtIdProduto;
        Label lblTxtIdAlmoxarifado;
        TextBox txtIdSaldo;
        TextBox txtIdProduto;
        TextBox txtIdAlmoxarifado;
        Button btnSalvar;
        Button btnCancelar;
        Button btnSair;

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Editar Saldo";
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Size = new Size(200, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            lblTxtIdSaldo = new Label();
            lblTxtIdSaldo.Text = "Id Saldo:";
            lblTxtIdSaldo.Location = new Point(10, 40);
            lblTxtIdSaldo.Size = new Size(200, 20);
            lblTxtIdSaldo.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtIdSaldo.ForeColor = Color.Black;
            this.Controls.Add(lblTxtIdSaldo);

            txtIdSaldo = new TextBox();
            txtIdSaldo.Location = new Point(10, 60);
            txtIdSaldo.Size = new Size(200, 20);
            txtIdSaldo.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            txtIdSaldo.ForeColor = Color.Black;
            this.Controls.Add(txtIdSaldo);


            lblTxtIdProduto = new Label();
            lblTxtIdProduto.Text = "Id Produto:";
            lblTxtIdProduto.Location = new Point(10, 90);
            lblTxtIdProduto.Size = new Size(200, 20);
            lblTxtIdProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtIdProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtIdProduto);

            txtIdProduto = new TextBox();
            txtIdProduto.Location = new Point(10, 110);
            txtIdProduto.Size = new Size(200, 20);
            txtIdProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            txtIdProduto.ForeColor = Color.Black;
            this.Controls.Add(txtIdProduto);

            lblTxtIdAlmoxarifado = new Label();
            lblTxtIdAlmoxarifado.Text = "Id Almoxarifado:";
            lblTxtIdAlmoxarifado.Location = new Point(10, 140);
            lblTxtIdAlmoxarifado.Size = new Size(200, 20);
            lblTxtIdAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtIdAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(lblTxtIdAlmoxarifado);

            txtIdAlmoxarifado = new TextBox();
            txtIdAlmoxarifado.Location = new Point(10, 160);
            txtIdAlmoxarifado.Size = new Size(200, 20);
            txtIdAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            txtIdAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(txtIdAlmoxarifado);

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new Point(10, 190);
            btnSalvar.Size = new Size(200, 20);
            btnSalvar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Click += (sender, e) => {
                SalvarSaldo();
                LimpaTela();
            };
            this.Controls.Add(btnSalvar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(10, 220);
            btnCancelar.Size = new Size(200, 20);
            btnCancelar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Click += (sender, e ) => LimpaTela();
            this.Controls.Add(btnCancelar);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(10, 250);
            btnSair.Size = new Size(200, 20);
            btnSair.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Click += (sender, e) => this.Close();
            this.Controls.Add(btnSair);

            this.Text = "Editar Saldo";
            this.Size = new Size(350, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public EditarSaldo()
        {
            IniciaFormulario();
        }

        public void SalvarSaldo()
        {
            try
            {
                ModelProduto.Saldo saldo = new ModelProduto.Saldo();
                saldo.Id = Convert.ToInt32(txtIdSaldo.Text);
                saldo.IdProduto = Convert.ToInt32(txtIdProduto.Text);
                saldo.IdAlmoxarifado = Convert.ToInt32(txtIdAlmoxarifado.Text);
                try
                {
                    ControllerProduto.Saldo.BuscaSaldo(saldo.Id);
                } catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar saldo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    ModelProduto.Produto produto = ControllerProduto.Produto.BuscaProduto(saldo.IdProduto);
                    saldo.NomeProduto = produto.Nome;
                    saldo.Quantidade = produto.Quantidade;
                } catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    ModelProduto.Almoxarifado almoxarifado = ControllerProduto.Almoxarifado.BuscaAlmoxarifado(saldo.IdAlmoxarifado);
                    saldo.NomeAlmoxarifado = almoxarifado.Nome;
                } catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar almoxarifado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ControllerProduto.Saldo.AlteraSaldo(saldo.Id, saldo.IdProduto, saldo.NomeProduto, saldo.IdAlmoxarifado, saldo.NomeAlmoxarifado, saldo.Quantidade);
                MessageBox.Show("Saldo alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar saldo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpaTela()
        {
            txtIdSaldo.Text = "";
            txtIdProduto.Text = "";
            txtIdAlmoxarifado.Text = "";
        }
    }
}
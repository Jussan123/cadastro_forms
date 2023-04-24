/* Módulo para cadastrar Almoxarifado
 * Descrição : Classe responsável pela criação do formulário de cadastro de Almoxarifado
 * Autor : Jussan Igor da Silva
 * Data : 20/04/2023
 * Versão : 1.0
 */

namespace cadastro_forms.View.Forms.Produto
{
    public class FormAlmoxarifado : Form
    {
        Label lblTituloAlmoxarifado;
        Label lblTxtNomeAlmoxarifado;
        Label lblTxtLocalizaocaoAlmoxarifado;
        TextBox tbNomeAlmoxarifado;
        TextBox tbLocalizacaoAlmoxarifado;
        Button btnSalvarAlmoxarifado;
        Button btnCancelarAlmoxarifado;

        public void IniciaFormulario()
        {
            lblTituloAlmoxarifado = new Label();
            lblTituloAlmoxarifado.Text = "Cadastro de Almoxarifado";
            lblTituloAlmoxarifado.Location = new Point(10, 10);
            lblTituloAlmoxarifado.Size = new Size(200, 20);
            lblTituloAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTituloAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(lblTituloAlmoxarifado);

            lblTxtNomeAlmoxarifado = new Label();
            lblTxtNomeAlmoxarifado.Text = "Nome:";
            lblTxtNomeAlmoxarifado.Location = new Point(10, 40);
            lblTxtNomeAlmoxarifado.Size = new Size(200, 20);
            lblTxtNomeAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtNomeAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(lblTxtNomeAlmoxarifado);

            tbNomeAlmoxarifado = new TextBox();
            tbNomeAlmoxarifado.Location = new Point(10, 60);
            tbNomeAlmoxarifado.Size = new Size(200, 20);
            tbNomeAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbNomeAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(tbNomeAlmoxarifado);

            lblTxtLocalizaocaoAlmoxarifado = new Label();
            lblTxtLocalizaocaoAlmoxarifado.Text = "Localização:";
            lblTxtLocalizaocaoAlmoxarifado.Location = new Point(10, 90);
            lblTxtLocalizaocaoAlmoxarifado.Size = new Size(200, 20);
            lblTxtLocalizaocaoAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtLocalizaocaoAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(lblTxtLocalizaocaoAlmoxarifado);

            tbLocalizacaoAlmoxarifado = new TextBox();
            tbLocalizacaoAlmoxarifado.Location = new Point(10, 110);
            tbLocalizacaoAlmoxarifado.Size = new Size(200, 20);
            tbLocalizacaoAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbLocalizacaoAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(tbLocalizacaoAlmoxarifado);

            btnSalvarAlmoxarifado = new Button();
            btnSalvarAlmoxarifado.Text = "Salvar";
            btnSalvarAlmoxarifado.Location = new Point(10, 140);
            btnSalvarAlmoxarifado.Size = new Size(90, 20);
            btnSalvarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvarAlmoxarifado.ForeColor = Color.Black;
            btnSalvarAlmoxarifado.Click += (sender, e) => {
                SalvarAlmoxarifado();
                LimpaTela();
            };
            this.Controls.Add(btnSalvarAlmoxarifado);

            btnCancelarAlmoxarifado = new Button();
            btnCancelarAlmoxarifado.Text = "Cancelar";
            btnCancelarAlmoxarifado.Location = new Point(120, 140);
            btnCancelarAlmoxarifado.Size = new Size(90, 20);
            btnCancelarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelarAlmoxarifado.ForeColor = Color.Black;
            btnCancelarAlmoxarifado.Click += (sender, e) => this.Close();
            this.Controls.Add(btnCancelarAlmoxarifado);

            this.Text = "Cadastro de Almoxarifado";
            this.Size = new Size(230, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public FormAlmoxarifado()
        {
            IniciaFormulario();
        }

        public void SalvarAlmoxarifado()
        {
            ModelProduto.Almoxarifado almoxarifado = new ModelProduto.Almoxarifado();
            almoxarifado.Nome = tbNomeAlmoxarifado.Text;
            almoxarifado.Localizacao = tbLocalizacaoAlmoxarifado.Text;
            ControllerProduto.Almoxarifado.CadastraAlmoxarifado(almoxarifado.Nome, almoxarifado.Localizacao);
            LimpaTela();
        }

        public void LimpaTela()
        {
            tbNomeAlmoxarifado.Text = "";
            tbLocalizacaoAlmoxarifado.Text = "";
        }
    }
}
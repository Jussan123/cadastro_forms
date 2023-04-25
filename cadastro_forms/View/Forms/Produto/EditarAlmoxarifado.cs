/* Módulo Formulário de Edição de Almoxarifado
* Formulário de Edição de Almoxarifado
* Autor: Jussan Igor da Silva
* Data: 20/04/2023
* Versão: 1.0
*/

namespace cadastro_forms.View.Forms.Produto
{
    public class EditarAlmoxarifado : Form
    {
        Label lblTituloAlmoxarifado;
        Label lblTxtAlmoxarifadoId;
        Label lblTxtNomeAlmoxarifado;
        Label lblTxtLocalizacaoAlmoxarifado;
        TextBox tbAlmoxarifadoId;
        TextBox tbNomeAlmoxarifado;
        TextBox tbLocalizacaoAlmoxarifado;
        Button btnSalvarAlmoxarifado;
        Button btnCancelarAlmoxarifado;
        Button btnVoltarAlmoxarifado;

        public void IniciaFormulario()
        {
            lblTituloAlmoxarifado = new Label();
            lblTituloAlmoxarifado.Text = "Editar Almoxarifado";
            lblTituloAlmoxarifado.Location = new Point(10, 10);
            lblTituloAlmoxarifado.Size = new Size(200, 20);
            lblTituloAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTituloAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(lblTituloAlmoxarifado);

            lblTxtAlmoxarifadoId = new Label();
            lblTxtAlmoxarifadoId.Text = "ID:";
            lblTxtAlmoxarifadoId.Location = new Point(10, 40);
            lblTxtAlmoxarifadoId.Size = new Size(200, 20);
            lblTxtAlmoxarifadoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtAlmoxarifadoId.ForeColor = Color.Black;
            this.Controls.Add(lblTxtAlmoxarifadoId);

            tbAlmoxarifadoId = new TextBox();
            tbAlmoxarifadoId.Location = new Point(10, 60);
            tbAlmoxarifadoId.Size = new Size(200, 20);
            tbAlmoxarifadoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbAlmoxarifadoId.ForeColor = Color.Black;
            this.Controls.Add(tbAlmoxarifadoId);

            lblTxtNomeAlmoxarifado = new Label();
            lblTxtNomeAlmoxarifado.Text = "Nome:";
            lblTxtNomeAlmoxarifado.Location = new Point(10, 80);
            lblTxtNomeAlmoxarifado.Size = new Size(200, 20);
            lblTxtNomeAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtNomeAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(lblTxtNomeAlmoxarifado);

            tbNomeAlmoxarifado = new TextBox();
            tbNomeAlmoxarifado.Location = new Point(10, 100);
            tbNomeAlmoxarifado.Size = new Size(200, 20);
            tbNomeAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbNomeAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(tbNomeAlmoxarifado);

            lblTxtLocalizacaoAlmoxarifado = new Label();
            lblTxtLocalizacaoAlmoxarifado.Text = "Localização:";
            lblTxtLocalizacaoAlmoxarifado.Location = new Point(10, 120);
            lblTxtLocalizacaoAlmoxarifado.Size = new Size(200, 20);
            lblTxtLocalizacaoAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtLocalizacaoAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(lblTxtLocalizacaoAlmoxarifado);

            tbLocalizacaoAlmoxarifado = new TextBox();
            tbLocalizacaoAlmoxarifado.Location = new Point(10, 140);
            tbLocalizacaoAlmoxarifado.Size = new Size(200, 20);
            tbLocalizacaoAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbLocalizacaoAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(tbLocalizacaoAlmoxarifado);

            btnSalvarAlmoxarifado = new Button();
            btnSalvarAlmoxarifado.Text = "Salvar";
            btnSalvarAlmoxarifado.Location = new Point(10, 170);
            btnSalvarAlmoxarifado.Size = new Size(200, 20);
            btnSalvarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvarAlmoxarifado.ForeColor = Color.Black;
            btnSalvarAlmoxarifado.Click += (sender, e) => {
                SalvarProduto();
                LimpaTela();
            };
            this.Controls.Add(btnSalvarAlmoxarifado);

            btnCancelarAlmoxarifado = new Button();
            btnCancelarAlmoxarifado.Text = "Cancelar";
            btnCancelarAlmoxarifado.Location = new Point(10, 200);
            btnCancelarAlmoxarifado.Size = new Size(200, 20);
            btnCancelarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelarAlmoxarifado.ForeColor = Color.Black;
            btnCancelarAlmoxarifado.Click += (sender, e) => LimpaTela();
            this.Controls.Add(btnCancelarAlmoxarifado);

            btnVoltarAlmoxarifado = new Button();
            btnVoltarAlmoxarifado.Text = "Sair";
            btnVoltarAlmoxarifado.Location = new Point(10, 230);
            btnVoltarAlmoxarifado.Size = new Size(200, 20);
            btnVoltarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnVoltarAlmoxarifado.ForeColor = Color.Black;
            btnVoltarAlmoxarifado.Click += (sender, e) => this.Close();
            this.Controls.Add(btnVoltarAlmoxarifado);

            this.Text = "Editar Almoxarifado";
            this.Size = new Size(230, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public EditarAlmoxarifado(){
            IniciaFormulario();
        }

        public void SalvarProduto()
        {
            try
            {
                ModelProduto.Almoxarifado Almoxarifado = new ModelProduto.Almoxarifado();
                Almoxarifado.Id = Convert.ToInt32(tbAlmoxarifadoId.Text);
                Almoxarifado.Nome = tbNomeAlmoxarifado.Text;
                Almoxarifado.Localizacao = tbLocalizacaoAlmoxarifado.Text;

                ControllerProduto.Almoxarifado almoxarifadoController = new ControllerProduto.Almoxarifado();
                ControllerProduto.Almoxarifado.AlteraAlmoxarifado(Almoxarifado.Id, Almoxarifado.Nome, Almoxarifado.Localizacao);

                MessageBox.Show("Almoxarifado alterado com sucesso!");
            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Almoxarifado: " + ex.Message);
            }
        }

        public void LimpaTela()
        {
            tbAlmoxarifadoId.Text = "";
            tbNomeAlmoxarifado.Text = "";
            tbLocalizacaoAlmoxarifado.Text = "";
        }
    }

    public class EditaNomeAlmoxarifado : Form
    {
        Label lblTitulo;
        Label lblNomeAlmoxarifado;
        TextBox tbNomeAlmoxarifado;
        Label lblAlmoxarifadoId;
        TextBox tbAlmoxarifadoId;
        Button btnSalvarAlmoxarifado;
        Button btnCancelarAlmoxarifado;
        Button btnVoltarAlmoxarifado;

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Editar Nome do Almoxarifado";
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Size = new Size(200, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            lblAlmoxarifadoId = new Label();
            lblAlmoxarifadoId.Text = "Id:";
            lblAlmoxarifadoId.Location = new Point(10, 40);
            lblAlmoxarifadoId.Size = new Size(200, 20);
            lblAlmoxarifadoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblAlmoxarifadoId.ForeColor = Color.Black;
            this.Controls.Add(lblAlmoxarifadoId);

            tbAlmoxarifadoId = new TextBox();
            tbAlmoxarifadoId.Location = new Point(10, 60);
            tbAlmoxarifadoId.Size = new Size(200, 20);
            tbAlmoxarifadoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbAlmoxarifadoId.ForeColor = Color.Black;
            this.Controls.Add(tbAlmoxarifadoId);

            lblNomeAlmoxarifado = new Label();
            lblNomeAlmoxarifado.Text = "Nome:";
            lblNomeAlmoxarifado.Location = new Point(10, 90);
            lblNomeAlmoxarifado.Size = new Size(200, 20);
            lblNomeAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblNomeAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(lblNomeAlmoxarifado);

            tbNomeAlmoxarifado = new TextBox();
            tbNomeAlmoxarifado.Location = new Point(10, 110);
            tbNomeAlmoxarifado.Size = new Size(200, 20);
            tbNomeAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbNomeAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(tbNomeAlmoxarifado);

            btnSalvarAlmoxarifado = new Button();
            btnSalvarAlmoxarifado.Text = "Salvar";
            btnSalvarAlmoxarifado.Location = new Point(10, 140);
            btnSalvarAlmoxarifado.Size = new Size(200, 20);
            btnSalvarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvarAlmoxarifado.ForeColor = Color.Black;
            btnSalvarAlmoxarifado.Click += (sender, e) => SalvarNomeAlmoxarifado();
            this.Controls.Add(btnSalvarAlmoxarifado);

            btnCancelarAlmoxarifado = new Button();
            btnCancelarAlmoxarifado.Text = "Cancelar";
            btnCancelarAlmoxarifado.Location = new Point(10, 170);
            btnCancelarAlmoxarifado.Size = new Size(200, 20);
            btnCancelarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelarAlmoxarifado.ForeColor = Color.Black;
            btnCancelarAlmoxarifado.Click += (sender, e) => LimpaTela();
            this.Controls.Add(btnCancelarAlmoxarifado);

            btnVoltarAlmoxarifado = new Button();
            btnVoltarAlmoxarifado.Text = "Sair";
            btnVoltarAlmoxarifado.Location = new Point(10, 200);
            btnVoltarAlmoxarifado.Size = new Size(200, 20);
            btnVoltarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnVoltarAlmoxarifado.ForeColor = Color.Black;
            btnVoltarAlmoxarifado.Click += (sender, e) => this.Close();
            this.Controls.Add(btnVoltarAlmoxarifado);

            this.Text = "Editar Nome do Almoxarifado";
            this.Size = new Size(230, 270);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void SalvarNomeAlmoxarifado()
        {
            ModelProduto.Almoxarifado Almoxarifado = new ModelProduto.Almoxarifado();
            Almoxarifado.Id = Convert.ToInt32(tbAlmoxarifadoId.Text);
            Almoxarifado.Nome = tbNomeAlmoxarifado.Text;

            ControllerProduto.Almoxarifado.AlteraNomeAlmoxarifado(Almoxarifado.Id, Almoxarifado.Nome);

            MessageBox.Show("Nome do Almoxarifado alterado com sucesso!");
        }

        public void LimpaTela()
        {
            tbAlmoxarifadoId.Text = "";
            tbNomeAlmoxarifado.Text = "";
        }

        public EditaNomeAlmoxarifado()
        {
            IniciaFormulario();
        }
    }

    public class EditaLocalizacaoAlmoxarifado : Form
    {
        Label lblTitulo;
        Label lblLocalizacaoAlmoxarifado;
        Label lblAlmoxarifadoId;
        TextBox tbAlmoxarifadoId;
        TextBox tbLocalizacaoAlmoxarifado;
        Button btnSalvarAlmoxarifado;
        Button btnCancelarAlmoxarifado;
        Button btnVoltarAlmoxarifado;

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Editar Localização do Almoxarifado";
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Size = new Size(200, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            lblAlmoxarifadoId = new Label();
            lblAlmoxarifadoId.Text = "Id:";
            lblAlmoxarifadoId.Location = new Point(10, 40);
            lblAlmoxarifadoId.Size = new Size(200, 20);
            lblAlmoxarifadoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblAlmoxarifadoId.ForeColor = Color.Black;
            this.Controls.Add(lblAlmoxarifadoId);

            tbAlmoxarifadoId = new TextBox();
            tbAlmoxarifadoId.Location = new Point(10, 60);
            tbAlmoxarifadoId.Size = new Size(200, 20);
            tbAlmoxarifadoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbAlmoxarifadoId.ForeColor = Color.Black;
            this.Controls.Add(tbAlmoxarifadoId);

            lblLocalizacaoAlmoxarifado = new Label();
            lblLocalizacaoAlmoxarifado.Text = "Localização:";
            lblLocalizacaoAlmoxarifado.Location = new Point(10, 90);
            lblLocalizacaoAlmoxarifado.Size = new Size(200, 20);
            lblLocalizacaoAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblLocalizacaoAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(lblLocalizacaoAlmoxarifado);

            tbLocalizacaoAlmoxarifado = new TextBox();
            tbLocalizacaoAlmoxarifado.Location = new Point(10, 110);
            tbLocalizacaoAlmoxarifado.Size = new Size(200, 20);
            tbLocalizacaoAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbLocalizacaoAlmoxarifado.ForeColor = Color.Black;
            this.Controls.Add(tbLocalizacaoAlmoxarifado);

            btnSalvarAlmoxarifado = new Button();
            btnSalvarAlmoxarifado.Text = "Salvar";
            btnSalvarAlmoxarifado.Location = new Point(10, 140);
            btnSalvarAlmoxarifado.Size = new Size(200, 20);
            btnSalvarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvarAlmoxarifado.ForeColor = Color.Black;
            btnSalvarAlmoxarifado.Click += (sender, e) => {
                SalvarLocalizacaoAlmoxarifado();
                LimpaTela();
            };
            this.Controls.Add(btnSalvarAlmoxarifado);

            btnCancelarAlmoxarifado = new Button();
            btnCancelarAlmoxarifado.Text = "Cancelar";
            btnCancelarAlmoxarifado.Location = new Point(10, 170);
            btnCancelarAlmoxarifado.Size = new Size(200, 20);
            btnCancelarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelarAlmoxarifado.ForeColor = Color.Black;
            btnCancelarAlmoxarifado.Click += (sender, e) => {
                LimpaTela();
            };
            this.Controls.Add(btnCancelarAlmoxarifado);

            btnVoltarAlmoxarifado = new Button();
            btnVoltarAlmoxarifado.Text = "Sair";
            btnVoltarAlmoxarifado.Location = new Point(10, 200);
            btnVoltarAlmoxarifado.Size = new Size(200, 20);
            btnVoltarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnVoltarAlmoxarifado.ForeColor = Color.Black;
            btnVoltarAlmoxarifado.Click += (sender, e) => this.Close();
            this.Controls.Add(btnVoltarAlmoxarifado);

            this.Text = "Editar Localização do Almoxarifado";
            this.Size = new Size(230, 260);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void SalvarLocalizacaoAlmoxarifado()
        {
            ModelProduto.Almoxarifado Almoxarifado = new ModelProduto.Almoxarifado();

            Almoxarifado.Id = Convert.ToInt32(tbAlmoxarifadoId.Text);
            Almoxarifado.Localizacao = tbLocalizacaoAlmoxarifado.Text;

            ControllerProduto.Almoxarifado.AlteraLocalizacaoAlmoxarifado(Almoxarifado.Id, Almoxarifado.Localizacao);

            MessageBox.Show("Localização do Almoxarifado alterada com sucesso!");
        }

        public void LimpaTela()
        {
            tbAlmoxarifadoId.Text = "";
            tbLocalizacaoAlmoxarifado.Text = "";
        }

        public EditaLocalizacaoAlmoxarifado()
        {
            IniciaFormulario();
        }
    }
}

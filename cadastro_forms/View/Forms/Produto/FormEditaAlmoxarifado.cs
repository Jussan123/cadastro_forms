/* Módulo Formulário para editar Almoxarifado
 * Formulário para editar Almoxarifado
 * Autor: Jussan Igor da Silva
 * Data: 20/04/2023
 * Versão: 1.0
 */

 namespace cadastro_forms.View.Forms.Produto
 {
    public class FormEditaAlmoxarifado : Form
    {
        Label lblTituloAlmoxarifado;
        Button btnEditarAlmoxarifado;
        Button btnEditarNomeAlmoxarifado;
        Button btnEditarLocalizacaoAlmoxarifado;
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

            btnEditarAlmoxarifado = new Button();
            btnEditarAlmoxarifado.Text = "Editar";
            btnEditarAlmoxarifado.Location = new Point(10, 40);
            btnEditarAlmoxarifado.Size = new Size(200, 20);
            btnEditarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnEditarAlmoxarifado.ForeColor = Color.Black;
            btnEditarAlmoxarifado.Click += (sender, e) => {
                AbrirFormEditaCompleto(new EditarAlmoxarifado());
            };
            this.Controls.Add(btnEditarAlmoxarifado);

            btnEditarNomeAlmoxarifado = new Button();
            btnEditarNomeAlmoxarifado.Text = "Editar Nome";
            btnEditarNomeAlmoxarifado.Location = new Point(10, 70);
            btnEditarNomeAlmoxarifado.Size = new Size(200, 20);
            btnEditarNomeAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnEditarNomeAlmoxarifado.ForeColor = Color.Black;
            btnEditarNomeAlmoxarifado.Click += (sender, e) => {
                AbrirFormEditaNome(new EditaNomeAlmoxarifado());
            };
            this.Controls.Add(btnEditarNomeAlmoxarifado);

            btnEditarLocalizacaoAlmoxarifado = new Button();
            btnEditarLocalizacaoAlmoxarifado.Text = "Editar Localização";
            btnEditarLocalizacaoAlmoxarifado.Location = new Point(10, 100);
            btnEditarLocalizacaoAlmoxarifado.Size = new Size(200, 20);
            btnEditarLocalizacaoAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnEditarLocalizacaoAlmoxarifado.ForeColor = Color.Black;
            btnEditarLocalizacaoAlmoxarifado.Click += (sender, e) => {
                AbrirFormEditaLocalizacao(new EditaLocalizacaoAlmoxarifado());
            };
            this.Controls.Add(btnEditarLocalizacaoAlmoxarifado);

            btnVoltarAlmoxarifado = new Button();
            btnVoltarAlmoxarifado.Text = "Voltar";
            btnVoltarAlmoxarifado.Location = new Point(10, 130);
            btnVoltarAlmoxarifado.Size = new Size(200, 20);
            btnVoltarAlmoxarifado.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnVoltarAlmoxarifado.ForeColor = Color.Black;
            btnVoltarAlmoxarifado.Click += (sender, e) => this.Close();
            this.Controls.Add(btnVoltarAlmoxarifado);

            this.Text = "Editar Almoxarifado";
            this.Size = new Size(230, 200);
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

        public void AbrirFormEditaLocalizacao(Form form)
        {
            form.ShowDialog();
        }

        public FormEditaAlmoxarifado()
        {
            IniciaFormulario();
        }
    }
 }
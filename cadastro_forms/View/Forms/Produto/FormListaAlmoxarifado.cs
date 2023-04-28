/* Método Formulário de Listar Almoxarifado
 * Método que representa o formulario de listar Almoxarifado
 * Autor: Jussan Igor da Silva
 * Data: 20/04/2023
 * Versão: 1.0
 */


namespace cadastro_forms.View.Forms.Produto
{
    public class FormListaAlmoxarifado : Form
    {
        Label lblTitulo;
        Label lblTxtLista;
        ListBox lstAlmoxarifados;
        Button btnIncluiAlmoxarifado;
        Button btnAlteraAlmoxarifado;
        Button btnExcluiAlmoxarifado;
        Button btnSair;
        Button btnRefresh;
        DataGridView dataGridView;

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Lista de Almoxarifado";
            lblTitulo.Location = new Point(122, 10);
            lblTitulo.Size = new Size(200, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 14, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            dataGridView = new DataGridView();
            dataGridView.Location = new Point(50, 30);
            dataGridView.Size = new Size(343, 400);
            dataGridView.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            // configurar Colunas
            dataGridView.Columns.Add("id", "ID");
            dataGridView.Columns.Add("nome", "Nome");
            dataGridView.Columns.Add("localizacao", "Localização");

            foreach (var almoxarifado in ControllerProduto.Almoxarifado.ListaAlmoxarifado())
            {
                dataGridView.Rows.Add(almoxarifado.Id, almoxarifado.Nome, almoxarifado.Localizacao);
            }
            // Configura a Formatação das células da tabela
            dataGridView.DefaultCellStyle.Font = new Font("TrebuchetMS", 10, FontStyle.Regular);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            this.Controls.Add(dataGridView);

            btnIncluiAlmoxarifado = new Button();
            btnIncluiAlmoxarifado.Text = "Incluir";
            btnIncluiAlmoxarifado.Location = new Point(60, 440);
            btnIncluiAlmoxarifado.Size = new Size(100, 30);
            btnIncluiAlmoxarifado.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnIncluiAlmoxarifado.ForeColor = Color.Black;
            btnIncluiAlmoxarifado.Click += (sender, e) => {
                AbrirForm(new FormAlmoxarifado());
                this.minhaLista();
            };
            this.Controls.Add(btnIncluiAlmoxarifado);

            btnAlteraAlmoxarifado = new Button();
            btnAlteraAlmoxarifado.Text = "Editar";
            btnAlteraAlmoxarifado.Location = new Point(170, 440);
            btnAlteraAlmoxarifado.Size = new Size(100, 30);
            btnAlteraAlmoxarifado.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnAlteraAlmoxarifado.ForeColor = Color.Black;
            btnAlteraAlmoxarifado.Click += (sender, e) => {
                AbrirForm(new FormEditaAlmoxarifado());
                this.minhaLista();
            };
            this.Controls.Add(btnAlteraAlmoxarifado);

            btnExcluiAlmoxarifado = new Button();
            btnExcluiAlmoxarifado.Text = "Excluir";
            btnExcluiAlmoxarifado.Location = new Point(280, 440);
            btnExcluiAlmoxarifado.Size = new Size(100, 30);
            btnExcluiAlmoxarifado.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnExcluiAlmoxarifado.ForeColor = Color.Black;
            btnExcluiAlmoxarifado.Click += (sender, e) => {
                var id = dataGridView.CurrentRow.Cells[0].Value;
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                AbrirForm(new FormConfirmDeleteAlmoxarifado(Convert.ToInt32(id)));
                this.minhaLista();
            };
            this.Controls.Add(btnExcluiAlmoxarifado);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(280, 475);
            btnSair.Size = new Size(100, 30);
            btnSair.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Click += (sender, e) => this.Close();
            this.Controls.Add(btnSair);

            btnRefresh = new Button();
            btnRefresh.Text = "Refresh";
            btnRefresh.Location = new Point(60, 475);
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Click += (sender, e) => this.minhaLista();
            this.Controls.Add(btnRefresh);

            this.Text = "Lista de Almoxarifado";
            this.Size = new Size(443, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public FormListaAlmoxarifado()
        {
            IniciaFormulario();
        }

        public void AbrirForm(Form form)
        {
            form.ShowDialog();
        }

        public void minhaLista()
        {
            dataGridView.Rows.Clear();
            foreach (var almoxarifado in ControllerProduto.Almoxarifado.ListaAlmoxarifado())
            {
                dataGridView.Rows.Add(almoxarifado.Id, almoxarifado.Nome, almoxarifado.Localizacao);
            }                
        }
    }
}
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

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Lista de Itens no Almoxarifado";
            lblTitulo.Location = new Point(250, 10);
            lblTitulo.Size = new Size(200, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 14, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            var dataGridView = new DataGridView();
            dataGridView.Location = new Point(50, 30);
            dataGridView.Size = new Size(350, 400);
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
            btnIncluiAlmoxarifado.Location = new Point(10, 440);
            btnIncluiAlmoxarifado.Size = new Size(100, 30);
            btnIncluiAlmoxarifado.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnIncluiAlmoxarifado.ForeColor = Color.Black;
            btnIncluiAlmoxarifado.Click += (sender, e) => {
                AbrirForm(new FormAlmoxarifado());
            };
            this.Controls.Add(btnIncluiAlmoxarifado);

            btnAlteraAlmoxarifado = new Button();
            btnAlteraAlmoxarifado.Text = "Alterar";
            btnAlteraAlmoxarifado.Location = new Point(120, 440);
            btnAlteraAlmoxarifado.Size = new Size(100, 30);
            btnAlteraAlmoxarifado.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnAlteraAlmoxarifado.ForeColor = Color.Black;
            btnAlteraAlmoxarifado.Click += (sender, e) => {
                AbrirForm(new FormEditaAlmoxarifado());
            };
            this.Controls.Add(btnAlteraAlmoxarifado);

            btnExcluiAlmoxarifado = new Button();
            btnExcluiAlmoxarifado.Text = "Excluir";
            btnExcluiAlmoxarifado.Location = new Point(230, 440);
            btnExcluiAlmoxarifado.Size = new Size(100, 30);
            btnExcluiAlmoxarifado.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnExcluiAlmoxarifado.ForeColor = Color.Black;
            btnExcluiAlmoxarifado.Click += (sender, e) => {
                var id = dataGridView.CurrentRow.Cells[0].Value;
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                AbrirForm(new FormConfirmDeleteAlmoxarifado(Convert.ToInt32(id)));
            };
            this.Controls.Add(btnExcluiAlmoxarifado);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(230, 475);
            btnSair.Size = new Size(100, 30);
            btnSair.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Click += (sender, e) => this.Close();
            this.Controls.Add(btnSair);

            btnRefresh = new Button();
            btnRefresh.Text = "Refresh";
            btnRefresh.Location = new Point(10, 475);
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Click += (sender, e) => {
                dataGridView.Rows.Clear();
                foreach (var almoxarifado in ControllerProduto.Almoxarifado.ListaAlmoxarifado())
                {
                    dataGridView.Rows.Add(almoxarifado.Id, almoxarifado.Nome, almoxarifado.Localizacao);
                }                
            };
            this.Controls.Add(btnRefresh);

            this.Text = "Lista de Itens no Almoxarifado";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowDialog();
        }

        public FormListaAlmoxarifado()
        {
            IniciaFormulario();
        }

        public void AbrirForm(Form form)
        {
            form.ShowDialog();
        }
    }
}
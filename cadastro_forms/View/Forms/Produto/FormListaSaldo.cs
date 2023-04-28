/* Módulo Formulário para Listar Saldos
* Descrição : Classe responsável pela criação do formulário de listagem de saldos
* Autor : Jussan Igor da Silva
* Data : 22/04/2023
* Versão : 1.0
*/

namespace cadastro_forms.View.Forms.Produto
{
    public class FormListaSaldo : Form
    {
        Label lblTitulo;
        Label lblTxtLista;
        ListBox lbLista;
        Button btnIncluir;
        Button btnAlterar;
        Button btnExcluir;
        Button btnSair;
        Button btnRefresh;
        DataGridView dataGridView;

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Listagem de Saldos";
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Size = new Size(200, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            lblTxtLista = new Label();
            lblTxtLista.Text = "Lista:";
            lblTxtLista.Location = new Point(10, 40);
            lblTxtLista.Size = new Size(200, 20);
            lblTxtLista.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtLista.ForeColor = Color.Black;
            this.Controls.Add(lblTxtLista);

            dataGridView = new DataGridView();
            dataGridView.Location = new Point(50, 60);
            dataGridView.Size = new Size(773, 400);
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                // alinhar o conteúdo das células no centro
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // permite que o conteúdo das células seja ajustado automaticamente
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("ProdutoId", "ID Produto");
            dataGridView.Columns.Add("NomeProduto", "Produto");
            dataGridView.Columns.Add("AlmoxarifadoId", "ID Almoxarifado");
            dataGridView.Columns.Add("NomeAlmoxarifado", "Almoxarifado");
            dataGridView.Columns.Add("Quantidade", "Quantidade");
            dataGridView.Columns.Add("DataUltimaAtualizacao", "Data Atualização");
            dataGridView.Columns["DataUltimaAtualizacao"].MinimumWidth = 130;
            this.minhaLista();
            dataGridView.DefaultCellStyle.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            this.Controls.Add(dataGridView);

            btnIncluir = new Button();
            btnIncluir.Text = "Incluir";
            btnIncluir.Location = new Point(10, 500);
            btnIncluir.Size = new Size(60, 20);
            btnIncluir.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnIncluir.ForeColor = Color.Black;
            btnIncluir.Click += (sender, e) => {
                AbrirFormulario(new FormSaldo());
                this.minhaLista();
            };
            this.Controls.Add(btnIncluir);

            btnAlterar = new Button();
            btnAlterar.Text = "Editar";
            btnAlterar.Location = new Point(80, 500);
            btnAlterar.Size = new Size(60, 20);
            btnAlterar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnAlterar.ForeColor = Color.Black;
            btnAlterar.Click += (sender, e) => {
                AbrirFormulario(new EditarSaldo());
                this.minhaLista();
            };
            this.Controls.Add(btnAlterar);

            btnExcluir = new Button();
            btnExcluir.Text = "Excluir";
            btnExcluir.Location = new Point(150, 500);
            btnExcluir.Size = new Size(60, 20);
            btnExcluir.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Click += (sender, e) => {
                var id = dataGridView.CurrentRow.Cells[0].Value.ToString();
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                AbrirFormulario(new FormConfirmeDeleteSaldo(Convert.ToInt32(id)));
                this.minhaLista();
            };
            this.Controls.Add(btnExcluir);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(220, 500);
            btnSair.Size = new Size(60, 20);
            btnSair.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Click += (sender, e) => {
                this.Close();
            };
            this.Controls.Add(btnSair);

            btnRefresh = new Button();
            btnRefresh.Text = "Refresh";
            btnRefresh.Location = new Point(290, 500);
            btnRefresh.Size = new Size(60, 20);
            btnRefresh.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Click += (sender, e) => this.minhaLista();
            this.Controls.Add(btnRefresh);

            this.Text = "Listagem de Saldos";
            this.Size = new Size(873, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void AbrirFormulario(Form formulario)
        {
            formulario.ShowDialog();
        }

        public FormListaSaldo()
        {
            IniciaFormulario();
        }

        public void minhaLista()
        {
            dataGridView.Rows.Clear();
            foreach (var saldo in ControllerProduto.Saldo.ListarSaldo())
            {
                dataGridView.Rows.Add(saldo.Id, saldo.ProdutoId, saldo.Produto, saldo.AlmoxarifadoId, saldo.Almoxarifado, saldo.Quantidade, saldo.DataUltimaAtualizacao);
            }
        }
    }
}
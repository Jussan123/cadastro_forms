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
        Label lblTxtQuantidade;
        ComboBox cbProdutoId;
        ComboBox cbAlmoxarifadoId;
        TextBox txtQuantidade;
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

            cbProdutoId = new ComboBox();
            cbProdutoId.Location = new Point(10, 50);
            cbProdutoId.Size = new Size(200, 20);
            cbProdutoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            cbProdutoId.ForeColor = Color.Black;
            List<ModelProduto.Produto> listaProduto = new List<ModelProduto.Produto>();
            foreach (ModelProduto.Produto produto in ControllerProduto.Produto.ListaProdutos())
            {
                cbProdutoId.Items.Add(produto);
            }
            cbProdutoId.ValueMember = "Id";
            cbProdutoId.DisplayMember = "Nome";
            cbProdutoId.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(cbProdutoId);

            lblTxtAlmoxarifadoId = new Label();
            lblTxtAlmoxarifadoId.Text = "Id Almoxarifado:";
            lblTxtAlmoxarifadoId.Location = new Point(10, 80);
            lblTxtAlmoxarifadoId.Size = new Size(200, 20);
            lblTxtAlmoxarifadoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtAlmoxarifadoId.ForeColor = Color.Black;
            this.Controls.Add(lblTxtAlmoxarifadoId);

            cbAlmoxarifadoId = new ComboBox();
            cbAlmoxarifadoId.Location = new Point(10, 100);
            cbAlmoxarifadoId.Size = new Size(200, 20);
            cbAlmoxarifadoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            cbAlmoxarifadoId.ForeColor = Color.Black;
            
            List<ModelProduto.Almoxarifado> listaAlmoxarifado = new List<ModelProduto.Almoxarifado>();
            foreach (ModelProduto.Almoxarifado almoxarifado in ControllerProduto.Almoxarifado.ListaAlmoxarifado())
            {
                cbAlmoxarifadoId.Items.Add(almoxarifado);
            }
            cbAlmoxarifadoId.ValueMember = "Id";
            cbAlmoxarifadoId.DisplayMember = "Nome";
            cbAlmoxarifadoId.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(cbAlmoxarifadoId);

            lblTxtQuantidade = new Label();
            lblTxtQuantidade.Text = "Quantidade:";
            lblTxtQuantidade.Location = new Point(10, 130);
            lblTxtQuantidade.Size = new Size(200, 20);
            lblTxtQuantidade.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtQuantidade.ForeColor = Color.Black;
            this.Controls.Add(lblTxtQuantidade);

            txtQuantidade = new TextBox();
            txtQuantidade.Location = new Point(10, 150);
            txtQuantidade.Size = new Size(200, 20);
            txtQuantidade.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            txtQuantidade.ForeColor = Color.Black;
            this.Controls.Add(txtQuantidade);

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new Point(10, 180);
            btnSalvar.Size = new Size(80, 20);
            btnSalvar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Click += (sender, e) => {
                SalvarSaldo();
                LimpaTela();
            };
            this.Controls.Add(btnSalvar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(100, 180);
            btnCancelar.Size = new Size(80, 20);
            btnCancelar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Click += (sender, e) => {
                LimpaTela();
            };
            this.Controls.Add(btnCancelar);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(190, 180);
            btnSair.Size = new Size(80, 20);
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
            var produtoSelecionado = (ModelProduto.Produto) cbProdutoId.SelectedItem;
            var almoxarifadoSelecionado = (ModelProduto.Almoxarifado) cbAlmoxarifadoId.SelectedItem;
            if(produtoSelecionado == null || almoxarifadoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto e um almoxarifado");
                return;
            }

            saldo.ProdutoId = Convert.ToInt32(produtoSelecionado.Id);
            saldo.AlmoxarifadoId = Convert.ToInt32(almoxarifadoSelecionado.Id);
            saldo.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            try
            {
                ModelProduto.Produto produto = ControllerProduto.Produto.BuscaProduto(saldo.ProdutoId);
                saldo.Produto = produto;
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
            cbProdutoId.SelectedIndex = -1;
            cbAlmoxarifadoId.SelectedIndex = -1;
            txtQuantidade.Text = "";
        }
    }
}
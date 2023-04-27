/* Módulo Formulários de Edição de Produtos
    * Descrição : Classe responsável pela criação da tela de edição de produtos
    * Autor : Jussan Igor da Silva
    * Data : 15/04/2023
    * Versão : 1.0
*/

namespace cadastro_forms.View.Forms.Produto
{
    public class EditarProduto : Form
    {
        Label lblTitulo;
        Label lblTxtProdutoId;
        Label lblTxtNomeProduto;
        Label lblTxtDescricaoProduto;
        Label lblTxtPrecoProduto;
        ComboBox cbProdutoId;
        TextBox tbNomeProduto;
        TextBox tbDescricaoProduto;
        TextBox tbPrecoProduto;
        Button btnSalvarProduto;
        Button btnCancelarProduto;
        Button btnSair;

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Tela de Edição de Produto";
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Size = new Size(400, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 12, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            lblTxtProdutoId = new Label();
            lblTxtProdutoId.Text = "Id:";
            lblTxtProdutoId.Location = new Point(10, 40);
            lblTxtProdutoId.Size = new Size(40, 20);
            lblTxtProdutoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtProdutoId.ForeColor = Color.Black;
            this.Controls.Add(lblTxtProdutoId);

            cbProdutoId = new ComboBox();
            cbProdutoId.Location = new Point(10, 60);
            cbProdutoId.Size = new Size(100, 20);
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
            
            lblTxtNomeProduto = new Label();
            lblTxtNomeProduto.Text = "Nome:";
            lblTxtNomeProduto.Location = new Point(10, 90);
            lblTxtNomeProduto.Size = new Size(40, 20);
            lblTxtNomeProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtNomeProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtNomeProduto);

            tbNomeProduto = new TextBox();
            tbNomeProduto.Location = new Point(10, 110);
            tbNomeProduto.Size = new Size(200, 20);
            tbNomeProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbNomeProduto.ForeColor = Color.Black;
            this.Controls.Add(tbNomeProduto);

            lblTxtDescricaoProduto = new Label();
            lblTxtDescricaoProduto.Text = "Descrição:";
            lblTxtDescricaoProduto.Location = new Point(10, 130);
            lblTxtDescricaoProduto.Size = new Size(200, 20);
            lblTxtDescricaoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtDescricaoProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtDescricaoProduto);

            tbDescricaoProduto = new TextBox();
            tbDescricaoProduto.Location = new Point(10, 150);
            tbDescricaoProduto.Size = new Size(200, 20);
            tbDescricaoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbDescricaoProduto.ForeColor = Color.Black;
            this.Controls.Add(tbDescricaoProduto);

            lblTxtPrecoProduto = new Label();
            lblTxtPrecoProduto.Text = "Preço:";
            lblTxtPrecoProduto.Location = new Point(10, 180);
            lblTxtPrecoProduto.Size = new Size(200, 20);
            lblTxtPrecoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtPrecoProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtPrecoProduto);

            tbPrecoProduto = new TextBox();
            tbPrecoProduto.Location = new Point(10, 200);
            tbPrecoProduto.Size = new Size(200, 20);
            tbPrecoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbPrecoProduto.ForeColor = Color.Black;
            this.Controls.Add(tbPrecoProduto);

            btnSalvarProduto = new Button();
            btnSalvarProduto.Text = "Salvar";
            btnSalvarProduto.Location = new Point(10, 230);
            btnSalvarProduto.Size = new Size(100, 20);
            btnSalvarProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvarProduto.ForeColor = Color.Black;
            btnSalvarProduto.Click += (sender, e) => {
                SalvarProduto();
                LimpaTela();
            };
            this.Controls.Add(btnSalvarProduto);

            btnCancelarProduto = new Button();
            btnCancelarProduto.Text = "Cancelar";
            btnCancelarProduto.Location = new Point(120, 230);
            btnCancelarProduto.Size = new Size(100, 20);
            btnCancelarProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelarProduto.ForeColor = Color.Black;
            btnCancelarProduto.Click += (sender, e) => LimpaTela();
            this.Controls.Add(btnCancelarProduto);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(230, 230);
            btnSair.Size = new Size(100, 20);
            btnSair.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Click += (sender, e) => this.Close();
            this.Controls.Add(btnSair);

            this.Text = "Editar Produto";
            this.Size = new Size(350, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public EditarProduto(){
            IniciaFormulario();
        }

        public void SalvarProduto()
        {
            try
            {
                ModelProduto.Produto produto = new ModelProduto.Produto();
                produto.Id = Convert.ToInt32(cbProdutoId.Text);
                produto.Nome = tbNomeProduto.Text;
                produto.Descricao = tbDescricaoProduto.Text;
                produto.Preco = Convert.ToDecimal(tbPrecoProduto.Text);

                ControllerProduto.Produto produtoController = new ControllerProduto.Produto();
                ControllerProduto.Produto.AlteraProduto(produto.Id, produto.Nome, produto.Descricao, produto.Preco);

                MessageBox.Show("Produto Alterado com sucesso!");
            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar produto: " + ex.Message + ex.StackTrace + ex.Source + ex.InnerException + ex.TargetSite);
            }
        }

        public void LimpaTela()
        {
            tbDescricaoProduto.Text ="";
            tbNomeProduto.Text = "";
            tbPrecoProduto.Text = "";
        }
    }

    public class EditaNomeProduto : Form
    {
        Label lblTitulo;
        Label lblNomeProduto;
        TextBox tbNomeProduto;
        Label lblProdutoId;
        ComboBox cbProdutoId;
        Button btnSalvar;
        Button btnCancelar;
        Button btnSair;

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Editar Nome do Produto";
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Size = new Size(200, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 12, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            lblNomeProduto = new Label();
            lblNomeProduto.Text = "Nome:";
            lblNomeProduto.Location = new Point(10, 40);
            lblNomeProduto.Size = new Size(200, 20);
            lblNomeProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblNomeProduto.ForeColor = Color.Black;
            this.Controls.Add(lblNomeProduto);

            tbNomeProduto = new TextBox();
            tbNomeProduto.Location = new Point(10, 60);
            tbNomeProduto.Size = new Size(200, 20);
            tbNomeProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbNomeProduto.ForeColor = Color.Black;
            this.Controls.Add(tbNomeProduto);

            lblProdutoId = new Label();
            lblProdutoId.Text = "Id:";
            lblProdutoId.Location = new Point(10, 80);
            lblProdutoId.Size = new Size(200, 20);
            lblProdutoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblProdutoId.ForeColor = Color.Black;
            this.Controls.Add(lblProdutoId);

            cbProdutoId = new ComboBox();
            cbProdutoId.Location = new Point(10, 100);
            cbProdutoId.Size = new Size(100, 20);
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

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new Point(10, 130);
            btnSalvar.Size = new Size(100, 20);
            btnSalvar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Click += (sender, e) => {
                SalvarNomeProduto();
                LimpaTela();
            };
            this.Controls.Add(btnSalvar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(120, 130);
            btnCancelar.Size = new Size(100, 20);
            btnCancelar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Click += (sender, e) => {
                LimpaTela();
            };
            this.Controls.Add(btnCancelar);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(230, 130);
            btnSair.Size = new Size(100, 20);
            btnSair.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Click += (sender, e) => {
                this.Close();
            };
            this.Controls.Add(btnSair);

            this.Text = "Editar Nome do Produto";
            this.Size = new Size(350, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void SalvarNomeProduto()
        {
            ModelProduto.Produto produto = new ModelProduto.Produto();
            produto.Nome = tbNomeProduto.Text;
            produto.Id = Convert.ToInt32(cbProdutoId.Text);

            ControllerProduto.Produto.AlteraNomeProduto(produto.Id, produto.Nome);

            MessageBox.Show("Nome do produto editado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimpaTela()
        {
            tbNomeProduto.Text = "";
            cbProdutoId.Text = "";
        }

        public EditaNomeProduto()
        {
            IniciaFormulario();
        }
    }

    public class EditaDescricaoProduto : Form
    {
        Label lblTitulo;
        Label lblDescricaoProduto;
        TextBox tbDescricaoProduto;
        Label lblProdutoId;
        ComboBox cbProdutoId;
        Button btnSalvar;
        Button btnCancelar;
        Button btnSair;

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Editar Descrição do Produto";
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Size = new Size(400, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 12, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            lblDescricaoProduto = new Label();
            lblDescricaoProduto.Text = "Descrição:";
            lblDescricaoProduto.Location = new Point(10, 40);
            lblDescricaoProduto.Size = new Size(200, 20);
            lblDescricaoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblDescricaoProduto.ForeColor = Color.Black;
            this.Controls.Add(lblDescricaoProduto);

            tbDescricaoProduto = new TextBox();
            tbDescricaoProduto.Location = new Point(10, 60);
            tbDescricaoProduto.Size = new Size(200, 20);
            tbDescricaoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbDescricaoProduto.ForeColor = Color.Black;
            this.Controls.Add(tbDescricaoProduto);

            lblProdutoId = new Label();
            lblProdutoId.Text = "Id:";
            lblProdutoId.Location = new Point(10, 80);
            lblProdutoId.Size = new Size(200, 20);
            lblProdutoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblProdutoId.ForeColor = Color.Black;
            this.Controls.Add(lblProdutoId);

            cbProdutoId = new ComboBox();
            cbProdutoId.Location = new Point(10, 100);
            cbProdutoId.Size = new Size(100, 20);
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

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new Point(10, 130);
            btnSalvar.Size = new Size(100, 20);
            btnSalvar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Click += (sender, e) => {
                SalvarDescricaoProduto();
                LimpaTela();
            };
            this.Controls.Add(btnSalvar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(120, 130);
            btnCancelar.Size = new Size(100, 20);
            btnCancelar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Click += (sender, e) => {
                LimpaTela();
            };
            this.Controls.Add(btnCancelar);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(230, 130);
            btnSair.Size = new Size(100, 20);
            btnSair.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Click += (sender, e) => {
                this.Close();
            };
            this.Controls.Add(btnSair);

            this.Text = "Editar Descrição do Produto";
            this.Size = new Size(350, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void SalvarDescricaoProduto()
        {
            ModelProduto.Produto produto = new ModelProduto.Produto();
            produto.Descricao = tbDescricaoProduto.Text;
            produto.Id = Convert.ToInt32(cbProdutoId.Text);

            ControllerProduto.Produto.AlteraDescricaoProduto(produto.Id, produto.Descricao);

            MessageBox.Show("Descrição do produto editada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void LimpaTela()
        {
            tbDescricaoProduto.Text = "";
            cbProdutoId.Text = "";
        }

        public EditaDescricaoProduto()
        {
            IniciaFormulario();
        }
    }

    public class EditaPrecoProduto : Form
    {
        Label lblTitulo;
        Label lblPrecoProduto;
        TextBox tbPrecoProduto;
        Label lblProdutoId;
        ComboBox cbProdutoId;
        Button btnSalvar;
        Button btnCancelar;
        Button btnSair;

        public void IniciaFormulario()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Editar Preço do Produto";
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Size = new Size(400, 20);
            lblTitulo.Font = new Font("TrebuchetMS", 12, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            this.Controls.Add(lblTitulo);

            lblPrecoProduto = new Label();
            lblPrecoProduto.Text = "Preço:";
            lblPrecoProduto.Location = new Point(10, 40);
            lblPrecoProduto.Size = new Size(200, 20);
            lblPrecoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblPrecoProduto.ForeColor = Color.Black;
            this.Controls.Add(lblPrecoProduto);

            tbPrecoProduto = new TextBox();
            tbPrecoProduto.Location = new Point(10, 60);
            tbPrecoProduto.Size = new Size(200, 20);
            tbPrecoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbPrecoProduto.ForeColor = Color.Black;
            this.Controls.Add(tbPrecoProduto);

            lblProdutoId = new Label();
            lblProdutoId.Text = "Id:";
            lblProdutoId.Location = new Point(10, 80);
            lblProdutoId.Size = new Size(200, 20);
            lblProdutoId.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblProdutoId.ForeColor = Color.Black;
            this.Controls.Add(lblProdutoId);

            cbProdutoId = new ComboBox();
            cbProdutoId.Location = new Point(10, 100);
            cbProdutoId.Size = new Size(100, 20);
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

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new Point(10, 130);
            btnSalvar.Size = new Size(100, 20);
            btnSalvar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Click += (sender, e) => {
                SalvarPrecoProduto();
                LimpaTela();
            };
            this.Controls.Add(btnSalvar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(120, 130);
            btnCancelar.Size = new Size(100, 20);
            btnCancelar.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Click += (sender, e) => {
                LimpaTela();
            };
            this.Controls.Add(btnCancelar);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(230, 130);
            btnSair.Size = new Size(100, 20);
            btnSair.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Click += (sender, e) => this.Close();
            this.Controls.Add(btnSair);

            this.Text = "Editar Preço do Produto";
            this.Size = new Size(350, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void SalvarPrecoProduto()
        {
            ModelProduto.Produto produto = new ModelProduto.Produto();
            produto.Preco = Convert.ToDecimal(tbPrecoProduto.Text);
            produto.Id = Convert.ToInt32(cbProdutoId.Text);

            ControllerProduto.Produto.AlteraPrecoProduto(produto.Id, produto.Preco);

            MessageBox.Show("Preço do produto editado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimpaTela()
        {
            tbPrecoProduto.Text = "";
            cbProdutoId.Text = "";
        }

        public EditaPrecoProduto()
        {
            IniciaFormulario();
        }
    }
}
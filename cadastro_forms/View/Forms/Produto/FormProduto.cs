/* Módulo Formulário para cadastrar produtos
 * Descrição : Classe responsável pela criação do formulário de cadastro de produtos
 * Autor : Jussan Igor da Silva
 * Data : 19/04/2023
 * Versão : 1.4
 */

namespace cadastro_forms.View.Forms.Produto
{
    public class FormProduto : Form
    {
        Label lblTituloProduto;

        Label lblTxtNomeProduto;

        Label lblTxtDescricaoProduto;
        Label lblTxtPrecoProduto;
        TextBox tbNomeProduto;
        TextBox tbDescricaoProduto;
        TextBox tbPrecoProduto;
        Button btnSalvarProduto;
        Button btnCancelarProduto;        

        public void IniciaFormulario(){
            lblTituloProduto = new Label();
            lblTituloProduto.Text = "Cadastro de Produto";
            lblTituloProduto.Location = new Point(10, 10);
            lblTituloProduto.Size = new Size(200, 20);
            lblTituloProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTituloProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTituloProduto);

            lblTxtNomeProduto = new Label();
            lblTxtNomeProduto.Text = "Nome:";
            lblTxtNomeProduto.Location = new Point(10, 40);
            lblTxtNomeProduto.Size = new Size(200, 20);
            lblTxtNomeProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtNomeProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtNomeProduto);

            tbNomeProduto = new TextBox();
            tbNomeProduto.Location = new Point(10, 60);
            tbNomeProduto.Size = new Size(200, 20);
            tbNomeProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbNomeProduto.ForeColor = Color.Black;
            this.Controls.Add(tbNomeProduto);

            lblTxtDescricaoProduto = new Label();
            lblTxtDescricaoProduto.Text = "Descrição:";
            lblTxtDescricaoProduto.Location = new Point(10, 90);
            lblTxtDescricaoProduto.Size = new Size(200, 20);
            lblTxtDescricaoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtDescricaoProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtDescricaoProduto);

            tbDescricaoProduto = new TextBox();
            tbDescricaoProduto.Location = new Point(10, 110);
            tbDescricaoProduto.Size = new Size(200, 20);
            tbDescricaoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbDescricaoProduto.ForeColor = Color.Black;
            this.Controls.Add(tbDescricaoProduto);

            lblTxtPrecoProduto = new Label();
            lblTxtPrecoProduto.Text = "Preço:";
            lblTxtPrecoProduto.Location = new Point(10, 140);
            lblTxtPrecoProduto.Size = new Size(200, 20);
            lblTxtPrecoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            lblTxtPrecoProduto.ForeColor = Color.Black;
            this.Controls.Add(lblTxtPrecoProduto);

            tbPrecoProduto = new TextBox();
            tbPrecoProduto.Location = new Point(10, 160);
            tbPrecoProduto.Size = new Size(200, 20);
            tbPrecoProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            tbPrecoProduto.ForeColor = Color.Black;
            this.Controls.Add(tbPrecoProduto);

            btnSalvarProduto = new Button();
            btnSalvarProduto.Text = "Salvar";
            btnSalvarProduto.Location = new Point(10, 240);
            btnSalvarProduto.Size = new Size(90, 25);
            btnSalvarProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSalvarProduto.ForeColor = Color.Black;
            btnSalvarProduto.Click += (sender, e) => {
                SalvarProduto();
                LimpaTela();
            };
            this.Controls.Add(btnSalvarProduto);


            btnCancelarProduto = new Button();
            btnCancelarProduto.Text = "Cancelar";
            btnCancelarProduto.Location = new Point(120, 240);
            btnCancelarProduto.Size = new Size(90, 25);
            btnCancelarProduto.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnCancelarProduto.ForeColor = Color.Black;
            btnCancelarProduto.Click += (sender, e) => this.Close();
            this.Controls.Add(btnCancelarProduto);

            this.Text = "Cadastro de Produto";
            this.Size = new Size(300, 320);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
       } 

        public FormProduto(){
            IniciaFormulario();
        }

        public void SalvarProduto(){
            // Lita de strings para guardar os erros
            List<string> erros = new List<string>();



            // Validação do nome
            if (String.IsNullOrEmpty(tbNomeProduto.Text)){
                erros.Add("O nome do produto é obrigatório");
            }

            if (String.IsNullOrEmpty(tbDescricaoProduto.Text)){
                erros.Add("A descrição do produto é obrigatória");
            }

            if (String.IsNullOrEmpty(tbPrecoProduto.Text)){
                erros.Add("O preço do produto deve ser maior que zero e não pode ser vazia");
            }

            if(erros.Count() == 0){
                Console.WriteLine("Sem erros");

                ModelProduto.Produto produto = new ModelProduto.Produto();
                produto.Nome = tbNomeProduto.Text;
                produto.Descricao = tbDescricaoProduto.Text;
                try{
                    produto.Preco = Convert.ToDecimal(tbPrecoProduto.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao converter os valores: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ControllerProduto.Produto.CadastraProduto(produto.Nome, produto.Descricao, produto.Preco.ToString());

                MessageBox.Show("Produto cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpaTela();

            }
            else
            {
                Console.WriteLine("erros:");
                string mensagem = "";
                foreach(string erro in erros){
                    mensagem += erro + "\n";
                    Console.WriteLine(erro);
                }
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LimpaTela()
        {
            tbDescricaoProduto.Text ="";
            tbNomeProduto.Text = "";
            tbPrecoProduto.Text = "";
        }
    }
}
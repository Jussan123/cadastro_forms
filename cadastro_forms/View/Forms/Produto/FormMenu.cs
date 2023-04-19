using ControllerProduto;
using ModelProduto;

namespace cadastro_forms.View.Forms.Produto
{
    public class FormMenu : Form
    {
        Label lblTituloMenu;
        Label lblTxtMenu;
        Button btnMenuProduto;
        Button btnMenuSair;
        
        public void IniciaFormulario(){
            lblTituloMenu = new Label();
            lblTituloMenu.Text = "Menu";
            lblTituloMenu.Location = new Point(145, 10);
            lblTituloMenu.Size = new Size(60, 20);
            lblTituloMenu.Font = new Font("TrebuchetMS", 14, FontStyle.Bold);
            lblTituloMenu.ForeColor = Color.Black;
            this.Controls.Add(lblTituloMenu);
            
            btnMenuProduto = new Button();
            btnMenuProduto.Text = "Ver Produtos";
            btnMenuProduto.Location = new Point(50, 100);
            btnMenuProduto.Size = new Size(120, 25);
            btnMenuProduto.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnMenuProduto.ForeColor = Color.Black;
            btnMenuProduto.Click += (sender, e) => {
                AbrirForm( new FormListaProdutos());
            };
            this.Controls.Add(btnMenuProduto);

            btnMenuSair = new Button();
            btnMenuSair.Text = "Sair";
            btnMenuSair.Location = new Point(180, 100);
            btnMenuSair.Size = new Size(120, 25);
            btnMenuSair.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnMenuSair.ForeColor = Color.Black;
            btnMenuSair.Click += (sender, e) => {
                this.Close();
            };
            this.Controls.Add(btnMenuSair);

            this.Text = "Menu de Produtos";
            this.Size = new Size(350, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
       } 


        public FormMenu()
        {
            IniciaFormulario();
        }

        public void AbrirForm(Form form){
            form.ShowDialog();
        }
    }
}

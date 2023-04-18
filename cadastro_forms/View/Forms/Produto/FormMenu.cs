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
            lblTituloMenu.Location = new Point(10, 10);
            lblTituloMenu.Size = new Size(200, 20);
            lblTituloMenu.Font = new Font("TrebuchetMS", 14, FontStyle.Bold);
            lblTituloMenu.ForeColor = Color.Black;
            this.Controls.Add(lblTituloMenu);
            
            btnMenuProduto = new Button();
            btnMenuProduto.Text = "Produtos";
            btnMenuProduto.Location = new Point(10, 240);
            btnMenuProduto.Size = new Size(90, 25);
            btnMenuProduto.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnMenuProduto.ForeColor = Color.Black;
            btnMenuProduto.Click += (sender, e) => {
                new FormListaProdutos();
            };
            this.Controls.Add(btnMenuProduto);

            btnMenuSair = new Button();
            btnMenuSair.Text = "Sair";
            btnMenuSair.Location = new Point(120, 240);
            btnMenuSair.Size = new Size(90, 25);
            btnMenuSair.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnMenuSair.ForeColor = Color.Black;
            btnMenuSair.Click += (sender, e) => {
                this.Close();
            };
            this.Controls.Add(btnMenuSair);

            this.Text = "Menu de Produtos";
            this.Size = new Size(300, 320);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
       } 


        public FormMenu()
        {
            IniciaFormulario();
        }
    }
}

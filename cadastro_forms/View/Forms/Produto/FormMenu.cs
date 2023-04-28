/* Módulo Formulario Menu
* Módulo que representa o formulario de menu
* Autor: Jussan Igor da Silva
* Data: 19/04/2023
* Versão: 1.2
*/
namespace cadastro_forms.View.Forms.Produto
{
    public class FormMenu : Form
    {
        Label lblTituloMenu;
        Label lblTxtMenu;
        Button btnMenuProduto;
        Button btnMenuAlmoxarifado;
        Button btnSaldo;
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
            btnMenuProduto.Location = new Point(40, 40);
            btnMenuProduto.Size = new Size(130, 25);
            btnMenuProduto.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnMenuProduto.ForeColor = Color.Black;
            btnMenuProduto.Click += (sender, e) => {
                AbrirForm( new FormListaProdutos());
            };
            this.Controls.Add(btnMenuProduto);

            btnMenuSair = new Button();
            btnMenuSair.Text = "Sair";
            btnMenuSair.Location = new Point(175, 40);
            btnMenuSair.Size = new Size(130, 25);
            btnMenuSair.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnMenuSair.ForeColor = Color.Black;
            btnMenuSair.Click += (sender, e) => {
                this.Close();
            };
            this.Controls.Add(btnMenuSair);

            btnMenuAlmoxarifado = new Button();
            btnMenuAlmoxarifado.Text = "Ver Almoxarifado";
            btnMenuAlmoxarifado.Location = new Point(40, 80);
            btnMenuAlmoxarifado.Size = new Size(130, 25);
            btnMenuAlmoxarifado.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnMenuAlmoxarifado.ForeColor = Color.Black;
            btnMenuAlmoxarifado.Click += (sender, e) => {
                AbrirForm( new FormListaAlmoxarifado());
            };
            this.Controls.Add(btnMenuAlmoxarifado);

            btnSaldo = new Button();
            btnSaldo.Text = "Ver Saldo";
            btnSaldo.Location = new Point(175, 80);
            btnSaldo.Size = new Size(130, 25);
            btnSaldo.Font = new Font("TrebuchetMS", 10, FontStyle.Bold);
            btnSaldo.ForeColor = Color.Black;
            btnSaldo.Click += (sender, e) => {
                AbrirForm( new FormListaSaldo());
            };
            this.Controls.Add(btnSaldo);

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

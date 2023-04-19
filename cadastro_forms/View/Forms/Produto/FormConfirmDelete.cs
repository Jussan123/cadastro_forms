using ControllerProduto;
using ModelProduto;

namespace cadastro_forms.View.Forms.Produto
{
    public class FormConfirmDelete : Form
    { 
        Button btnSim;
        Button btnNao;

        public void IniciaFormularioDelete(int Id){
            btnSim = new Button();
            btnSim.Text = "Sim";
            btnSim.Location = new Point(10, 10);
            btnSim.Size = new Size(100, 20);
            btnSim.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnSim.ForeColor = Color.Blue;
            btnSim.Click += (sender, e) => {
                ControllerProduto.Produto controllerProduto = new ControllerProduto.Produto();
                ControllerProduto.Produto.ExcluiProduto(Id);
                this.Close();
            };
            this.Controls.Add(btnSim);

            btnNao = new Button();
            btnNao.Text = "Não";
            btnNao.Location = new Point(10, 40);
            btnNao.Size = new Size(100, 20);
            btnNao.Font = new Font("TrebuchetMS", 8, FontStyle.Bold);
            btnNao.ForeColor = Color.Red;
            btnNao.Click += (sender, e) => {
                this.Close();
            };
            this.Controls.Add(btnNao);

            this.Text = "Confirma Delete";
            this.Size = new Size(300, 320);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public FormConfirmDelete(int Id)
        {
            IniciaFormularioDelete(Id);
        }
    }
}
/* Módulo Controller
 * Classe Produto
 * Descrição: Classe que representa a entidade Produto
 * Autor: Jussan Igor da Silva
 * Data: 15/04/2023
 * Versão: 1.0
*/



namespace ControllerProduto
{
    public class Produto
    {
        public static ModelProduto.Produto CadastraProduto(
            string Nome,
            string Descricao,
            string Preco)
        {
            Decimal precoConvert = 0;
            try 
            {
                precoConvert = Decimal.Parse(Preco);
            } catch (Exception) {
                throw new Exception("Preço ou quantidade inválidos");
            }
            ModelProduto.Produto produto = new ModelProduto.Produto(Nome, Descricao, precoConvert);
            return produto;
        }
        
        public static ModelProduto.Produto AlteraProduto(
            int Id,
            string Nome,
            string Descricao,
            Decimal Preco)
        {
            try 
            {
                return ModelProduto.Produto.UpdateProduto(Id, Nome, Descricao, Preco);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Produto AlteraNomeProduto(int Id, string Nome)
        {
            try 
            {
                return ModelProduto.Produto.UpdateProdutoNome(Id, Nome);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Produto AlteraDescricaoProduto(int Id, string Descricao)
        {
            try 
            {
                return ModelProduto.Produto.UpdateProdutoDescricao(Id, Descricao);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Produto AlteraPrecoProduto(int Id, decimal Preco)
        {
            try 
            {
                return ModelProduto.Produto.UpdateProdutoPreco(Id, Preco);
            } catch (Exception) {
                throw new Exception("Id ou preço inválido");
            }
        }
        public static void ExcluiProduto(int Id)
        {
            try
            {
                ModelProduto.Produto.DeleteProduto(Id);
            } catch (Exception)
            {
                throw new Exception("Id inválido");
            }
        }

        public static List<ModelProduto.Produto> ListaProdutos()
        {
            return ModelProduto.Produto.ReadProdutos();
        }

        public static ModelProduto.Produto BuscaProduto(int Id)
        {
            try
            {
                return ModelProduto.Produto.ReadProduto(Id);
            } catch (Exception)
            {
                throw new Exception("Id inválido");
            }
        }
        
    }
}
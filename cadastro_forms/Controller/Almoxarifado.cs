/* Módulo Controller Almoxarifado
 * Classe Almoxarifado
 * Descrição: Classe que representa a entidade Almoxarifado
 * Autor: Jussan Igor da Silva
 * Data: 20/04/2023
 * Versão: 1.0
 */

 namespace ControllerProduto
 {
    public class Almoxarifado
    {
        public static ModelProduto.Almoxarifado CadastraAlmoxarifado(
            string Nome,
            string Localizacao)
        {
            ModelProduto.Almoxarifado almoxarifado = new ModelProduto.Almoxarifado(Nome, Localizacao);
            return almoxarifado;
        }

        public static ModelProduto.Almoxarifado AlteraAlmoxarifado(
            int Id,
            string Nome,
            string Localizacao)
        {
            try 
            {
                ModelProduto.Almoxarifado.ReadAlmoxarifado(Id);
                return ModelProduto.Almoxarifado.AtualizaAlmoxarifado(Id, Nome, Localizacao);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Almoxarifado AlteraNomeAlmoxarifado(int Id, string Nome)
        {
            try 
            {
                ModelProduto.Almoxarifado.ReadAlmoxarifado(Id);
                return ModelProduto.Almoxarifado.AtualizaNomeAlmoxarifado(Id, Nome);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Almoxarifado AlteraLocalizacaoAlmoxarifado(int Id, string Localizacao)
        {
            try 
            {
                ModelProduto.Almoxarifado.ReadAlmoxarifado(Id);
                return ModelProduto.Almoxarifado.AtualizaLocalizacaoAlmoxarifado(Id, Localizacao);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static void ExcluiAlmoxarifado(int Id)
        {
            try 
            {
                ModelProduto.Almoxarifado.DeleteAlmoxarifado(Id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static List<ModelProduto.Almoxarifado> ListaAlmoxarifado()
        {
            return ModelProduto.Almoxarifado.Read();
        }

        public static ModelProduto.Almoxarifado BuscaAlmoxarifado(int Id)
        {
            try 
            {
                return ModelProduto.Almoxarifado.ReadAlmoxarifado(Id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }
    }
 }
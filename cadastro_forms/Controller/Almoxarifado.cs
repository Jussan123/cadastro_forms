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
            ModelProduto.Almoxarifado Almoxarifado = new ModelProduto.Almoxarifado(Nome, Localizacao);
            return Almoxarifado;
        }

        public static ModelProduto.Almoxarifado AlteraAlmoxarifado(
            int Id,
            string Nome,
            string Localizacao)
        {
            try 
            {
                return ModelProduto.Almoxarifado.UpdateAlmoxarifado(Id, Nome, Localizacao);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Almoxarifado AlteraNomeAlmoxarifado(int Id, string Nome)
        {
            try 
            {
                return ModelProduto.Almoxarifado.UpdateAlmoxarifadoNome(Id, Nome);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Almoxarifado AlteraLocalizacaoAlmoxarifado(int Id, string Localizacao)
        {
            try 
            {
                return ModelProduto.Almoxarifado.UpdateAlmoxarifadoLocalizacao(Id, Localizacao);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Almoxarifado ExcluiAlmoxarifado(int Id)
        {
            try 
            {
                return ModelProduto.Almoxarifado.DeleteAlmoxarifado(Id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static List<ModelProduto.Almoxarifado> ListaAlmoxarifado()
        {
            return ModelProduto.Almoxarifado.ListaAlmoxarifado();
        }

        public static ModelProduto.Almoxarifado BuscaAlmoxarifado(int Id)
        {
            try 
            {
                return ModelProduto.Almoxarifado.BuscaAlmoxarifado(Id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }
    }
 }
/* Módulo Controller Saldo
 * Classe Saldo
 * Descrição: Classe que representa a entidade Saldo
 * Autor: Jussan Igor da Silva
 * Data: 20/04/2023
 * Versão: 1.0
 */

using Conexao;

namespace ControllerProduto
{
    public class Saldo
    {
        public static ModelProduto.Saldo CadastraSaldo(
            int ProdutoId,
            ModelProduto.Produto Produto,
            int AlmoxarifadoId,
            ModelProduto.Almoxarifado Almoxarifado,
            int Quantidade)
        {
            ModelProduto.Saldo saldo = new ModelProduto.Saldo(ProdutoId, Produto, AlmoxarifadoId, Almoxarifado, Quantidade);
            return saldo;
        }

        public static ModelProduto.Saldo AlteraSaldo(
            int Id,
            int ProdutoId,
            int AlmoxarifadoId,
            int Quantidade)
        {
            try
            {
                return ModelProduto.Saldo.Atualizar(Id, ProdutoId, AlmoxarifadoId, Quantidade);
            }
            catch (Exception)
            {
                throw new Exception("Id inválido");
            }
        }

        public static void RemoveSaldo(int Id)
        {
            try
            {
                ModelProduto.Saldo.Deletar(Id);
            }
            catch (Exception)
            {
                throw new Exception("Id inválido");
            }
        }

        public static List<ModelProduto.Saldo.SaldoCompleto> ListarSaldo()
        {
            return ModelProduto.Saldo.Listar();
        }

        public static ModelProduto.Saldo BuscaSaldo(int Id)
        {
            try
            {
                DataBase db = new DataBase();
                return db.Saldos.Find(Id);
            }
            catch (Exception)
            {
                throw new Exception("Id inválido");
            }
        }
    }
}
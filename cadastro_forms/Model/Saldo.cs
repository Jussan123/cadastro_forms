/* Módulo Model Saldo
 * Classe Saldo
 * Descrição: Classe que representa a entidade Saldo
 * Autor: Jussan Igor da Silva
 * Data: 20/04/2023
 * Versão: 1.0
 */

using Conexao;

namespace ModelProduto
{
    public class Saldo
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public virtual ModelProduto.Produto Produto { get; set; }
        public int AlmoxarifadoId { get; set; }
        public virtual  ModelProduto.Almoxarifado Almoxarifado { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }


        public Saldo()
        {
        }

        public Saldo(int ProdutoId, ModelProduto.Produto Produto,int AlmoxarifadoId, ModelProduto.Almoxarifado Almoxarifado, int Quantidade)
        {
            this.ProdutoId = ProdutoId;
            //this.Produto = Produto;
            this.AlmoxarifadoId = AlmoxarifadoId;
            //this.Almoxarifado = Almoxarifado;
            this.Quantidade = Quantidade;
            this.DataUltimaAtualizacao = DateTime.UtcNow;

            DataBase db = new DataBase();
            db.Saldos.Add(this);
            db.SaveChanges();
        }

        public override bool Equals(object obj)
        {
            if (obj ==null)
            {
                return false;
            }
            if (obj == this)
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Saldo saldo = (Saldo)obj;
            return this.Id == saldo.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return $"Id: {this.Id}, ProdutoId: {this.ProdutoId}, NomeProduto: {this.Produto.Nome}, AlmoxarifadoId: {this.AlmoxarifadoId}, NomeAlmoxarifado: {this.Almoxarifado.Nome}, Quantidade: {this.Quantidade}, DataUltimaAtualizacao: {this.DataUltimaAtualizacao}";
        }

        //----------------- CRUD -----------------//

        public static List<Saldo> Listar()
        {
            DataBase db = new DataBase();
            return db.Saldos.ToList();
        }

        public static Saldo Buscar(int Id)
        {
            DataBase db = new DataBase();
            return db.Saldos.Find(Id);
        }

        public static Saldo Atualizar(int id, int produtoId, int almoxarifadoId, int quantidade)
        {
            DataBase db = new DataBase();
            Saldo saldo = db.Saldos.Find(id);
            saldo.ProdutoId = produtoId;
            saldo.Produto = ModelProduto.Produto.ReadProduto(produtoId);
            saldo.AlmoxarifadoId = almoxarifadoId;
            saldo.Almoxarifado = ModelProduto.Almoxarifado.ReadAlmoxarifado(almoxarifadoId);
            saldo.Quantidade = quantidade;
            saldo.DataUltimaAtualizacao = DateTime.UtcNow;
            db.SaveChanges();
            return saldo;
        }

        public static void Deletar(int Id)
        {
            DataBase db = new DataBase();
            db.Saldos.Remove(db.Saldos.Find(Id));
            db.SaveChanges();
        }
    }
}
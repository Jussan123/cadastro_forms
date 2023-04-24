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
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int IdAlmoxarifado { get; set; }
        public string NomeAlmoxarifado { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }


        public Saldo()
        {
        }

        public Saldo(int IdProduto, string NomeProduto, int IdAlmoxarifado, string NomeAlmoxarifado, int Quantidade)
        {
            this.IdProduto = IdProduto;
            this.NomeProduto = NomeProduto;
            this.IdAlmoxarifado = IdAlmoxarifado;
            this.NomeAlmoxarifado = NomeAlmoxarifado;
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
            return $"Id: {this.Id}, IdProduto: {this.IdProduto}, NomeProduto: {this.NomeProduto}, IdAlmoxarifado: {this.IdAlmoxarifado}, NomeAlmoxarifado: {this.NomeAlmoxarifado}, Quantidade: {this.Quantidade}, DataUltimaAtualizacao: {this.DataUltimaAtualizacao}";
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

        public static Saldo Atualizar(int Id, int IdProduto, string NomeProduto, int IdAlmoxarifado, string NomeAlmoxarifado, int Quantidade)
        {
            DataBase db = new DataBase();
            Saldo saldo = db.Saldos.Find(Id);
            saldo.IdProduto = IdProduto;
            saldo.NomeProduto = NomeProduto;
            saldo.IdAlmoxarifado = IdAlmoxarifado;
            saldo.NomeAlmoxarifado = NomeAlmoxarifado;
            saldo.Quantidade = Quantidade;
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
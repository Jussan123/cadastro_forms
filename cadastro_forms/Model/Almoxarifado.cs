/* Módulo Model Almoxarifado
 * Classe Almoxarifado
 * Descrição: Classe que representa a entidade Almoxarifado
 * Autor: Jussan Igor da Silva
 * Data: 20/04/2023
 * Versão: 1.0
 */


using Conexao;

namespace ModelProduto
{
    public class Almoxarifado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataCadastro { get; set; }

        public Almoxarifado()
        {
        }

        public Almoxarifado(string Nome, string Localizacao)
        {
            this.Nome = Nome;
            this.Localizacao = Localizacao;
            this.DataCadastro = DateTime.UtcNow;

            DataBase db = new DataBase();
            db.Almoxarifados.Add(this);
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
            Almoxarifado Almoxarifado = (Almoxarifado)obj;
            return this.Id == Almoxarifado.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return "Almoxarifado: Id: " + this.Id + " - Nome: " + this.Nome + " - Localização: " + this.Localizacao + " - Data Criação" + this.DataCadastro;
        }

        // ----------- CRUD -----------

        public static void Create(Almoxarifado Almoxarifado)
        {
            DataBase db = new DataBase();
            db.Almoxarifados.Add(Almoxarifado);
            db.SaveChanges();
        }

        public static List<Almoxarifado> Read()
        {
            DataBase db = new DataBase();
            List<Almoxarifado> almoxarifados = (from u in db.Almoxarifados 
                                                select u).ToList();
            return db.Almoxarifados.ToList();
        }

        public static Almoxarifado ReadAlmoxarifado(int id)
        {
            DataBase db = new DataBase();
            return db.Almoxarifados.Find(id);
        }

        public static Almoxarifado AtualizaAlmoxarifado(Almoxarifado Almoxarifado)
        {
            DataBase db = new DataBase();
            Almoxarifado Almoxarifado = db.Almoxarifados.Find(Id);
            Almoxarifado.Nome = Nome;
            Almoxarifado.Localizacao = Localizacao;
            db.SaveChanges();
            return Almoxarifado;
        }

        public static Almoxarifado AtualizaNomeAlmoxarifado(int Id, string Nome)
        {
            DataBase db = new DataBase();
            Almoxarifado Almoxarifado = db.Almoxarifados.Find(Id);
            Almoxarifado.Nome = Nome;
            db.SaveChanges();
            return Almoxarifado;
        }

        public static Almoxarifado AtualizaLocalizacaoAlmoxarifado(int Id, string Localizacao)
        {
            DataBase db = new DataBase();
            Almoxarifado Almoxarifado = db.Almoxarifados.Find(Id);
            Almoxarifado.Localizacao = Localizacao;
            db.SaveChanges();
            return Almoxarifado;
        }

        public static void DeleteAlmoxarifado(int Id)
        {
            DataBase db = new DataBase();
            Almoxarifado Almoxarifado = db.Almoxarifados.Find(Id);
            db.Almoxarifados.Remove(Almoxarifado);
            db.SaveChanges();
        }
    }
}
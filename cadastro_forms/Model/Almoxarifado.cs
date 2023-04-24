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
            Almoxarifado almoxarifado = (Almoxarifado)obj;
            return this.Id == almoxarifado.Id;
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

        public static List<Almoxarifado> Read()
        {
            DataBase db = new DataBase();
            List<Almoxarifado> almoxarifados = (from u in db.Almoxarifados 
                                                select u).ToList();
            return almoxarifados;
        }

        public static Almoxarifado ReadAlmoxarifado(int id)
        {
            DataBase db = new DataBase();
            return db.Almoxarifados.Find(id);
        }

        public static Almoxarifado AtualizaAlmoxarifado(int Id, string Nome, string Localizacao)
        {
            DataBase db = new DataBase();
            Almoxarifado almoxarifado = db.Almoxarifados.Find(Id);
            almoxarifado.Nome = Nome;
            almoxarifado.Localizacao = Localizacao;
            db.SaveChanges();
            return almoxarifado;
        }

        public static Almoxarifado AtualizaNomeAlmoxarifado(int Id, string Nome)
        {
            DataBase db = new DataBase();
            Almoxarifado almoxarifado = db.Almoxarifados.Find(Id);
            almoxarifado.Nome = Nome;
            db.SaveChanges();
            return almoxarifado;
        }

        public static Almoxarifado AtualizaLocalizacaoAlmoxarifado(int Id, string Localizacao)
        {
            DataBase db = new DataBase();
            Almoxarifado almoxarifado = db.Almoxarifados.Find(Id);
            almoxarifado.Localizacao = Localizacao;
            db.SaveChanges();
            return almoxarifado;
        }

        public static void DeleteAlmoxarifado(int Id)
        {
            DataBase db = new DataBase();
            Almoxarifado almoxarifado = db.Almoxarifados.Find(Id);
            db.Almoxarifados.Remove(almoxarifado);
            db.SaveChanges();
        }
    }
}
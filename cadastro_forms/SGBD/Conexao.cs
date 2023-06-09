/* Módulo SGBD(Sistema de Gerenciamento de Banco de Dados) Conexao
* Descrição : Classe responsável pela conexão com o banco de dados
* Autor : Jussan Igor da Silva
* Data : 15/04/2023
* Versão : 1.0
*/


using Microsoft.EntityFrameworkCore;
using ModelProduto;
 
namespace Conexao
{
    public class DataBase : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Almoxarifado> Almoxarifados { get; set; }
        public DbSet<Saldo> Saldos { get; set;}
  
          protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Almoxarifado>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Saldo>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {   
                try
                {
                    string connectionAWS = GetConnectionStringAWS();
                    optionsBuilder.UseMySql(connectionAWS, ServerVersion.AutoDetect(connectionAWS));
                } catch
                {
                    Console.WriteLine("Não foi possível conectar a AWS");
                    try 
                    {
                        string connectionLocal = GetConnectionStringLocal();
                        optionsBuilder.UseMySql(connectionLocal, ServerVersion.AutoDetect(connectionLocal));
                    } catch{
                        Console.WriteLine("Não foi possível conectar ao banco de dados local");
                    }
                }

            }
        }

        public static string GetConnectionStringAWS()
        {
            string serverName = "awsjussan.cbrcalzcoxol.us-east-1.rds.amazonaws.com";
            //string serverName = "RDS MySQL";
            string databaseName = "teste";
            string username = "admin";
            string password = "jussan123";

            string connectionString = $"Server={serverName};Database={databaseName};User ID={username};Password={password};";

            return connectionString;
        }


        private static string GetConnectionStringLocal()
        {
            return "Server=localhost;User ID=root;Database=teste;";
        }
    }
}
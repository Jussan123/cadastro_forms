/* Módulo Model Produto
* Descrição : Classe responsável pelas operações de CRUD da tabela Produto
* Autor : Jussan Igor da Silva
* Data : 15/04/2023
* Versão : 1.0
*/

using System;
using Conexao;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ModelProduto
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }
    
        public Produto()
        {
        }

        public Produto(string Nome, string Descricao, int Quantidade, decimal Preco)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.Quantidade = Quantidade;
            this.Preco = Preco;
            this.DataCadastro = DateTime.UtcNow;

            DataBase db = new DataBase();
            db.Produtos.Add(this);
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
            Produto produto = (Produto)obj;
            return this.Id == produto.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return "Produto: Id: " + this.Id + " - Nome: " + this.Nome + " - Descrição: " + this.Descricao + " - Quantidade: " + this.Quantidade + " - Preço: " + this.Preco + " - Data Criação" + this.DataCadastro;
        }

        // ----------- CRUD -------------

        public static List<Produto> ReadProdutos()
        {
            DataBase db = new DataBase();
            List<Produto> produtos = (from u in db.Produtos
                                            select u).ToList();
            return produtos;
        }

        public static Produto ReadProduto(int Id)
        {
            DataBase db = new DataBase();
            return db.Produtos.Find(Id);
        }

        public static Produto UpdateProduto(int Id, string Nome, string Descricao, int Quantidade, decimal Preco)
        {
            DataBase db = new DataBase();
            Produto produto = db.Produtos.Find(Id);
            produto.Nome = Nome;
            produto.Descricao = Descricao;
            produto.Quantidade = Quantidade;
            produto.Preco = Preco;
            db.SaveChanges();
            return produto;
        }
        public static Produto UpdateProdutoNome(int Id, string Nome)
        {
            DataBase db = new DataBase();
            Produto produto = db.Produtos.Find(Id);
            produto.Nome = Nome;
            db.SaveChanges();
            return produto;
        }

        public static Produto UpdateProdutoDescricao(int Id, string Descricao)
        {
            DataBase db = new DataBase();
            Produto produto = db.Produtos.Find(Id);
            produto.Descricao = Descricao;
            db.SaveChanges();
            return produto;
        }

        public static Produto UpdateProdutoQuantidade(int Id, int Quantidade)
        {
            DataBase db = new DataBase();
            Produto produto = db.Produtos.Find(Id);
            produto.Quantidade = Quantidade;
            db.SaveChanges();
            return produto;
        }

        public static Produto UpdateProdutoPreco(int Id, decimal Preco)
        {
            DataBase db = new DataBase();
            Produto produto = db.Produtos.Find(Id);
            produto.Preco = Preco;
            db.SaveChanges();
            return produto;
        }

        public static void DeleteProduto(int Id)
        {
            DataBase db = new DataBase();
            Produto produto = db.Produtos.Find(Id);
            db.Produtos.Remove(produto);
            db.SaveChanges();
        }


    }
}
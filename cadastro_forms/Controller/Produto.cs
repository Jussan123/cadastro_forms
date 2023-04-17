/* Módulo Controller
 * Classe Produto
 * Descrição: Classe que representa a entidade Produto
 * Autor: Jussan Igor da Silva
 * Data: 15/04/2023
 * Versão: 1.0
*/

using System;
using Conexao;
using ModelProduto;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ControllerProduto
{
    public class Produto
    {
        public static ModelProduto.Produto CadastraProduto(
            string Nome,
            string Descricao,
            string Preco,
            string Quantidade)
        {
            int precoConvert = 0;
            int quantidadeConvert = 0;
            try 
            {
                precoConvert = int.Parse(Preco);
                quantidadeConvert = int.Parse(Quantidade);
            } catch (Exception) {
                throw new Exception("Preço ou quantidade inválidos");
            }
            ModelProduto.Produto produto = new ModelProduto.Produto(Nome, Descricao, precoConvert, quantidadeConvert);
            return produto;
        }
        
        public static ModelProduto.Produto AlteraProduto(
            string Id,
            string Nome,
            string Descricao,
            string preco,
            string Quantidade)
        {
            int idConvert = 0;
            int precoConvert = 0;
            int quantidadeConvert = 0;
            try 
            {
                idConvert = int.Parse(Id);
                precoConvert = int.Parse(preco);
                quantidadeConvert = int.Parse(Quantidade);
                return ModelProduto.Produto.UpdateProduto(idConvert, Nome, Descricao, precoConvert, quantidadeConvert);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Produto AlteraNomeProduto(string Id, string Nome)
        {
            int idConvert = 0;
            try 
            {
                idConvert = int.Parse(Id);
                return ModelProduto.Produto.UpdateProdutoNome(idConvert, Nome);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Produto AlteraDescricaoProduto(string Id, string Descricao)
        {
            int idConvert = 0;
            try 
            {
                idConvert = int.Parse(Id);
                return ModelProduto.Produto.UpdateProdutoDescricao(idConvert, Descricao);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }

        public static ModelProduto.Produto AlteraPrecoProduto(string Id, string Preco)
        {
            int idConvert = 0;
            int precoConvert = 0;
            try 
            {
                idConvert = int.Parse(Id);
                precoConvert = int.Parse(Preco);
                return ModelProduto.Produto.UpdateProdutoPreco(idConvert, precoConvert);
            } catch (Exception) {
                throw new Exception("Id ou preço inválido");
            }
        }

        public static ModelProduto.Produto AlteraQuantidadeProduto(string Id, string Quantidade)
        {
            int idConvert = 0;
            int quantidadeConvert = 0;
            try 
            {
                idConvert = int.Parse(Id);
                quantidadeConvert = int.Parse(Quantidade);
                return ModelProduto.Produto.UpdateProdutoQuantidade(idConvert, quantidadeConvert);
            } catch (Exception) {
                throw new Exception("Id ou quantidade inválido");
            }
        }

        public static void ExcluiProduto(string Id)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(Id);
                ModelProduto.Produto.DeleteProduto(idConvert);
            } catch (Exception)
            {
                throw new Exception("Id inválido");
            }
        }

        public static List<ModelProduto.Produto> ListaProdutos()
        {
            return ModelProduto.Produto.ReadProdutos();
        }

        public static ModelProduto.Produto BuscaProduto(string Id)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(Id);
                return ModelProduto.Produto.ReadProduto(idConvert);
            } catch (Exception)
            {
                throw new Exception("Id inválido");
            }
        }
        
    }
}
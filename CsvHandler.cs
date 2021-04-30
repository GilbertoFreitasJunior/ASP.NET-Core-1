using System;
using System.Collections.Generic;
using System.IO;

namespace AppExemplo
{
    public class CsvHandler
    {
        public void AddProduto(Produto produto)
        {
            using (var file = File.AppendText("Models/produtos.csv"))
            {
                file.WriteLine($"{produto.Id},{produto.Nome},{produto.Preco}");
            }
        }

        public List<Produto> ListarProdutos()
        {
            var Produtos = new List<Produto>();
            using (var fs = new FileStream("Models/produtos.csv", FileMode.Open))
            using (var sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                {
                    var novaLinha = sr.ReadLine();
                    if (novaLinha != "")
                    {
                        string[] linha = novaLinha.Split(',');

                        var id = Int32.Parse(linha[0]);
                        var nome = linha[1];
                        var preco = "";

                        if (linha.Length > 3 && !String.IsNullOrEmpty(linha[3]))
                        {
                            preco = linha[2] + "," + linha[3];
                        }else
                        {
                            preco = linha[2];
                        }

                        for (int i = 0; i < Produtos.Count; i++)
                        {
                            if (id == Produtos[i].Id)
                            {
                                id++;
                            }
                        }

                        var produto = new Produto() { Nome = nome, Id = id, Preco = preco };
                        Produtos.Add(produto);
                    }
                }
            }

            return Produtos;
        }
    }
}
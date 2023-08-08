using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex1.models
{
    public class Vendas
    {
        public Vendas(int id, string produto, decimal preco)
        {
            ID = id;
            Produto = produto;
            Preco = preco;
        }
        public int ID {get; set;}   
        public string Produto {get; set;}
        public decimal Preco {get; set;}
    }
}
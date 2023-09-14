using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    public class Produto
    {
        public int? Id { get; set; }
        public string? descricao { get; set; }
        public decimal? preco { get; set; }        
    }
}
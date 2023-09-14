using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Descrição é obrigatório !")]
        [Display(Name = "descrição")]
        public string descricao { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "O campo Valor é obrigatório !")]
        [DataType(DataType.Currency)]
        [Display(Name = "preço")]
        public decimal preco { get; set; }        
    }
}
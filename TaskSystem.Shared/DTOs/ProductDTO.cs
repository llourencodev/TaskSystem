using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Shared.Enumeradores;

namespace TaskSystem.Shared.DTOs
{
    public class ProductDTO
    {
        public int  Id { get; set; }

        public string? Name { get; set; }

        public string? Descricao { get; set; }

        public int Preco { get; set; }
        
    }
}

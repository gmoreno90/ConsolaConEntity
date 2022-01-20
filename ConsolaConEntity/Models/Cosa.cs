using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaConEntity.Models
{
    public class Cosa
    {
        [Key]
        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}

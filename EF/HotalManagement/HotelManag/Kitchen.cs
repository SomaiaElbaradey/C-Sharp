using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManag
{
    [Table("kitchen")]
    public class Kitchen
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string User_name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Pass_word { get; set; }
    }
}

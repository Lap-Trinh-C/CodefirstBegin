using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectModel
{
    [Table("Recipes")]
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        public String Title { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(300)]
        public String Content { get; set; }



        public int WriteId { get; set; }      
        public virtual Write Write { get; set; }
    }
}

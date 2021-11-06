using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectModel
{
    [Table("Writers")]
    public class Write
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar")]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}

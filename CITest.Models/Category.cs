namespace CITest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [Key]
        public int idCategory { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]        
        public string name { get; set; }

        [StringLength(100)]
        public string description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCBook.Models
{

    [Table("Book")]

    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        [Range(100, 10000)]
        public int PagesNumber { get; set; }

        [StringLength(50)]
        public string Publisher { get; set; }

        [RegularExpression(@"^ \ d {4} (\ - | \ / | \.) \ D {1,2} \ 1 \ d {1,2} $", ErrorMessage = "Ingrese un formato de fecha válido, Por ejemplo: 2017-06-16 ")]
        [StringLength(50)]
        public string PublicationDate { get; set; }

        [StringLength(50)]
        public string Content { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Compare("Price")]
        [DataType(DataType.Currency)]
        public decimal PriceConfirm { get; set; }
    }
}
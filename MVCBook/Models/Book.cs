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

        [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$", ErrorMessage = "Ingrese un formato de fecha válido, Por ejemplo: 2017-06-16 ")]
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
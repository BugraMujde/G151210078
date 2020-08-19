using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G151210078.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName="nvarchar(50)")]
        public string Name { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Category { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Brand { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Color { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Size { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; }

        [Column(TypeName = "nvarchar(400)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile Image { get; set; }
    }
}

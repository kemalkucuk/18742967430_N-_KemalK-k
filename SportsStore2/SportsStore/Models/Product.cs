using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models {

    public class Product {
        
        public long ProductID { get; set; }
       

        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Resim Linki Giriniz")]
        public string Image { get; set; }
        
    }
    
}

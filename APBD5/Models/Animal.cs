using System.ComponentModel.DataAnnotations;


namespace APBD5.Models;


    public class Animal
    {
        [Required(ErrorMessage = "idAnimal is required")]
        public int IdAnimlal { get; set; }
        
        [Required(ErrorMessage = "name is required")]
        [MaxLength(200, ErrorMessage = "max lenght is 200")]
        public string Name { get; set; }
        
        [MaxLength(200, ErrorMessage = "max lenght is 200")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "category is required")]
        [MaxLength(200, ErrorMessage = "max lenght is 200")]
        public string Category { get; set; }
       
        [Required(ErrorMessage = "area is required")]
        [MaxLength(200, ErrorMessage = "max lenght is 200")]
        public string Area { get; set; }
    }
    

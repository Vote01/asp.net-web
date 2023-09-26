using System.ComponentModel.DataAnnotations;

namespace laba1_1.Models
{
    public class Methods
    {
        [Key]
        public int Methods_ID { get; set; }
        [Display(Name = "Метод")]
        public string? Methods_Name { get; set; }
    }
}

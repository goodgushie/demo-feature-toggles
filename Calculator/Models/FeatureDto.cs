using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    public class FeatureDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "State")]
        public bool IsEnabled { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace WebCore.Models
{
    public class ProductAdd
    {
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string Name { get; set; }
    }
}
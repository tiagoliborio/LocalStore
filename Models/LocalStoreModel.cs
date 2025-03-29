using System.ComponentModel.DataAnnotations;

namespace LocalStore.Models
{
    public class Store
    {
        [Key]
        public int IdStore { get; set; }

        [StringLength(50)]
        public string? StoreName { get; set; }

        [StringLength(50)]
        public string? StoreDescription { get; set; }
    }
}

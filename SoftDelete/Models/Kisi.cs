using System.ComponentModel.DataAnnotations;

namespace SoftDelete.Models
{
    public class Kisi
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool SilindiMi { get; set; }
    }
}
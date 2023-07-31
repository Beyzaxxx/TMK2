using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.Model
{
    [Table("Kimlik")]
    public class Kimlik
    {
        [Key]
        public int KimlikId { get; set; }
        [DisplayName("Site Baslık")]
        [Required, StringLength(100,ErrorMessage ="100 Karakter Olmalıdır.")]
        public string Title { get; set; }
        [DisplayName("Anahtar Kelimelr")]
        [Required, StringLength(200, ErrorMessage = "200 Karakter Olmalıdır.")]
        public string Keywords { get; set; }
        [DisplayName("Site Acıklama")]
        [Required, StringLength(300, ErrorMessage = "300 Karakter Olmalıdır.")]
        public string Description{ get; set; }
        [DisplayName("Site Logo")]
        public string LogoURL { get; set; }
        [DisplayName("Site Ünvan")]
        public string Unvan{ get; set; }
    }
}
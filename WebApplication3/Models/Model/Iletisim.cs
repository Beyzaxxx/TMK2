﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.Model
{
    [Table("Iletisim") ]
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        [StringLength(250,ErrorMessage ="250 Karakter Olmalıdır.")]
        public string Adres { get; set; }
        [StringLength(250, ErrorMessage = "250 Karakter Olmalıdır.")]
        public string Telefon{ get; set; }
        public string Fax { get; set; }
        public string Whatsapp { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
}
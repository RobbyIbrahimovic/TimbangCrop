using System;
using System.Collections.Generic;
using System.Text;

namespace TimbangCrop.Models
{ public class LogPenimbangan 
    { 
        public string IdLog { get; set; } 
        public string IdTimbangan { get; set; } 
        public DateTime Timestamp { get; set; } 
        public string Status { get; set; } 
        public string PesanDetail { get; set; } 
    } 
}

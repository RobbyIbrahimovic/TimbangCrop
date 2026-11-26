using System;
using System.Collections.Generic;
using System.Text;

namespace TimbangCrop.Models
{
    public class PenerimaanBarang
    {
        public string IdPenerimaan { get; set; }
        public string NoSuratJalan { get; set; }
        public string IdKomoditas { get; set; }
        public string NamaDriver { get; set; }
        public string AsalLahan { get; set; }
        public double BeratSuratJalan { get; set; }
        public DateTime Tanggal { get; set; } = DateTime.Now;
    }
}

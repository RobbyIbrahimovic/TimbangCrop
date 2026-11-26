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

        // Data relasi untuk tampilan riwayat (diambil lewat JOIN di LogPenimbanganDAO)
        public string NoSuratJalan { get; set; } = "-";
        public string NamaKomoditas { get; set; } = "-";
        public double BeratNetto { get; set; }
        public double BeratSuratJalan { get; set; }

        // Deviasi tidak disimpan di DB, jadi dihitung ulang dengan rumus yang sama
        // seperti PercentageToleranceValidator
        public double PersentaseDeviasi =>
            BeratSuratJalan > 0
                ? Math.Round(Math.Abs(BeratNetto - BeratSuratJalan) / BeratSuratJalan * 100.0, 2)
                : 0;
    }
}

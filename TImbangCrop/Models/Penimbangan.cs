using System;
using System.Collections.Generic;
using System.Text;
using TimbangCrop.Controllers;

namespace TimbangCrop.Models
{
    public class Penimbangan
    {
        public string IdTimbangan { get; set; }
        public string IdPenerimaan { get; set; }

        private double _beratKotor;
        private double _beratTara;

        public double BeratKotor
        {
            get => _beratKotor;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Berat kotor tidak boleh bernilai negatif.");
                _beratKotor = value;
            }
        }

        public double BeratTara
        {
            get => _beratTara;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Berat tara tidak boleh bernilai negatif.");
                _beratTara = value;
            }
        }

        public double BeratNetto => Math.Max(0, _beratKotor - _beratTara);

        public VerificationResult EksekusiValidasi(IVerificationValidator validator, double beratSuratJalan, double toleransiPersen)
        {
            if (validator == null)
                throw new ArgumentNullException(nameof(validator));
            return validator.ValidateWeight(beratSuratJalan, this.BeratNetto, toleransiPersen);
        }
    }
}
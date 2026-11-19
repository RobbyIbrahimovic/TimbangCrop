using System;
using System.Collections.Generic;
using System.Text;
using TimbangCrop.Models;

namespace TimbangCrop.Controllers
{
    public class PercentageToleranceValidator : IVerificationValidator
    {
        public VerificationResult ValidateWeight(double beratSuratJalan, double beratNettoRiil, double batasToleransiPersen)
        {
            double selisih = Math.Abs(beratNettoRiil - beratSuratJalan);
            double persenSelisih = beratSuratJalan > 0 ? (selisih / beratSuratJalan) * 100.0 : 0;

            var result = new VerificationResult
            {
                DeviasiKg = Math.Round(selisih, 2),
                PersentaseDeviasi = Math.Round(persenSelisih, 2)
            };

            if (persenSelisih <= batasToleransiPersen)
            {
                result.IsValid = true;
                result.Pesan = "Penimbangan sesuai toleransi aman.";
            }
            else
            {
                result.IsValid = false;
                result.Pesan = $"ANOMALI: Selisih {result.PersentaseDeviasi}% melebihi batas {batasToleransiPersen}%.";
            }

            return result;
        }
    }
}
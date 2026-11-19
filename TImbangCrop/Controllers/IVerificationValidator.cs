using System;
using System.Collections.Generic;
using System.Text;
using TimbangCrop.Models;

namespace TimbangCrop.Controllers
{
    public interface IVerificationValidator
    {
        VerificationResult ValidateWeight(double beratSuratJalan, double beratNettoRiil, double batasToleransiPersen);
    }
}
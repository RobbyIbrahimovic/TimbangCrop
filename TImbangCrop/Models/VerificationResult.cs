using System;
using System.Collections.Generic;
using System.Text;

namespace TimbangCrop.Models
{
    public class VerificationResult
{
    public bool IsValid { get; set; }
    public double DeviasiKg { get; set; }
    public double PersentaseDeviasi { get; set; }
    public string Pesan { get; set; }
    }
}

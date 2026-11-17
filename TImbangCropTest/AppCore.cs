using System;
using System.Collections.Generic;
using System.Drawing;

namespace TimbangCrop
{
    // Palet Warna Standar Agroindustri
    public static class AppTheme
    {
        public static readonly Color PrimaryDark = Color.FromArgb(27, 67, 50);     // #1B4332 (Sidebar)
        public static readonly Color PrimaryAccent = Color.FromArgb(45, 106, 79);  // #2D6A4F (Tombol Utama)
        public static readonly Color PrimaryHover = Color.FromArgb(64, 145, 108);  // #40916C
        public static readonly Color BgCanvas = Color.FromArgb(244, 247, 245);     // #F4F7F5 (Background Form)
        public static readonly Color CardWhite = Color.White;
        public static readonly Color TextDark = Color.FromArgb(33, 37, 41);
        public static readonly Color TextMuted = Color.FromArgb(108, 117, 125);

        // Status Colors
        public static readonly Color StatusSafe = Color.FromArgb(42, 157, 143);    // Hijau Aman
        public static readonly Color StatusSafeBg = Color.FromArgb(216, 243, 220);
        public static readonly Color StatusDanger = Color.FromArgb(214, 40, 40);   // Merah Anomali
        public static readonly Color StatusDangerBg = Color.FromArgb(255, 214, 214);
    }

    public enum UserRole { Pekerja, Mandor }

    public class UserSession
    {
        public string Username { get; set; }
        public UserRole Role { get; set; }
    }

    // Entitas Komoditas (Mendukung penambahan dinamis di masa depan)
    public class Komoditas
    {
        public string Kode { get; set; }
        public string Nama { get; set; }
        public double ToleransiPersen { get; set; } // Misal: 2.5% untuk Edamame

        public override string ToString() => $"{Nama} (Toleransi ±{ToleransiPersen}%)";
    }

    // Entitas Transaksi Penimbangan
    public class TransaksiTimbang
    {
        public string IdTransaksi { get; set; }
        public DateTime Tanggal { get; set; }
        public string NoSuratJalan { get; set; }
        public string Driver { get; set; }
        public string NamaKomoditas { get; set; }
        public double BeratSuratJalan { get; set; }
        public double BeratGross { get; set; }
        public double BeratTara { get; set; }
        public double BeratNetto => BeratGross - BeratTara;
        public double SelisihKg => BeratNetto - BeratSuratJalan;
        public double PersentaseDeviasi => BeratSuratJalan > 0 ? Math.Abs(SelisihKg / BeratSuratJalan) * 100.0 : 0;
        public string Status { get; set; } // "AMAN", "ANOMALI", "APPROVED", "REJECTED"
        public string CatatanMandor { get; set; }
    }

    // Simulasi Penyimpanan Data Terpusat (In-Memory Repository)
    public static class DataStore
    {
        public static UserSession CurrentUser { get; set; }

        public static List<Komoditas> DaftarKomoditas { get; } = new List<Komoditas>
        {
            new Komoditas { Kode = "KMD-01", Nama = "Edamame Segar (Export Grade)", ToleransiPersen = 2.0 },
            new Komoditas { Kode = "KMD-02", Nama = "Okra Hijau", ToleransiPersen = 2.5 },
            new Komoditas { Kode = "KMD-03", Nama = "Okra Merah", ToleransiPersen = 3.0 }
        };

        public static List<TransaksiTimbang> DaftarTransaksi { get; } = new List<TransaksiTimbang>
        {
            // Data dummy awal berstatus ANOMALI untuk pengujian Form Mandor
            new TransaksiTimbang
            {
                IdTransaksi = "TRX-20261115-001",
                Tanggal = DateTime.Now.AddHours(-2),
                NoSuratJalan = "SJ/MTR/1104",
                Driver = "Budi Santoso",
                NamaKomoditas = "Edamame Segar (Export Grade)",
                BeratSuratJalan = 500.0,
                BeratGross = 510.0,
                BeratTara = 35.0, // Netto = 475 kg (Selisih -25 kg / 5.0% -> Anomali > 2.0%)
                Status = "ANOMALI",
                CatatanMandor = "-"
            },
            new TransaksiTimbang
            {
                IdTransaksi = "TRX-20261115-002",
                Tanggal = DateTime.Now.AddMinutes(-45),
                NoSuratJalan = "SJ/MTR/1109",
                Driver = "Slamet Riyadi",
                NamaKomoditas = "Okra Hijau",
                BeratSuratJalan = 300.0,
                BeratGross = 315.0,
                BeratTara = 30.0, // Netto = 285 kg (Selisih -15 kg / 5.0% -> Anomali > 2.5%)
                Status = "ANOMALI",
                CatatanMandor = "-"
            }
        };
    }
}
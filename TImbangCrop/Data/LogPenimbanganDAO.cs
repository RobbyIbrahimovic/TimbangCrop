using System;
using System.Collections.Generic;
using Npgsql;
using TimbangCrop.Models;

namespace TimbangCrop.Data
{
    public class LogPenimbanganDAO
    {
        public static List<LogPenimbangan> GetRiwayat()
        {
            var hasil = new List<LogPenimbangan>();

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            // LEFT JOIN supaya log tetap tampil walaupun data relasinya tidak lengkap
            string sql = "SELECT l.id_log, l.id_timbangan, l.timestamp, l.status, l.pesan_detail, " +
                         "pb.no_surat_jalan, k.nama_komoditas, t.berat_netto, pb.berat_surat_jalan " +
                         "FROM log_penimbangan l " +
                         "LEFT JOIN penimbangan t ON t.id_timbangan = l.id_timbangan " +
                         "LEFT JOIN penerimaan_barang pb ON pb.id_penerimaan = t.id_penerimaan " +
                         "LEFT JOIN komoditas k ON k.id_komoditas = pb.id_komoditas " +
                         "ORDER BY l.timestamp DESC";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                hasil.Add(new LogPenimbangan
                {
                    IdLog = rd.GetString(0),
                    IdTimbangan = rd.GetString(1),
                    Timestamp = rd.GetDateTime(2),
                    Status = rd.GetString(3),
                    PesanDetail = rd.IsDBNull(4) ? "-" : rd.GetString(4),
                    NoSuratJalan = rd.IsDBNull(5) ? "-" : rd.GetString(5),
                    NamaKomoditas = rd.IsDBNull(6) ? "-" : rd.GetString(6),
                    BeratNetto = rd.IsDBNull(7) ? 0 : rd.GetDouble(7),
                    BeratSuratJalan = rd.IsDBNull(8) ? 0 : rd.GetDouble(8)
                });
            }

            return hasil;
        }
    }
}

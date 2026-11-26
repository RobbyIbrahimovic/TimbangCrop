using System;
using System.Data;
using Npgsql;
using TimbangCrop.Models;

namespace TimbangCrop.Data
{
    public class PenimbanganDAO
    {
        public static void SimpanPenerimaan(PenerimaanBarang p)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            string sql = "INSERT INTO penerimaan_barang (id_penerimaan, no_surat_jalan, nama_driver, asal_lahan, id_komoditas, berat_surat_jalan, tanggal) " +
                         "VALUES (@id, @sj, @driver, @asal, @kom, @berat, @tgl)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", p.IdPenerimaan);
            cmd.Parameters.AddWithValue("sj", p.NoSuratJalan);
            cmd.Parameters.AddWithValue("driver", p.NamaDriver);
            cmd.Parameters.AddWithValue("asal", p.AsalLahan);
            cmd.Parameters.AddWithValue("kom", p.IdKomoditas);
            cmd.Parameters.AddWithValue("berat", p.BeratSuratJalan);
            cmd.Parameters.AddWithValue("tgl", p.Tanggal);
            cmd.ExecuteNonQuery();
        }

        public static void SimpanPenimbangan(Penimbangan t)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            string sql = "INSERT INTO penimbangan (id_timbangan, id_penerimaan, berat_kotor, berat_tara, berat_netto) " +
                         "VALUES (@idTmb, @idPnr, @kotor, @tara, @netto)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idTmb", t.IdTimbangan);
            cmd.Parameters.AddWithValue("idPnr", t.IdPenerimaan);
            cmd.Parameters.AddWithValue("kotor", t.BeratKotor);
            cmd.Parameters.AddWithValue("tara", t.BeratTara);
            cmd.Parameters.AddWithValue("netto", t.BeratNetto);
            cmd.ExecuteNonQuery();
        }

        public static void SimpanLog(string idLog, string idTimbangan, string status, string pesanDetail)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            string sql = "INSERT INTO log_penimbangan (id_log, id_timbangan, timestamp, status, pesan_detail) " +
                         "VALUES (@idLog, @idTmb, @ts, @st, @msg)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idLog", idLog);
            cmd.Parameters.AddWithValue("idTmb", idTimbangan);
            cmd.Parameters.AddWithValue("ts", DateTime.Now);
            cmd.Parameters.AddWithValue("st", status);
            cmd.Parameters.AddWithValue("msg", pesanDetail);
            cmd.ExecuteNonQuery();
        }

        public static DataTable GetRiwayatLog()
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            string sql = "SELECT l.id_log, l.id_timbangan, l.timestamp, l.status, l.pesan_detail FROM log_penimbangan l ORDER BY l.timestamp DESC";
            using var da = new NpgsqlDataAdapter(sql, conn);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable GetKomoditas()
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            string sql = "SELECT id_komoditas, nama_komoditas, toleransi_persen FROM komoditas ORDER BY nama_komoditas";
            using var da = new NpgsqlDataAdapter(sql, conn);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable GetAntreanPenerimaan()
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            string sql = @"SELECT p.id_penerimaan, p.no_surat_jalan, p.asal_lahan, p.nama_driver,
                          k.nama_komoditas, p.berat_surat_jalan, p.tanggal,
                          CASE WHEN lg.status IN ('AMAN', 'APPROVED') THEN 'SELESAI' ELSE 'MENUNGGU' END AS status
                   FROM penerimaan_barang p
                   JOIN komoditas k ON k.id_komoditas = p.id_komoditas
                   LEFT JOIN LATERAL (
                       SELECT l.status
                       FROM log_penimbangan l
                       JOIN penimbangan t ON t.id_timbangan = l.id_timbangan
                       WHERE t.id_penerimaan = p.id_penerimaan
                       ORDER BY l.timestamp DESC
                       LIMIT 1
                   ) lg ON TRUE
                   ORDER BY p.tanggal DESC";
            using var da = new NpgsqlDataAdapter(sql, conn);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimbangCropTest
{
    public class FormRiwayatLog : Form
    {
        private Panel pnlFilter = null!;
        private Label lblFilterKomoditas = null!;
        private ComboBox cmbFilterKomoditas = null!;
        private Label lblFilterStatus = null!;
        private ComboBox cmbFilterStatus = null!;
        private TextBox txtCari = null!;
        private Button btnCari = null!;
        private DataGridView dgvRiwayat = null!;
        private DataGridViewTextBoxColumn colId = null!;
        private DataGridViewTextBoxColumn colWaktu = null!;
        private DataGridViewTextBoxColumn colNoSJ = null!;
        private DataGridViewTextBoxColumn colKomoditas = null!;
        private DataGridViewTextBoxColumn colNetto = null!;
        private DataGridViewTextBoxColumn colDeviasi = null!;
        private DataGridViewTextBoxColumn colStatus = null!;

        public FormRiwayatLog()
        {
            InitializeComponent();
            dgvRiwayat.Rows.Add("TRX-001", "15/11/2026 08:15", "SJ/MTR/1101", "Edamame Segar", "495.00 kg", "1.00%", "AMAN");
            dgvRiwayat.Rows.Add("TRX-002", "15/11/2026 09:40", "SJ/MTR/1104", "Edamame Segar", "475.00 kg", "5.00%", "ANOMALI");
            dgvRiwayat.Rows.Add("TRX-003", "15/11/2026 11:05", "SJ/MTR/1107", "Okra Hijau", "318.50 kg", "0.47%", "AMAN");
        }

        private void InitializeComponent()
        {
            pnlFilter = new Panel();
            lblFilterKomoditas = new Label();
            cmbFilterKomoditas = new ComboBox();
            lblFilterStatus = new Label();
            cmbFilterStatus = new ComboBox();
            txtCari = new TextBox();
            btnCari = new Button();
            dgvRiwayat = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colWaktu = new DataGridViewTextBoxColumn();
            colNoSJ = new DataGridViewTextBoxColumn();
            colKomoditas = new DataGridViewTextBoxColumn();
            colNetto = new DataGridViewTextBoxColumn();
            colDeviasi = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();

            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(lblFilterKomoditas);
            pnlFilter.Controls.Add(cmbFilterKomoditas);
            pnlFilter.Controls.Add(lblFilterStatus);
            pnlFilter.Controls.Add(cmbFilterStatus);
            pnlFilter.Controls.Add(txtCari);
            pnlFilter.Controls.Add(btnCari);
            pnlFilter.Location = new Point(20, 20);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(920, 75);

            lblFilterKomoditas.AutoSize = true;
            lblFilterKomoditas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFilterKomoditas.Location = new Point(20, 12);
            lblFilterKomoditas.Name = "lblFilterKomoditas";
            lblFilterKomoditas.Text = "Filter Komoditas:";

            cmbFilterKomoditas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterKomoditas.Font = new Font("Segoe UI", 9.5F);
            cmbFilterKomoditas.Items.AddRange(new object[] { "Semua Komoditas", "Edamame Segar", "Okra Hijau", "Okra Merah" });
            cmbFilterKomoditas.Location = new Point(20, 34);
            cmbFilterKomoditas.Name = "cmbFilterKomoditas";
            cmbFilterKomoditas.Size = new Size(200, 24);

            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFilterStatus.Location = new Point(240, 12);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Text = "Status Validasi:";

            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.Font = new Font("Segoe UI", 9.5F);
            cmbFilterStatus.Items.AddRange(new object[] { "Semua Status", "AMAN", "ANOMALI", "APPROVED", "REJECTED" });
            cmbFilterStatus.Location = new Point(240, 34);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(180, 24);

            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(445, 33);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(310, 25);
            txtCari.Text = "Cari No. Surat Jalan / ID...";

            btnCari.BackColor = Color.FromArgb(45, 106, 79);
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(770, 32);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(130, 28);
            btnCari.Text = "FILTER DATA";

            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dgvRiwayat.ColumnHeadersHeight = 44;
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { colId, colWaktu, colNoSJ, colKomoditas, colNetto, colDeviasi, colStatus });
            dgvRiwayat.EnableHeadersVisualStyles = false;
            dgvRiwayat.Font = new Font("Segoe UI", 9.5F);
            dgvRiwayat.Location = new Point(20, 110);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowTemplate.Height = 35;
            dgvRiwayat.Size = new Size(920, 405);

            dgvRiwayat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 67, 50);
            dgvRiwayat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRiwayat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            colId.HeaderText = "ID Transaksi";
            colId.Name = "colId";
            colWaktu.HeaderText = "Waktu Timbang";
            colWaktu.Name = "colWaktu";
            colNoSJ.HeaderText = "No. Surat Jalan";
            colNoSJ.Name = "colNoSJ";
            colKomoditas.HeaderText = "Komoditas";
            colKomoditas.Name = "colKomoditas";
            colNetto.HeaderText = "Berat Netto";
            colNetto.Name = "colNetto";
            colDeviasi.HeaderText = "Deviasi (%)";
            colDeviasi.Name = "colDeviasi";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";

            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(960, 535);
            Controls.Add(pnlFilter);
            Controls.Add(dgvRiwayat);
            Name = "FormRiwayatLog";
            Text = "TimbangCrop - Riwayat Log Penimbangan";
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
        }
    }
}
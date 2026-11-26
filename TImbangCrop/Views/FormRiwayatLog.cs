using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TimbangCrop.Data;
using TimbangCrop.Models;

namespace TimbangCrop.Views
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
        private CheckBox chkFilterTanggal = null!;
        private DateTimePicker dtpDari = null!;
        private Label lblSampai = null!;
        private DateTimePicker dtpSampai = null!;
        private DataGridView dgvRiwayat = null!;
        private DataGridViewTextBoxColumn colId = null!;
        private DataGridViewTextBoxColumn colWaktu = null!;
        private DataGridViewTextBoxColumn colNoSJ = null!;
        private DataGridViewTextBoxColumn colKomoditas = null!;
        private DataGridViewTextBoxColumn colNetto = null!;
        private DataGridViewTextBoxColumn colDeviasi = null!;
        private DataGridViewTextBoxColumn colStatus = null!;

        private List<LogPenimbangan> _semuaLog = new List<LogPenimbangan>();

        public FormRiwayatLog()
        {
            InitializeComponent();
            cmbFilterKomoditas.SelectedIndex = 0;
            cmbFilterStatus.SelectedIndex = 0;
            LoadRiwayat();
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlFilter = new Panel();
            lblFilterKomoditas = new Label();
            cmbFilterKomoditas = new ComboBox();
            lblFilterStatus = new Label();
            cmbFilterStatus = new ComboBox();
            txtCari = new TextBox();
            btnCari = new Button();
            chkFilterTanggal = new CheckBox();
            dtpDari = new DateTimePicker();
            lblSampai = new Label();
            dtpSampai = new DateTimePicker();
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
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(lblFilterKomoditas);
            pnlFilter.Controls.Add(cmbFilterKomoditas);
            pnlFilter.Controls.Add(lblFilterStatus);
            pnlFilter.Controls.Add(cmbFilterStatus);
            pnlFilter.Controls.Add(txtCari);
            pnlFilter.Controls.Add(btnCari);
            pnlFilter.Controls.Add(chkFilterTanggal);
            pnlFilter.Controls.Add(dtpDari);
            pnlFilter.Controls.Add(lblSampai);
            pnlFilter.Controls.Add(dtpSampai);
            pnlFilter.Location = new Point(20, 20);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(920, 120);
            pnlFilter.TabIndex = 0;
            // 
            // lblFilterKomoditas
            // 
            lblFilterKomoditas.AutoSize = true;
            lblFilterKomoditas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFilterKomoditas.Location = new Point(20, 12);
            lblFilterKomoditas.Name = "lblFilterKomoditas";
            lblFilterKomoditas.Size = new Size(129, 20);
            lblFilterKomoditas.TabIndex = 0;
            lblFilterKomoditas.Text = "Filter Komoditas:";
            // 
            // cmbFilterKomoditas
            // 
            cmbFilterKomoditas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterKomoditas.Font = new Font("Segoe UI", 9.5F);
            cmbFilterKomoditas.Items.AddRange(new object[] { "Semua Komoditas", "Edamame Segar", "Okra Hijau", "Okra Merah" });
            cmbFilterKomoditas.Location = new Point(20, 34);
            cmbFilterKomoditas.Name = "cmbFilterKomoditas";
            cmbFilterKomoditas.Size = new Size(200, 29);
            cmbFilterKomoditas.TabIndex = 1;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFilterStatus.Location = new Point(240, 12);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(114, 20);
            lblFilterStatus.TabIndex = 2;
            lblFilterStatus.Text = "Status Validasi:";
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.Font = new Font("Segoe UI", 9.5F);
            cmbFilterStatus.Items.AddRange(new object[] { "Semua Status", "AMAN", "ANOMALI", "APPROVED", "REJECTED" });
            cmbFilterStatus.Location = new Point(240, 34);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(180, 29);
            cmbFilterStatus.TabIndex = 3;
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(445, 33);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(310, 30);
            txtCari.TabIndex = 4;
            txtCari.PlaceholderText = "Cari No. Surat Jalan / ID...";
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(45, 106, 79);
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(770, 32);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(130, 28);
            btnCari.TabIndex = 5;
            btnCari.Text = "FILTER DATA";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            //
            // chkFilterTanggal
            //
            chkFilterTanggal.AutoSize = true;
            chkFilterTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkFilterTanggal.Location = new Point(20, 82);
            chkFilterTanggal.Name = "chkFilterTanggal";
            chkFilterTanggal.Size = new Size(130, 24);
            chkFilterTanggal.TabIndex = 6;
            chkFilterTanggal.Text = "Filter Tanggal:";
            chkFilterTanggal.UseVisualStyleBackColor = true;
            chkFilterTanggal.CheckedChanged += chkFilterTanggal_CheckedChanged;
            //
            // dtpDari
            //
            dtpDari.Enabled = false;
            dtpDari.Font = new Font("Segoe UI", 9.5F);
            dtpDari.Format = DateTimePickerFormat.Short;
            dtpDari.Location = new Point(160, 80);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(150, 29);
            dtpDari.TabIndex = 7;
            dtpDari.Value = DateTime.Today.AddDays(-30);
            //
            // lblSampai
            //
            lblSampai.AutoSize = true;
            lblSampai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSampai.Location = new Point(320, 84);
            lblSampai.Name = "lblSampai";
            lblSampai.Size = new Size(30, 20);
            lblSampai.TabIndex = 8;
            lblSampai.Text = "s/d";
            //
            // dtpSampai
            //
            dtpSampai.Enabled = false;
            dtpSampai.Font = new Font("Segoe UI", 9.5F);
            dtpSampai.Format = DateTimePickerFormat.Short;
            dtpSampai.Location = new Point(360, 80);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(150, 29);
            dtpSampai.TabIndex = 9;
            dtpSampai.Value = DateTime.Today;
            //
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(27, 67, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRiwayat.ColumnHeadersHeight = 44;
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { colId, colWaktu, colNoSJ, colKomoditas, colNetto, colDeviasi, colStatus });
            dgvRiwayat.EnableHeadersVisualStyles = false;
            dgvRiwayat.Font = new Font("Segoe UI", 9.5F);
            dgvRiwayat.Location = new Point(20, 155);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowHeadersWidth = 51;
            dgvRiwayat.RowTemplate.Height = 35;
            dgvRiwayat.Size = new Size(920, 360);
            dgvRiwayat.TabIndex = 1;
            dgvRiwayat.CellContentClick += dgvRiwayat_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID Transaksi";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colWaktu
            // 
            colWaktu.HeaderText = "Waktu Timbang";
            colWaktu.MinimumWidth = 6;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            // 
            // colNoSJ
            // 
            colNoSJ.HeaderText = "No. Surat Jalan";
            colNoSJ.MinimumWidth = 6;
            colNoSJ.Name = "colNoSJ";
            colNoSJ.ReadOnly = true;
            // 
            // colKomoditas
            // 
            colKomoditas.HeaderText = "Komoditas";
            colKomoditas.MinimumWidth = 6;
            colKomoditas.Name = "colKomoditas";
            colKomoditas.ReadOnly = true;
            // 
            // colNetto
            // 
            colNetto.HeaderText = "Berat Netto";
            colNetto.MinimumWidth = 6;
            colNetto.Name = "colNetto";
            colNetto.ReadOnly = true;
            // 
            // colDeviasi
            // 
            colDeviasi.HeaderText = "Deviasi (%)";
            colDeviasi.MinimumWidth = 6;
            colDeviasi.Name = "colDeviasi";
            colDeviasi.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // FormRiwayatLog
            // 
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

        private void LoadRiwayat()
        {
            try
            {
                _semuaLog = LogPenimbanganDAO.GetRiwayat();
            }
            catch (Exception ex)
            {
                _semuaLog = new List<LogPenimbangan>();
                MessageBox.Show("Gagal memuat riwayat dari database:\n" + ex.Message,
                    "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            IsiFilterKomoditas();
            TampilkanData();
        }

        private void IsiFilterKomoditas()
        {
            // Pilihan komoditas diambil dari data riwayat, supaya sama dengan nama di DB
            cmbFilterKomoditas.Items.Clear();
            cmbFilterKomoditas.Items.Add("Semua Komoditas");
            foreach (string nama in _semuaLog
                         .Select(l => l.NamaKomoditas)
                         .Where(n => n != "-")
                         .Distinct()
                         .OrderBy(n => n))
            {
                cmbFilterKomoditas.Items.Add(nama);
            }
            cmbFilterKomoditas.SelectedIndex = 0;
        }

        private void TampilkanData()
        {
            string filterKomoditas = cmbFilterKomoditas.SelectedItem?.ToString() ?? "Semua Komoditas";
            string filterStatus = cmbFilterStatus.SelectedItem?.ToString() ?? "Semua Status";
            string keyword = txtCari.Text.Trim().ToLower();
            DateTime dari = dtpDari.Value.Date;
            DateTime sampai = dtpSampai.Value.Date;

            IEnumerable<LogPenimbangan> data = _semuaLog;

            if (filterKomoditas != "Semua Komoditas")
                data = data.Where(l => l.NamaKomoditas == filterKomoditas);

            if (filterStatus != "Semua Status")
                data = data.Where(l => l.Status.Equals(filterStatus, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(keyword))
                data = data.Where(l => $"{l.IdTimbangan} {l.NoSuratJalan} {l.NamaKomoditas}".ToLower().Contains(keyword));

            if (chkFilterTanggal.Checked)
                data = data.Where(l => l.Timestamp.Date >= dari && l.Timestamp.Date <= sampai);

            dgvRiwayat.Rows.Clear();
            foreach (LogPenimbangan log in data)
            {
                int idx = dgvRiwayat.Rows.Add(
                    log.IdTimbangan,
                    log.Timestamp.ToString("dd/MM/yyyy HH:mm"),
                    log.NoSuratJalan,
                    log.NamaKomoditas,
                    $"{log.BeratNetto:F2} kg",
                    $"{log.PersentaseDeviasi:F2}%",
                    log.Status);

                WarnaiStatus(dgvRiwayat.Rows[idx].Cells["colStatus"], log.Status);
            }
        }

        private void WarnaiStatus(DataGridViewCell cell, string status)
        {
            if (status.Equals("ANOMALI", StringComparison.OrdinalIgnoreCase) ||
                status.Equals("REJECTED", StringComparison.OrdinalIgnoreCase))
            {
                cell.Style.BackColor = Color.FromArgb(255, 229, 229);
                cell.Style.ForeColor = Color.FromArgb(214, 40, 40);
            }
            else if (status.Equals("AMAN", StringComparison.OrdinalIgnoreCase) ||
                     status.Equals("APPROVED", StringComparison.OrdinalIgnoreCase))
            {
                cell.Style.BackColor = Color.FromArgb(216, 243, 220);
                cell.Style.ForeColor = Color.FromArgb(42, 157, 143);
            }
        }

        private void chkFilterTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dtpDari.Enabled = chkFilterTanggal.Checked;
            dtpSampai.Enabled = chkFilterTanggal.Checked;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void dgvRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
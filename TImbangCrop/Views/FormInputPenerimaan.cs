using System;
using System.Drawing;
using System.Windows.Forms;
using TimbangCrop.Data;
using TimbangCrop.Models;

namespace TimbangCrop.Views
{
    public class FormInputPenerimaan : Form
    {
        private GroupBox gbRegistrasiSJ = null!;
        private Label lblNoSJ = null!;
        private TextBox txtNoSJ = null!;
        private Label lblTanggal = null!;
        private DateTimePicker dtpTanggal = null!;
        private Label lblSupplier = null!;
        private TextBox txtSupplier = null!;
        private Label lblNopol = null!;
        private TextBox txtNopol = null!;
        private Label lblDriver = null!;
        private TextBox txtDriver = null!;
        private Label lblKomoditas = null!;
        private ComboBox cmbKomoditas = null!;
        private Label lblEstimasiBerat = null!;
        private TextBox txtEstimasiBerat = null!;
        private Button btnSimpanSJ = null!;
        private DataGridView dgvAntreanSJ = null!;
        private DataGridViewTextBoxColumn colNoSJ = null!;
        private DataGridViewTextBoxColumn colSupplier = null!;
        private DataGridViewTextBoxColumn colKomoditas = null!;
        private DataGridViewTextBoxColumn colEstimasi = null!;
        private DataGridViewTextBoxColumn colStatus = null!;

        public FormInputPenerimaan()
        {
            InitializeComponent();
            cmbKomoditas.SelectedIndex = 0;
            dgvAntreanSJ.Rows.Add("SJ/MTR/2026-089", "Kelompok Tani Makmur", "Edamame Segar", "650.00 kg", "MENUNGGU");
            dgvAntreanSJ.Rows.Add("SJ/MTR/2026-090", "Kebun Mitra Silo", "Okra Hijau", "420.00 kg", "MENUNGGU");
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gbRegistrasiSJ = new GroupBox();
            lblNoSJ = new Label();
            txtNoSJ = new TextBox();
            lblTanggal = new Label();
            dtpTanggal = new DateTimePicker();
            lblSupplier = new Label();
            txtSupplier = new TextBox();
            lblNopol = new Label();
            txtNopol = new TextBox();
            lblDriver = new Label();
            txtDriver = new TextBox();
            lblKomoditas = new Label();
            cmbKomoditas = new ComboBox();
            lblEstimasiBerat = new Label();
            txtEstimasiBerat = new TextBox();
            btnSimpanSJ = new Button();
            dgvAntreanSJ = new DataGridView();
            colNoSJ = new DataGridViewTextBoxColumn();
            colSupplier = new DataGridViewTextBoxColumn();
            colKomoditas = new DataGridViewTextBoxColumn();
            colEstimasi = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            gbRegistrasiSJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAntreanSJ).BeginInit();
            SuspendLayout();
            // 
            // gbRegistrasiSJ
            // 
            gbRegistrasiSJ.BackColor = Color.White;
            gbRegistrasiSJ.Controls.Add(lblNoSJ);
            gbRegistrasiSJ.Controls.Add(txtNoSJ);
            gbRegistrasiSJ.Controls.Add(lblTanggal);
            gbRegistrasiSJ.Controls.Add(dtpTanggal);
            gbRegistrasiSJ.Controls.Add(lblSupplier);
            gbRegistrasiSJ.Controls.Add(txtSupplier);
            gbRegistrasiSJ.Controls.Add(lblNopol);
            gbRegistrasiSJ.Controls.Add(txtNopol);
            gbRegistrasiSJ.Controls.Add(lblDriver);
            gbRegistrasiSJ.Controls.Add(txtDriver);
            gbRegistrasiSJ.Controls.Add(lblKomoditas);
            gbRegistrasiSJ.Controls.Add(cmbKomoditas);
            gbRegistrasiSJ.Controls.Add(lblEstimasiBerat);
            gbRegistrasiSJ.Controls.Add(txtEstimasiBerat);
            gbRegistrasiSJ.Controls.Add(btnSimpanSJ);
            gbRegistrasiSJ.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            gbRegistrasiSJ.ForeColor = Color.FromArgb(27, 67, 50);
            gbRegistrasiSJ.Location = new Point(20, 20);
            gbRegistrasiSJ.Name = "gbRegistrasiSJ";
            gbRegistrasiSJ.Size = new Size(410, 495);
            gbRegistrasiSJ.TabIndex = 0;
            gbRegistrasiSJ.TabStop = false;
            gbRegistrasiSJ.Text = " Registrasi Surat Jalan Masuk ";
            // 
            // lblNoSJ
            // 
            lblNoSJ.AutoSize = true;
            lblNoSJ.Font = new Font("Segoe UI", 9.5F);
            lblNoSJ.ForeColor = Color.FromArgb(33, 37, 41);
            lblNoSJ.Location = new Point(20, 40);
            lblNoSJ.Name = "lblNoSJ";
            lblNoSJ.Size = new Size(117, 21);
            lblNoSJ.TabIndex = 0;
            lblNoSJ.Text = "No. Surat Jalan:";
            // 
            // txtNoSJ
            // 
            txtNoSJ.Font = new Font("Segoe UI", 10F);
            txtNoSJ.Location = new Point(165, 36);
            txtNoSJ.Name = "txtNoSJ";
            txtNoSJ.Size = new Size(220, 30);
            txtNoSJ.TabIndex = 1;
            txtNoSJ.Text = "SJ/MTR/2026-091";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Segoe UI", 9.5F);
            lblTanggal.ForeColor = Color.FromArgb(33, 37, 41);
            lblTanggal.Location = new Point(20, 88);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(116, 21);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "Tanggal Masuk:";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Font = new Font("Segoe UI", 9.5F);
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(165, 84);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(220, 29);
            dtpTanggal.TabIndex = 3;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 9.5F);
            lblSupplier.ForeColor = Color.FromArgb(33, 37, 41);
            lblSupplier.Location = new Point(20, 136);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(144, 21);
            lblSupplier.TabIndex = 4;
            lblSupplier.Text = "Asal Lahan / Petani:";
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("Segoe UI", 10F);
            txtSupplier.Location = new Point(165, 132);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(220, 30);
            txtSupplier.TabIndex = 5;
            txtSupplier.Text = "KT Tani Jaya Jember";
            // 
            // lblNopol
            // 
            lblNopol.AutoSize = true;
            lblNopol.Font = new Font("Segoe UI", 9.5F);
            lblNopol.ForeColor = Color.FromArgb(33, 37, 41);
            lblNopol.Location = new Point(20, 184);
            lblNopol.Name = "lblNopol";
            lblNopol.Size = new Size(136, 21);
            lblNopol.TabIndex = 6;
            lblNopol.Text = "No. Polisi Armada:";
            // 
            // txtNopol
            // 
            txtNopol.Font = new Font("Segoe UI", 10F);
            txtNopol.Location = new Point(165, 180);
            txtNopol.Name = "txtNopol";
            txtNopol.Size = new Size(220, 30);
            txtNopol.TabIndex = 7;
            txtNopol.Text = "P 8412 QK";
            // 
            // lblDriver
            // 
            lblDriver.AutoSize = true;
            lblDriver.Font = new Font("Segoe UI", 9.5F);
            lblDriver.ForeColor = Color.FromArgb(33, 37, 41);
            lblDriver.Location = new Point(20, 232);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(96, 21);
            lblDriver.TabIndex = 8;
            lblDriver.Text = "Nama Supir:";
            // 
            // txtDriver
            // 
            txtDriver.Font = new Font("Segoe UI", 10F);
            txtDriver.Location = new Point(165, 228);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(220, 30);
            txtDriver.TabIndex = 9;
            txtDriver.Text = "Hendra Wijaya";
            // 
            // lblKomoditas
            // 
            lblKomoditas.AutoSize = true;
            lblKomoditas.Font = new Font("Segoe UI", 9.5F);
            lblKomoditas.ForeColor = Color.FromArgb(33, 37, 41);
            lblKomoditas.Location = new Point(20, 280);
            lblKomoditas.Name = "lblKomoditas";
            lblKomoditas.Size = new Size(87, 21);
            lblKomoditas.TabIndex = 10;
            lblKomoditas.Text = "Komoditas:";
            // 
            // cmbKomoditas
            // 
            cmbKomoditas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKomoditas.Font = new Font("Segoe UI", 10F);
            cmbKomoditas.Items.AddRange(new object[] { "Edamame Segar", "Okra Hijau", "Okra Merah" });
            cmbKomoditas.Location = new Point(165, 276);
            cmbKomoditas.Name = "cmbKomoditas";
            cmbKomoditas.Size = new Size(220, 31);
            cmbKomoditas.TabIndex = 11;
            // 
            // lblEstimasiBerat
            // 
            lblEstimasiBerat.AutoSize = true;
            lblEstimasiBerat.Font = new Font("Segoe UI", 9.5F);
            lblEstimasiBerat.ForeColor = Color.FromArgb(33, 37, 41);
            lblEstimasiBerat.Location = new Point(20, 328);
            lblEstimasiBerat.Name = "lblEstimasiBerat";
            lblEstimasiBerat.Size = new Size(152, 21);
            lblEstimasiBerat.TabIndex = 12;
            lblEstimasiBerat.Text = "Berat Dokumen (kg):";
            // 
            // txtEstimasiBerat
            // 
            txtEstimasiBerat.Font = new Font("Segoe UI", 10F);
            txtEstimasiBerat.Location = new Point(165, 324);
            txtEstimasiBerat.Name = "txtEstimasiBerat";
            txtEstimasiBerat.Size = new Size(220, 30);
            txtEstimasiBerat.TabIndex = 13;
            txtEstimasiBerat.Text = "550";
            // 
            // btnSimpanSJ
            // 
            btnSimpanSJ.BackColor = Color.FromArgb(45, 106, 79);
            btnSimpanSJ.FlatAppearance.BorderSize = 0;
            btnSimpanSJ.FlatStyle = FlatStyle.Flat;
            btnSimpanSJ.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSimpanSJ.ForeColor = Color.White;
            btnSimpanSJ.Location = new Point(20, 415);
            btnSimpanSJ.Name = "btnSimpanSJ";
            btnSimpanSJ.Size = new Size(365, 45);
            btnSimpanSJ.TabIndex = 14;
            btnSimpanSJ.Text = "DAFTARKAN KE ANTREAN TIMBANG";
            btnSimpanSJ.UseVisualStyleBackColor = false;
            btnSimpanSJ.Click += btnSimpanSJ_Click;
            // 
            // dgvAntreanSJ
            // 
            dgvAntreanSJ.AllowUserToAddRows = false;
            dgvAntreanSJ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAntreanSJ.BackgroundColor = Color.White;
            dgvAntreanSJ.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(27, 67, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAntreanSJ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAntreanSJ.ColumnHeadersHeight = 42;
            dgvAntreanSJ.Columns.AddRange(new DataGridViewColumn[] { colNoSJ, colSupplier, colKomoditas, colEstimasi, colStatus });
            dgvAntreanSJ.EnableHeadersVisualStyles = false;
            dgvAntreanSJ.Font = new Font("Segoe UI", 9F);
            dgvAntreanSJ.Location = new Point(450, 28);
            dgvAntreanSJ.Name = "dgvAntreanSJ";
            dgvAntreanSJ.ReadOnly = true;
            dgvAntreanSJ.RowHeadersVisible = false;
            dgvAntreanSJ.RowHeadersWidth = 51;
            dgvAntreanSJ.RowTemplate.Height = 34;
            dgvAntreanSJ.Size = new Size(490, 487);
            dgvAntreanSJ.TabIndex = 1;
            dgvAntreanSJ.CellContentClick += dgvAntreanSJ_CellContentClick;
            // 
            // colNoSJ
            // 
            colNoSJ.HeaderText = "No. SJ";
            colNoSJ.MinimumWidth = 6;
            colNoSJ.Name = "colNoSJ";
            colNoSJ.ReadOnly = true;
            // 
            // colSupplier
            // 
            colSupplier.HeaderText = "Asal Lahan";
            colSupplier.MinimumWidth = 6;
            colSupplier.Name = "colSupplier";
            colSupplier.ReadOnly = true;
            // 
            // colKomoditas
            // 
            colKomoditas.HeaderText = "Komoditas";
            colKomoditas.MinimumWidth = 6;
            colKomoditas.Name = "colKomoditas";
            colKomoditas.ReadOnly = true;
            // 
            // colEstimasi
            // 
            colEstimasi.HeaderText = "Berat SJ";
            colEstimasi.MinimumWidth = 6;
            colEstimasi.Name = "colEstimasi";
            colEstimasi.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // FormInputPenerimaan
            // 
            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(960, 535);
            Controls.Add(gbRegistrasiSJ);
            Controls.Add(dgvAntreanSJ);
            Name = "FormInputPenerimaan";
            Text = "TimbangCrop - Input Penerimaan Surat Jalan";
            gbRegistrasiSJ.ResumeLayout(false);
            gbRegistrasiSJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAntreanSJ).EndInit();
            ResumeLayout(false);
        }

        private void btnSimpanSJ_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtEstimasiBerat.Text, out double beratSJ) || beratSJ <= 0)
            {
                MessageBox.Show("Berat Dokumen harus berupa angka lebih dari 0!", "Validasi Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string idPenerimaan = "PNR-" + DateTime.Now.Ticks.ToString().Substring(10);
                string namaKomoditas = cmbKomoditas.SelectedItem?.ToString() ?? "Edamame Segar";
                string idKomoditas = namaKomoditas.Contains("Edamame") ? "KOM-001" : "KOM-002";

                var penerimaan = new PenerimaanBarang
                {
                    IdPenerimaan = idPenerimaan,
                    NoSuratJalan = txtNoSJ.Text.Trim(),
                    NamaDriver = txtDriver.Text.Trim(),
                    IdKomoditas = idKomoditas,
                    BeratSuratJalan = beratSJ,
                    Tanggal = dtpTanggal.Value
                };

                PenimbanganDAO.SimpanPenerimaan(penerimaan);

                dgvAntreanSJ.Rows.Insert(0,
                    penerimaan.NoSuratJalan,
                    txtSupplier.Text.Trim(),
                    namaKomoditas,
                    $"{beratSJ:F2} kg",
                    "MENUNGGU");

                MessageBox.Show($"Surat Jalan {penerimaan.NoSuratJalan} berhasil disimpan ke database!",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan penerimaan ke database:\n" + ex.Message,
                    "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAntreanSJ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
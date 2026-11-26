using System;
using System.Data;
using System.Globalization;
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
        private DataGridViewTextBoxColumn colDriver = null!;
        private DataGridViewTextBoxColumn colTanggal = null!;
        private DataGridViewTextBoxColumn colKomoditas = null!;
        private DataGridViewTextBoxColumn colEstimasi = null!;
        private DataGridViewTextBoxColumn colStatus = null!;

        public FormInputPenerimaan()
        {
            InitializeComponent();

            // Kolom berat hanya menerima angka dan satu pemisah desimal
            txtEstimasiBerat.KeyPress += (s, ev) =>
            {
                if (char.IsControl(ev.KeyChar)) return;
                bool pemisah = ev.KeyChar == ',' || ev.KeyChar == '.';
                bool sudahAdaPemisah = txtEstimasiBerat.Text.Contains(',') || txtEstimasiBerat.Text.Contains('.');
                if (!char.IsDigit(ev.KeyChar) && !(pemisah && !sudahAdaPemisah))
                    ev.Handled = true;
            };

            try
            {
                cmbKomoditas.DataSource = PenimbanganDAO.GetKomoditas();
                cmbKomoditas.DisplayMember = "nama_komoditas";
                cmbKomoditas.ValueMember = "id_komoditas";
                MuatAntrean();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data dari database:\n" + ex.Message,
                    "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            gbRegistrasiSJ = new GroupBox();
            lblNoSJ = new Label();
            txtNoSJ = new TextBox();
            lblTanggal = new Label();
            dtpTanggal = new DateTimePicker();
            lblSupplier = new Label();
            txtSupplier = new TextBox();
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
            colDriver = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
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
            lblNoSJ.Size = new Size(99, 17);
            lblNoSJ.TabIndex = 0;
            lblNoSJ.Text = "No. Surat Jalan:";
            // 
            // txtNoSJ
            // 
            txtNoSJ.Font = new Font("Segoe UI", 10F);
            txtNoSJ.Location = new Point(165, 36);
            txtNoSJ.Name = "txtNoSJ";
            txtNoSJ.Size = new Size(220, 25);
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
            lblTanggal.Size = new Size(99, 17);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "Tanggal Masuk:";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Font = new Font("Segoe UI", 9.5F);
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(165, 84);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(220, 24);
            dtpTanggal.TabIndex = 3;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 9.5F);
            lblSupplier.ForeColor = Color.FromArgb(33, 37, 41);
            lblSupplier.Location = new Point(20, 136);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(121, 17);
            lblSupplier.TabIndex = 4;
            lblSupplier.Text = "Asal Lahan / Petani:";
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("Segoe UI", 10F);
            txtSupplier.Location = new Point(165, 132);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(220, 25);
            txtSupplier.TabIndex = 5;
            txtSupplier.Text = "KT Tani Jaya Jember";
            // 
            // lblDriver
            // 
            lblDriver.AutoSize = true;
            lblDriver.Font = new Font("Segoe UI", 9.5F);
            lblDriver.ForeColor = Color.FromArgb(33, 37, 41);
            lblDriver.Location = new Point(20, 184);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(80, 17);
            lblDriver.TabIndex = 8;
            lblDriver.Text = "Nama Supir:";
            // 
            // txtDriver
            // 
            txtDriver.Font = new Font("Segoe UI", 10F);
            txtDriver.Location = new Point(165, 181);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(220, 25);
            txtDriver.TabIndex = 9;
            txtDriver.Text = "Hendra Wijaya";
            // 
            // lblKomoditas
            // 
            lblKomoditas.AutoSize = true;
            lblKomoditas.Font = new Font("Segoe UI", 9.5F);
            lblKomoditas.ForeColor = Color.FromArgb(33, 37, 41);
            lblKomoditas.Location = new Point(20, 228);
            lblKomoditas.Name = "lblKomoditas";
            lblKomoditas.Size = new Size(74, 17);
            lblKomoditas.TabIndex = 10;
            lblKomoditas.Text = "Komoditas:";
            // 
            // cmbKomoditas
            // 
            cmbKomoditas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKomoditas.Font = new Font("Segoe UI", 10F);
            cmbKomoditas.Location = new Point(165, 225);
            cmbKomoditas.Name = "cmbKomoditas";
            cmbKomoditas.Size = new Size(220, 25);
            cmbKomoditas.TabIndex = 11;
            // 
            // lblEstimasiBerat
            // 
            lblEstimasiBerat.AutoSize = true;
            lblEstimasiBerat.Font = new Font("Segoe UI", 9.5F);
            lblEstimasiBerat.ForeColor = Color.FromArgb(33, 37, 41);
            lblEstimasiBerat.Location = new Point(20, 287);
            lblEstimasiBerat.Name = "lblEstimasiBerat";
            lblEstimasiBerat.Size = new Size(126, 17);
            lblEstimasiBerat.TabIndex = 12;
            lblEstimasiBerat.Text = "Berat Dokumen (kg):";
            // 
            // txtEstimasiBerat
            // 
            txtEstimasiBerat.Font = new Font("Segoe UI", 10F);
            txtEstimasiBerat.Location = new Point(165, 284);
            txtEstimasiBerat.Name = "txtEstimasiBerat";
            txtEstimasiBerat.Size = new Size(220, 25);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 67, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAntreanSJ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAntreanSJ.ColumnHeadersHeight = 42;
            dgvAntreanSJ.Columns.AddRange(new DataGridViewColumn[] { colNoSJ, colTanggal, colSupplier, colDriver, colKomoditas, colEstimasi, colStatus });
            dgvAntreanSJ.EnableHeadersVisualStyles = false;
            dgvAntreanSJ.Font = new Font("Segoe UI", 9F);
            dgvAntreanSJ.Location = new Point(450, 28);
            dgvAntreanSJ.Name = "dgvAntreanSJ";
            dgvAntreanSJ.ReadOnly = true;
            dgvAntreanSJ.RowHeadersVisible = false;
            dgvAntreanSJ.RowHeadersWidth = 51;
            dgvAntreanSJ.RowTemplate.Height = 34;
            dgvAntreanSJ.Size = new Size(770, 487);
            dgvAntreanSJ.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // colTanggal
            // 
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 6;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            // 
            // colDriver
            // 
            colDriver.HeaderText = "Driver";
            colDriver.MinimumWidth = 6;
            colDriver.Name = "colDriver";
            colDriver.ReadOnly = true;
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
            ClientSize = new Size(1240, 535);
            Controls.Add(gbRegistrasiSJ);
            Controls.Add(dgvAntreanSJ);
            Name = "FormInputPenerimaan";
            Text = "TimbangCrop - Input Penerimaan Surat Jalan";
            gbRegistrasiSJ.ResumeLayout(false);
            gbRegistrasiSJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAntreanSJ).EndInit();
            ResumeLayout(false);
        }

        private void MuatAntrean()
        {
            dgvAntreanSJ.Rows.Clear();
            foreach (DataRow r in PenimbanganDAO.GetAntreanPenerimaan().Rows)
            {
                dgvAntreanSJ.Rows.Add(
                   r["no_surat_jalan"],
                   Convert.ToDateTime(r["tanggal"]).ToString("dd/MM/yyyy"),
                   r["asal_lahan"],
                   r["nama_driver"],
                   r["nama_komoditas"],
                   $"{Convert.ToDouble(r["berat_surat_jalan"]):F2} kg",
                   r["status"]);
            }
        }

        private void btnSimpanSJ_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoSJ.Text) || string.IsNullOrWhiteSpace(txtSupplier.Text) || string.IsNullOrWhiteSpace(txtDriver.Text) || cmbKomoditas.SelectedIndex < 0)
            {
                MessageBox.Show("No. Surat Jalan, Nama Supir, dan Komoditas wajib diisi!", "Validasi Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string teksBerat = txtEstimasiBerat.Text.Trim().Replace(',', '.');
            if (!double.TryParse(teksBerat, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double beratSJ) || beratSJ <= 0)
            {
                MessageBox.Show("Berat Dokumen harus berupa angka lebih dari 0!", "Validasi Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var penerimaan = new PenerimaanBarang
                {
                    IdPenerimaan = "PNR-" + Guid.NewGuid().ToString("N").Substring(0, 12).ToUpper(),
                    NoSuratJalan = txtNoSJ.Text.Trim(),
                    NamaDriver = txtDriver.Text.Trim(),
                    AsalLahan = txtSupplier.Text.Trim(),
                    IdKomoditas = cmbKomoditas.SelectedValue?.ToString() ?? "",
                    BeratSuratJalan = beratSJ,
                    Tanggal = dtpTanggal.Value
                };

                PenimbanganDAO.SimpanPenerimaan(penerimaan);
                MuatAntrean();

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
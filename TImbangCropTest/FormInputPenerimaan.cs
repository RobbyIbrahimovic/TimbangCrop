using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimbangCropTest
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
            dgvAntreanSJ.Rows.Add("SJ/MTR/2026-089", "Kelompok Tani Makmur", "Edamame Segar", "650.00 kg", "MENUNGGU");
            dgvAntreanSJ.Rows.Add("SJ/MTR/2026-090", "Kebun Mitra Silo", "Okra Hijau", "420.00 kg", "MENUNGGU");
        }

        private void InitializeComponent()
        {
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
            gbRegistrasiSJ.Text = " Registrasi Surat Jalan Masuk ";

            lblNoSJ.AutoSize = true;
            lblNoSJ.Font = new Font("Segoe UI", 9.5F);
            lblNoSJ.ForeColor = Color.FromArgb(33, 37, 41);
            lblNoSJ.Location = new Point(20, 40);
            lblNoSJ.Name = "lblNoSJ";
            lblNoSJ.Text = "No. Surat Jalan:";

            txtNoSJ.Font = new Font("Segoe UI", 10F);
            txtNoSJ.Location = new Point(165, 36);
            txtNoSJ.Name = "txtNoSJ";
            txtNoSJ.Size = new Size(220, 25);
            txtNoSJ.Text = "SJ/MTR/2026-091";

            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Segoe UI", 9.5F);
            lblTanggal.ForeColor = Color.FromArgb(33, 37, 41);
            lblTanggal.Location = new Point(20, 88);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Text = "Tanggal Masuk:";

            dtpTanggal.Font = new Font("Segoe UI", 9.5F);
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(165, 84);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(220, 24);

            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 9.5F);
            lblSupplier.ForeColor = Color.FromArgb(33, 37, 41);
            lblSupplier.Location = new Point(20, 136);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Text = "Asal Lahan / Petani:";

            txtSupplier.Font = new Font("Segoe UI", 10F);
            txtSupplier.Location = new Point(165, 132);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(220, 25);
            txtSupplier.Text = "KT Tani Jaya Jember";

            lblNopol.AutoSize = true;
            lblNopol.Font = new Font("Segoe UI", 9.5F);
            lblNopol.ForeColor = Color.FromArgb(33, 37, 41);
            lblNopol.Location = new Point(20, 184);
            lblNopol.Name = "lblNopol";
            lblNopol.Text = "No. Polisi Armada:";

            txtNopol.Font = new Font("Segoe UI", 10F);
            txtNopol.Location = new Point(165, 180);
            txtNopol.Name = "txtNopol";
            txtNopol.Size = new Size(220, 25);
            txtNopol.Text = "P 8412 QK";

            lblDriver.AutoSize = true;
            lblDriver.Font = new Font("Segoe UI", 9.5F);
            lblDriver.ForeColor = Color.FromArgb(33, 37, 41);
            lblDriver.Location = new Point(20, 232);
            lblDriver.Name = "lblDriver";
            lblDriver.Text = "Nama Supir:";

            txtDriver.Font = new Font("Segoe UI", 10F);
            txtDriver.Location = new Point(165, 228);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(220, 25);
            txtDriver.Text = "Hendra Wijaya";

            lblKomoditas.AutoSize = true;
            lblKomoditas.Font = new Font("Segoe UI", 9.5F);
            lblKomoditas.ForeColor = Color.FromArgb(33, 37, 41);
            lblKomoditas.Location = new Point(20, 280);
            lblKomoditas.Name = "lblKomoditas";
            lblKomoditas.Text = "Komoditas:";

            cmbKomoditas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKomoditas.Font = new Font("Segoe UI", 10F);
            cmbKomoditas.Items.AddRange(new object[] { "Edamame Segar", "Okra Hijau", "Okra Merah" });
            cmbKomoditas.Location = new Point(165, 276);
            cmbKomoditas.Name = "cmbKomoditas";
            cmbKomoditas.Size = new Size(220, 25);

            lblEstimasiBerat.AutoSize = true;
            lblEstimasiBerat.Font = new Font("Segoe UI", 9.5F);
            lblEstimasiBerat.ForeColor = Color.FromArgb(33, 37, 41);
            lblEstimasiBerat.Location = new Point(20, 328);
            lblEstimasiBerat.Name = "lblEstimasiBerat";
            lblEstimasiBerat.Text = "Berat Dokumen (kg):";

            txtEstimasiBerat.Font = new Font("Segoe UI", 10F);
            txtEstimasiBerat.Location = new Point(165, 324);
            txtEstimasiBerat.Name = "txtEstimasiBerat";
            txtEstimasiBerat.Size = new Size(220, 25);
            txtEstimasiBerat.Text = "550";

            btnSimpanSJ.BackColor = Color.FromArgb(45, 106, 79);
            btnSimpanSJ.FlatAppearance.BorderSize = 0;
            btnSimpanSJ.FlatStyle = FlatStyle.Flat;
            btnSimpanSJ.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSimpanSJ.ForeColor = Color.White;
            btnSimpanSJ.Location = new Point(20, 415);
            btnSimpanSJ.Name = "btnSimpanSJ";
            btnSimpanSJ.Size = new Size(365, 45);
            btnSimpanSJ.Text = "DAFTARKAN KE ANTREAN TIMBANG";

            dgvAntreanSJ.AllowUserToAddRows = false;
            dgvAntreanSJ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAntreanSJ.BackgroundColor = Color.White;
            dgvAntreanSJ.BorderStyle = BorderStyle.None;
            dgvAntreanSJ.ColumnHeadersHeight = 42;
            dgvAntreanSJ.Columns.AddRange(new DataGridViewColumn[] { colNoSJ, colSupplier, colKomoditas, colEstimasi, colStatus });
            dgvAntreanSJ.EnableHeadersVisualStyles = false;
            dgvAntreanSJ.Font = new Font("Segoe UI", 9F);
            dgvAntreanSJ.Location = new Point(450, 28);
            dgvAntreanSJ.Name = "dgvAntreanSJ";
            dgvAntreanSJ.ReadOnly = true;
            dgvAntreanSJ.RowHeadersVisible = false;
            dgvAntreanSJ.RowTemplate.Height = 34;
            dgvAntreanSJ.Size = new Size(490, 487);

            dgvAntreanSJ.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 67, 50);
            dgvAntreanSJ.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAntreanSJ.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            colNoSJ.HeaderText = "No. SJ";
            colNoSJ.Name = "colNoSJ";
            colSupplier.HeaderText = "Asal Lahan";
            colSupplier.Name = "colSupplier";
            colKomoditas.HeaderText = "Komoditas";
            colKomoditas.Name = "colKomoditas";
            colEstimasi.HeaderText = "Berat SJ";
            colEstimasi.Name = "colEstimasi";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";

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
    }
}
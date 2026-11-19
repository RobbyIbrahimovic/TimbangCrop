using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimbangCropTest
{
    public class FormPenimbangan : Form
    {
        private GroupBox gbSuratJalan;
        private Label lblNoSJ;
        private TextBox txtNoSJ;
        private Label lblDriver;
        private TextBox txtDriver;
        private Label lblKomoditas;
        private ComboBox cmbKomoditas;
        private Label lblBeratSJ;
        private TextBox txtBeratSJ;
        private GroupBox gbTimbangFisik;
        private Label lblGross;
        private TextBox txtGross;
        private Label lblTara;
        private TextBox txtTara;
        private Panel pnlResultCard;
        private Label lblNettoTitle;
        private Label lblNettoValue;
        private Panel pnlAlertIndicator;
        private Label lblAlertStatus;
        private Label lblAlertDetail;
        private Button btnSimpan;

        public FormPenimbangan()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            gbSuratJalan = new GroupBox();
            lblNoSJ = new Label();
            txtNoSJ = new TextBox();
            lblDriver = new Label();
            txtDriver = new TextBox();
            lblKomoditas = new Label();
            cmbKomoditas = new ComboBox();
            lblBeratSJ = new Label();
            txtBeratSJ = new TextBox();
            gbTimbangFisik = new GroupBox();
            lblGross = new Label();
            txtGross = new TextBox();
            lblTara = new Label();
            txtTara = new TextBox();
            pnlResultCard = new Panel();
            lblNettoTitle = new Label();
            lblNettoValue = new Label();
            pnlAlertIndicator = new Panel();
            lblAlertStatus = new Label();
            lblAlertDetail = new Label();
            btnSimpan = new Button();
            gbSuratJalan.SuspendLayout();
            gbTimbangFisik.SuspendLayout();
            pnlResultCard.SuspendLayout();
            pnlAlertIndicator.SuspendLayout();
            SuspendLayout();
            // 
            // gbSuratJalan
            // 
            gbSuratJalan.BackColor = Color.White;
            gbSuratJalan.Controls.Add(lblNoSJ);
            gbSuratJalan.Controls.Add(txtNoSJ);
            gbSuratJalan.Controls.Add(lblDriver);
            gbSuratJalan.Controls.Add(txtDriver);
            gbSuratJalan.Controls.Add(lblKomoditas);
            gbSuratJalan.Controls.Add(cmbKomoditas);
            gbSuratJalan.Controls.Add(lblBeratSJ);
            gbSuratJalan.Controls.Add(txtBeratSJ);
            gbSuratJalan.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            gbSuratJalan.ForeColor = Color.FromArgb(27, 67, 50);
            gbSuratJalan.Location = new Point(20, 20);
            gbSuratJalan.Name = "gbSuratJalan";
            gbSuratJalan.Size = new Size(440, 260);
            gbSuratJalan.TabIndex = 0;
            gbSuratJalan.TabStop = false;
            gbSuratJalan.Text = " 1. Data Surat Jalan dan Komoditas ";
            // 
            // lblNoSJ
            // 
            lblNoSJ.AutoSize = true;
            lblNoSJ.Font = new Font("Segoe UI", 9.5F);
            lblNoSJ.ForeColor = Color.FromArgb(33, 37, 41);
            lblNoSJ.Location = new Point(20, 42);
            lblNoSJ.Name = "lblNoSJ";
            lblNoSJ.Size = new Size(117, 21);
            lblNoSJ.TabIndex = 0;
            lblNoSJ.Text = "No. Surat Jalan:";
            // 
            // txtNoSJ
            // 
            txtNoSJ.Font = new Font("Segoe UI", 10.5F);
            txtNoSJ.Location = new Point(190, 38);
            txtNoSJ.Name = "txtNoSJ";
            txtNoSJ.Size = new Size(225, 31);
            txtNoSJ.TabIndex = 1;
            txtNoSJ.Text = "SJ/MTR/2026-088";
            // 
            // lblDriver
            // 
            lblDriver.AutoSize = true;
            lblDriver.Font = new Font("Segoe UI", 9.5F);
            lblDriver.ForeColor = Color.FromArgb(33, 37, 41);
            lblDriver.Location = new Point(20, 92);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(102, 21);
            lblDriver.TabIndex = 2;
            lblDriver.Text = "Nama Driver:";
            // 
            // txtDriver
            // 
            txtDriver.Font = new Font("Segoe UI", 10.5F);
            txtDriver.Location = new Point(190, 88);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(225, 31);
            txtDriver.TabIndex = 3;
            txtDriver.Text = "Ahmad Fauzi";
            // 
            // lblKomoditas
            // 
            lblKomoditas.AutoSize = true;
            lblKomoditas.Font = new Font("Segoe UI", 9.5F);
            lblKomoditas.ForeColor = Color.FromArgb(33, 37, 41);
            lblKomoditas.Location = new Point(20, 142);
            lblKomoditas.Name = "lblKomoditas";
            lblKomoditas.Size = new Size(87, 21);
            lblKomoditas.TabIndex = 4;
            lblKomoditas.Text = "Komoditas:";
            // 
            // cmbKomoditas
            // 
            cmbKomoditas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKomoditas.Font = new Font("Segoe UI", 10F);
            cmbKomoditas.Items.AddRange(new object[] { "Edamame Segar (Tol. 2%)", "Okra Hijau (Tol. 2.5%)", "Okra Merah (Tol. 3%)" });
            cmbKomoditas.Location = new Point(190, 138);
            cmbKomoditas.Name = "cmbKomoditas";
            cmbKomoditas.Size = new Size(225, 31);
            cmbKomoditas.TabIndex = 5;
            // 
            // lblBeratSJ
            // 
            lblBeratSJ.AutoSize = true;
            lblBeratSJ.Font = new Font("Segoe UI", 9.5F);
            lblBeratSJ.ForeColor = Color.FromArgb(33, 37, 41);
            lblBeratSJ.Location = new Point(20, 192);
            lblBeratSJ.Name = "lblBeratSJ";
            lblBeratSJ.Size = new Size(160, 21);
            lblBeratSJ.TabIndex = 6;
            lblBeratSJ.Text = "Berat Surat Jalan (kg):";
            // 
            // txtBeratSJ
            // 
            txtBeratSJ.Font = new Font("Segoe UI", 10.5F);
            txtBeratSJ.Location = new Point(190, 188);
            txtBeratSJ.Name = "txtBeratSJ";
            txtBeratSJ.Size = new Size(225, 31);
            txtBeratSJ.TabIndex = 7;
            txtBeratSJ.Text = "500";
            // 
            // gbTimbangFisik
            // 
            gbTimbangFisik.BackColor = Color.White;
            gbTimbangFisik.Controls.Add(lblGross);
            gbTimbangFisik.Controls.Add(txtGross);
            gbTimbangFisik.Controls.Add(lblTara);
            gbTimbangFisik.Controls.Add(txtTara);
            gbTimbangFisik.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            gbTimbangFisik.ForeColor = Color.FromArgb(27, 67, 50);
            gbTimbangFisik.Location = new Point(20, 295);
            gbTimbangFisik.Name = "gbTimbangFisik";
            gbTimbangFisik.Size = new Size(440, 175);
            gbTimbangFisik.TabIndex = 1;
            gbTimbangFisik.TabStop = false;
            gbTimbangFisik.Text = " 2. Input Penimbangan Fisik Aktual ";
            // 
            // lblGross
            // 
            lblGross.AutoSize = true;
            lblGross.Font = new Font("Segoe UI", 9.5F);
            lblGross.ForeColor = Color.FromArgb(33, 37, 41);
            lblGross.Location = new Point(20, 46);
            lblGross.Name = "lblGross";
            lblGross.Size = new Size(176, 21);
            lblGross.TabIndex = 0;
            lblGross.Text = "Berat Kotor / Gross (kg):";
            // 
            // txtGross
            // 
            txtGross.Font = new Font("Segoe UI", 10.5F);
            txtGross.Location = new Point(190, 42);
            txtGross.Name = "txtGross";
            txtGross.Size = new Size(225, 31);
            txtGross.TabIndex = 1;
            txtGross.Text = "525";
            txtGross.TextChanged += txtGross_TextChanged;
            // 
            // lblTara
            // 
            lblTara.AutoSize = true;
            lblTara.Font = new Font("Segoe UI", 9.5F);
            lblTara.ForeColor = Color.FromArgb(33, 37, 41);
            lblTara.Location = new Point(20, 102);
            lblTara.Name = "lblTara";
            lblTara.Size = new Size(196, 21);
            lblTara.TabIndex = 2;
            lblTara.Text = "Berat Tara / Keranjang (kg):";
            // 
            // txtTara
            // 
            txtTara.Font = new Font("Segoe UI", 10.5F);
            txtTara.Location = new Point(190, 98);
            txtTara.Name = "txtTara";
            txtTara.Size = new Size(225, 31);
            txtTara.TabIndex = 3;
            txtTara.Text = "30";
            // 
            // pnlResultCard
            // 
            pnlResultCard.BackColor = Color.White;
            pnlResultCard.Controls.Add(lblNettoTitle);
            pnlResultCard.Controls.Add(lblNettoValue);
            pnlResultCard.Location = new Point(480, 28);
            pnlResultCard.Name = "pnlResultCard";
            pnlResultCard.Size = new Size(410, 180);
            pnlResultCard.TabIndex = 2;
            // 
            // lblNettoTitle
            // 
            lblNettoTitle.AutoSize = true;
            lblNettoTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNettoTitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblNettoTitle.Location = new Point(20, 20);
            lblNettoTitle.Name = "lblNettoTitle";
            lblNettoTitle.Size = new Size(299, 21);
            lblNettoTitle.TabIndex = 0;
            lblNettoTitle.Text = "BERAT NETTO AKTUAL (GROSS - TARA)";
            // 
            // lblNettoValue
            // 
            lblNettoValue.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            lblNettoValue.ForeColor = Color.FromArgb(27, 67, 50);
            lblNettoValue.Location = new Point(18, 55);
            lblNettoValue.Name = "lblNettoValue";
            lblNettoValue.Size = new Size(370, 75);
            lblNettoValue.TabIndex = 1;
            lblNettoValue.Text = "495.00 kg";
            // 
            // pnlAlertIndicator
            // 
            pnlAlertIndicator.BackColor = Color.FromArgb(216, 243, 220);
            pnlAlertIndicator.Controls.Add(lblAlertStatus);
            pnlAlertIndicator.Controls.Add(lblAlertDetail);
            pnlAlertIndicator.Location = new Point(480, 225);
            pnlAlertIndicator.Name = "pnlAlertIndicator";
            pnlAlertIndicator.Size = new Size(410, 165);
            pnlAlertIndicator.TabIndex = 3;
            // 
            // lblAlertStatus
            // 
            lblAlertStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAlertStatus.ForeColor = Color.FromArgb(42, 157, 143);
            lblAlertStatus.Location = new Point(20, 20);
            lblAlertStatus.Name = "lblAlertStatus";
            lblAlertStatus.Size = new Size(370, 30);
            lblAlertStatus.TabIndex = 0;
            lblAlertStatus.Text = "STATUS: AMAN (DALAM TOLERANSI)";
            // 
            // lblAlertDetail
            // 
            lblAlertDetail.Font = new Font("Segoe UI", 10F);
            lblAlertDetail.ForeColor = Color.FromArgb(33, 37, 41);
            lblAlertDetail.Location = new Point(20, 60);
            lblAlertDetail.Name = "lblAlertDetail";
            lblAlertDetail.Size = new Size(370, 80);
            lblAlertDetail.TabIndex = 1;
            lblAlertDetail.Text = "Selisih Berat: -5.00 kg (Deviasi: 1.00%)\r\nBatas Toleransi Edamame: ±2.0%\r\nData valid dan siap masuk ke stok gudang.";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(45, 106, 79);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(480, 412);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(410, 55);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "SIMPAN LOG PENIMBANGAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // FormPenimbangan
            // 
            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(920, 510);
            Controls.Add(gbSuratJalan);
            Controls.Add(gbTimbangFisik);
            Controls.Add(pnlResultCard);
            Controls.Add(pnlAlertIndicator);
            Controls.Add(btnSimpan);
            Name = "FormPenimbangan";
            Text = "TimbangCrop - Penimbangan & Validasi";
            Load += FormPenimbangan_Load;
            gbSuratJalan.ResumeLayout(false);
            gbSuratJalan.PerformLayout();
            gbTimbangFisik.ResumeLayout(false);
            gbTimbangFisik.PerformLayout();
            pnlResultCard.ResumeLayout(false);
            pnlResultCard.PerformLayout();
            pnlAlertIndicator.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

        private void FormPenimbangan_Load(object sender, EventArgs e)
        {

        }

        private void txtGross_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
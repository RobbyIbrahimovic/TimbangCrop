using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimbangCropTest
{
    public class FormRekapLaporan : Form
    {
        private Panel pnlCardTotalNetto = null!;
        private Label lblTitleNetto = null!;
        private Label lblValNetto = null!;
        private Panel pnlCardTotalSJ = null!;
        private Label lblTitleSJ = null!;
        private Label lblValSJ = null!;
        private Panel pnlCardAnomali = null!;
        private Label lblTitleAnomali = null!;
        private Label lblValAnomali = null!;
        private DataGridView dgvRekapKomoditas = null!;
        private DataGridViewTextBoxColumn colKomoditas = null!;
        private DataGridViewTextBoxColumn colJumlahSJ = null!;
        private DataGridViewTextBoxColumn colTotalDokumen = null!;
        private DataGridViewTextBoxColumn colTotalNetto = null!;
        private DataGridViewTextBoxColumn colTotalSusut = null!;
        private Button btnExportCSV = null!;
        private Button btnCetakPDF = null!;

        public FormRekapLaporan()
        {
            InitializeComponent();
            dgvRekapKomoditas.Rows.Add("Edamame Segar (Export Grade)", "14 Trip", "7,000.00 kg", "6,895.00 kg", "-105.00 kg (1.50%)");
            dgvRekapKomoditas.Rows.Add("Okra Hijau", "9 Trip", "3,600.00 kg", "3,528.00 kg", "-72.00 kg (2.00%)");
            dgvRekapKomoditas.Rows.Add("Okra Merah", "4 Trip", "1,200.00 kg", "1,176.00 kg", "-24.00 kg (2.00%)");
        }

        private void InitializeComponent()
        {
            pnlCardTotalNetto = new Panel();
            lblTitleNetto = new Label();
            lblValNetto = new Label();
            pnlCardTotalSJ = new Panel();
            lblTitleSJ = new Label();
            lblValSJ = new Label();
            pnlCardAnomali = new Panel();
            lblTitleAnomali = new Label();
            lblValAnomali = new Label();
            dgvRekapKomoditas = new DataGridView();
            colKomoditas = new DataGridViewTextBoxColumn();
            colJumlahSJ = new DataGridViewTextBoxColumn();
            colTotalDokumen = new DataGridViewTextBoxColumn();
            colTotalNetto = new DataGridViewTextBoxColumn();
            colTotalSusut = new DataGridViewTextBoxColumn();
            btnExportCSV = new Button();
            btnCetakPDF = new Button();
            pnlCardTotalNetto.SuspendLayout();
            pnlCardTotalSJ.SuspendLayout();
            pnlCardAnomali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRekapKomoditas).BeginInit();
            SuspendLayout();

            pnlCardTotalNetto.BackColor = Color.White;
            pnlCardTotalNetto.Controls.Add(lblTitleNetto);
            pnlCardTotalNetto.Controls.Add(lblValNetto);
            pnlCardTotalNetto.Location = new Point(20, 20);
            pnlCardTotalNetto.Name = "pnlCardTotalNetto";
            pnlCardTotalNetto.Size = new Size(295, 115);

            lblTitleNetto.AutoSize = true;
            lblTitleNetto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitleNetto.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitleNetto.Location = new Point(18, 16);
            lblTitleNetto.Name = "lblTitleNetto";
            lblTitleNetto.Text = "TOTAL PENERIMAAN NETTO";

            lblValNetto.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblValNetto.ForeColor = Color.FromArgb(27, 67, 50);
            lblValNetto.Location = new Point(16, 48);
            lblValNetto.Name = "lblValNetto";
            lblValNetto.Size = new Size(265, 45);
            lblValNetto.Text = "11,599.00 kg";

            pnlCardTotalSJ.BackColor = Color.White;
            pnlCardTotalSJ.Controls.Add(lblTitleSJ);
            pnlCardTotalSJ.Controls.Add(lblValSJ);
            pnlCardTotalSJ.Location = new Point(332, 20);
            pnlCardTotalSJ.Name = "pnlCardTotalSJ";
            pnlCardTotalSJ.Size = new Size(295, 115);

            lblTitleSJ.AutoSize = true;
            lblTitleSJ.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitleSJ.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitleSJ.Location = new Point(18, 16);
            lblTitleSJ.Name = "lblTitleSJ";
            lblTitleSJ.Text = "TOTAL ARMADA / SURAT JALAN";

            lblValSJ.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblValSJ.ForeColor = Color.FromArgb(45, 106, 79);
            lblValSJ.Location = new Point(16, 48);
            lblValSJ.Name = "lblValSJ";
            lblValSJ.Size = new Size(265, 45);
            lblValSJ.Text = "27 Trip Masuk";

            pnlCardAnomali.BackColor = Color.White;
            pnlCardAnomali.Controls.Add(lblTitleAnomali);
            pnlCardAnomali.Controls.Add(lblValAnomali);
            pnlCardAnomali.Location = new Point(645, 20);
            pnlCardAnomali.Name = "pnlCardAnomali";
            pnlCardAnomali.Size = new Size(295, 115);

            lblTitleAnomali.AutoSize = true;
            lblTitleAnomali.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitleAnomali.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitleAnomali.Location = new Point(18, 16);
            lblTitleAnomali.Name = "lblTitleAnomali";
            lblTitleAnomali.Text = "TRANSAKSI ANOMALI TERTAHAN";

            lblValAnomali.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblValAnomali.ForeColor = Color.FromArgb(214, 40, 40);
            lblValAnomali.Location = new Point(16, 48);
            lblValAnomali.Name = "lblValAnomali";
            lblValAnomali.Size = new Size(265, 45);
            lblValAnomali.Text = "2 Transaksi";

            dgvRekapKomoditas.AllowUserToAddRows = false;
            dgvRekapKomoditas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRekapKomoditas.BackgroundColor = Color.White;
            dgvRekapKomoditas.BorderStyle = BorderStyle.None;
            dgvRekapKomoditas.ColumnHeadersHeight = 44;
            dgvRekapKomoditas.Columns.AddRange(new DataGridViewColumn[] { colKomoditas, colJumlahSJ, colTotalDokumen, colTotalNetto, colTotalSusut });
            dgvRekapKomoditas.EnableHeadersVisualStyles = false;
            dgvRekapKomoditas.Font = new Font("Segoe UI", 9.5F);
            dgvRekapKomoditas.Location = new Point(20, 155);
            dgvRekapKomoditas.Name = "dgvRekapKomoditas";
            dgvRekapKomoditas.ReadOnly = true;
            dgvRekapKomoditas.RowHeadersVisible = false;
            dgvRekapKomoditas.RowTemplate.Height = 38;
            dgvRekapKomoditas.Size = new Size(920, 295);

            dgvRekapKomoditas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 67, 50);
            dgvRekapKomoditas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRekapKomoditas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            colKomoditas.FillWeight = 140F;
            colKomoditas.HeaderText = "Komoditas";
            colKomoditas.Name = "colKomoditas";
            colJumlahSJ.FillWeight = 80F;
            colJumlahSJ.HeaderText = "Jumlah Trip";
            colJumlahSJ.Name = "colJumlahSJ";
            colTotalDokumen.FillWeight = 100F;
            colTotalDokumen.HeaderText = "Total Berat SJ";
            colTotalDokumen.Name = "colTotalDokumen";
            colTotalNetto.FillWeight = 100F;
            colTotalNetto.HeaderText = "Total Berat Netto";
            colTotalNetto.Name = "colTotalNetto";
            colTotalSusut.FillWeight = 120F;
            colTotalSusut.HeaderText = "Akumulasi Susut";
            colTotalSusut.Name = "colTotalSusut";

            btnExportCSV.BackColor = Color.FromArgb(45, 106, 79);
            btnExportCSV.FlatAppearance.BorderSize = 0;
            btnExportCSV.FlatStyle = FlatStyle.Flat;
            btnExportCSV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportCSV.ForeColor = Color.White;
            btnExportCSV.Location = new Point(510, 470);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(205, 42);
            btnExportCSV.Text = "EXPORT REKAP (.CSV)";

            btnCetakPDF.BackColor = Color.FromArgb(27, 67, 50);
            btnCetakPDF.FlatAppearance.BorderSize = 0;
            btnCetakPDF.FlatStyle = FlatStyle.Flat;
            btnCetakPDF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCetakPDF.ForeColor = Color.White;
            btnCetakPDF.Location = new Point(735, 470);
            btnCetakPDF.Name = "btnCetakPDF";
            btnCetakPDF.Size = new Size(205, 42);
            btnCetakPDF.Text = "CETAK BERITA ACARA";

            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(960, 535);
            Controls.Add(pnlCardTotalNetto);
            Controls.Add(pnlCardTotalSJ);
            Controls.Add(pnlCardAnomali);
            Controls.Add(dgvRekapKomoditas);
            Controls.Add(btnExportCSV);
            Controls.Add(btnCetakPDF);
            Name = "FormRekapLaporan";
            Text = "TimbangCrop - Rekapitulasi Laporan Panen";
            pnlCardTotalNetto.ResumeLayout(false);
            pnlCardTotalNetto.PerformLayout();
            pnlCardTotalSJ.ResumeLayout(false);
            pnlCardTotalSJ.PerformLayout();
            pnlCardAnomali.ResumeLayout(false);
            pnlCardAnomali.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRekapKomoditas).EndInit();
            ResumeLayout(false);
        }
    }
}
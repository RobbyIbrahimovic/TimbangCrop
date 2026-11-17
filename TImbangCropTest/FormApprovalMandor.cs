using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimbangCropTest
{
    public class FormApprovalMandor : Form
    {
        private DataGridView dgvAnomali;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colKomoditas;
        private DataGridViewTextBoxColumn colSelisih;
        private DataGridViewTextBoxColumn colDeviasi;
        private DataGridViewTextBoxColumn colStatus;
        private Panel pnlAction;
        private Label lblSelectedInfo;
        private Label lblCatatan;
        private TextBox txtCatatanMandor;
        private Button btnApprove;
        private Button btnReject;

        public FormApprovalMandor()
        {
            InitializeComponent();

            // Baris data dummy agar tabel langsung terlihat berisi saat dijalankan
            dgvAnomali.Rows.Add("TRX-20261115-001", "15/11/2026 14:30", "Edamame Segar", "-25.00 kg", "5.00%", "ANOMALI");
            dgvAnomali.Rows.Add("TRX-20261115-002", "15/11/2026 15:15", "Okra Hijau", "-15.00 kg", "5.00%", "ANOMALI");
        }

        private void InitializeComponent()
        {
            dgvAnomali = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colKomoditas = new DataGridViewTextBoxColumn();
            colSelisih = new DataGridViewTextBoxColumn();
            colDeviasi = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlAction = new Panel();
            lblSelectedInfo = new Label();
            lblCatatan = new Label();
            txtCatatanMandor = new TextBox();
            btnApprove = new Button();
            btnReject = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnomali).BeginInit();
            pnlAction.SuspendLayout();
            SuspendLayout();

            // dgvAnomali
            dgvAnomali.AllowUserToAddRows = false;
            dgvAnomali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnomali.BackgroundColor = Color.White;
            dgvAnomali.BorderStyle = BorderStyle.None;
            dgvAnomali.ColumnHeadersHeight = 46;
            dgvAnomali.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAnomali.Columns.AddRange(new DataGridViewColumn[] { colId, colTanggal, colKomoditas, colSelisih, colDeviasi, colStatus });
            dgvAnomali.EnableHeadersVisualStyles = false;
            dgvAnomali.Font = new Font("Segoe UI", 9.5F);
            dgvAnomali.Location = new Point(20, 20);
            dgvAnomali.Name = "dgvAnomali";
            dgvAnomali.ReadOnly = true;
            dgvAnomali.RowHeadersVisible = false;
            dgvAnomali.RowTemplate.Height = 36;
            dgvAnomali.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnomali.Size = new Size(920, 295);

            dgvAnomali.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 67, 50);
            dgvAnomali.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAnomali.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvAnomali.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            // Pengaturan Proporsi Lebar Kolom (FillWeight) agar header 1 baris penuh
            colId.HeaderText = "ID Transaksi";
            colId.Name = "colId";
            colId.FillWeight = 115F;

            colTanggal.HeaderText = "Tanggal";
            colTanggal.Name = "colTanggal";
            colTanggal.FillWeight = 105F;

            colKomoditas.HeaderText = "Komoditas";
            colKomoditas.Name = "colKomoditas";
            colKomoditas.FillWeight = 115F;

            colSelisih.HeaderText = "Selisih (kg)";
            colSelisih.Name = "colSelisih";
            colSelisih.FillWeight = 85F;

            colDeviasi.HeaderText = "Persentase Deviasi (%)";
            colDeviasi.Name = "colDeviasi";
            colDeviasi.FillWeight = 145F;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 75F;

            // pnlAction
            pnlAction.BackColor = Color.White;
            pnlAction.Controls.Add(lblSelectedInfo);
            pnlAction.Controls.Add(lblCatatan);
            pnlAction.Controls.Add(txtCatatanMandor);
            pnlAction.Controls.Add(btnApprove);
            pnlAction.Controls.Add(btnReject);
            pnlAction.Location = new Point(20, 330);
            pnlAction.Name = "pnlAction";
            pnlAction.Size = new Size(920, 185);

            lblSelectedInfo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblSelectedInfo.ForeColor = Color.FromArgb(27, 67, 50);
            lblSelectedInfo.Location = new Point(20, 15);
            lblSelectedInfo.Name = "lblSelectedInfo";
            lblSelectedInfo.Size = new Size(880, 25);
            lblSelectedInfo.Text = "Meninjau: TRX-20261115-001 | Edamame Segar (Deviasi: 5.00%)";

            lblCatatan.AutoSize = true;
            lblCatatan.Font = new Font("Segoe UI", 9.5F);
            lblCatatan.ForeColor = Color.FromArgb(33, 37, 41);
            lblCatatan.Location = new Point(20, 50);
            lblCatatan.Name = "lblCatatan";
            lblCatatan.Text = "Catatan / Alasan Keputusan Mandor:";

            txtCatatanMandor.Font = new Font("Segoe UI", 10F);
            txtCatatanMandor.Location = new Point(20, 75);
            txtCatatanMandor.Multiline = true;
            txtCatatanMandor.Name = "txtCatatanMandor";
            txtCatatanMandor.Size = new Size(510, 82);

            btnApprove.BackColor = Color.FromArgb(42, 157, 143);
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(550, 75);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(345, 37);
            btnApprove.Text = "APPROVE TRANSAKSI";

            btnReject.BackColor = Color.FromArgb(214, 40, 40);
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(550, 120);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(345, 37);
            btnReject.Text = "REJECT / MINTA TIMBANG ULANG";

            // FormApprovalMandor
            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(960, 535);
            Controls.Add(dgvAnomali);
            Controls.Add(pnlAction);
            Name = "FormApprovalMandor";
            Text = "TimbangCrop - Review & Approval Mandor";
            ((System.ComponentModel.ISupportInitialize)dgvAnomali).EndInit();
            pnlAction.ResumeLayout(false);
            pnlAction.PerformLayout();
            ResumeLayout(false);
        }
    }
}
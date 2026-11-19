using System;
using System.Drawing;
using System.Windows.Forms;
using TimbangCrop.Controllers;

namespace TimbangCrop.Views
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

            dgvAnomali.Rows.Add("TRX-20261115-001", "15/11/2026 14:30", "Edamame Segar", "-25.00 kg", "5.00%", "ANOMALI");
            dgvAnomali.Rows.Add("TRX-20261115-002", "15/11/2026 15:15", "Okra Hijau", "-15.00 kg", "5.00%", "ANOMALI");
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            // 
            // dgvAnomali
            // 
            dgvAnomali.AllowUserToAddRows = false;
            dgvAnomali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnomali.BackgroundColor = Color.White;
            dgvAnomali.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(27, 67, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvAnomali.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAnomali.ColumnHeadersHeight = 46;
            dgvAnomali.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAnomali.Columns.AddRange(new DataGridViewColumn[] { colId, colTanggal, colKomoditas, colSelisih, colDeviasi, colStatus });
            dgvAnomali.EnableHeadersVisualStyles = false;
            dgvAnomali.Font = new Font("Segoe UI", 9.5F);
            dgvAnomali.Location = new Point(20, 20);
            dgvAnomali.Name = "dgvAnomali";
            dgvAnomali.ReadOnly = true;
            dgvAnomali.RowHeadersVisible = false;
            dgvAnomali.RowHeadersWidth = 51;
            dgvAnomali.RowTemplate.Height = 36;
            dgvAnomali.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnomali.Size = new Size(920, 295);
            dgvAnomali.TabIndex = 0;
            dgvAnomali.CellClick += dgvAnomali_CellClick;
            dgvAnomali.CellContentClick += dgvAnomali_CellContentClick;
            // 
            // colId
            // 
            colId.FillWeight = 115F;
            colId.HeaderText = "ID Transaksi";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colTanggal
            // 
            colTanggal.FillWeight = 105F;
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 6;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            // 
            // colKomoditas
            // 
            colKomoditas.FillWeight = 115F;
            colKomoditas.HeaderText = "Komoditas";
            colKomoditas.MinimumWidth = 6;
            colKomoditas.Name = "colKomoditas";
            colKomoditas.ReadOnly = true;
            // 
            // colSelisih
            // 
            colSelisih.FillWeight = 85F;
            colSelisih.HeaderText = "Selisih (kg)";
            colSelisih.MinimumWidth = 6;
            colSelisih.Name = "colSelisih";
            colSelisih.ReadOnly = true;
            // 
            // colDeviasi
            // 
            colDeviasi.FillWeight = 145F;
            colDeviasi.HeaderText = "Persentase Deviasi (%)";
            colDeviasi.MinimumWidth = 6;
            colDeviasi.Name = "colDeviasi";
            colDeviasi.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 75F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // pnlAction
            // 
            pnlAction.BackColor = Color.White;
            pnlAction.Controls.Add(lblSelectedInfo);
            pnlAction.Controls.Add(lblCatatan);
            pnlAction.Controls.Add(txtCatatanMandor);
            pnlAction.Controls.Add(btnApprove);
            pnlAction.Controls.Add(btnReject);
            pnlAction.Location = new Point(20, 330);
            pnlAction.Name = "pnlAction";
            pnlAction.Size = new Size(920, 185);
            pnlAction.TabIndex = 1;
            // 
            // lblSelectedInfo
            // 
            lblSelectedInfo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblSelectedInfo.ForeColor = Color.FromArgb(27, 67, 50);
            lblSelectedInfo.Location = new Point(20, 15);
            lblSelectedInfo.Name = "lblSelectedInfo";
            lblSelectedInfo.Size = new Size(880, 25);
            lblSelectedInfo.TabIndex = 0;
            lblSelectedInfo.Text = "Meninjau: TRX-20261115-001 | Edamame Segar (Deviasi: 5.00%)";
            // 
            // lblCatatan
            // 
            lblCatatan.AutoSize = true;
            lblCatatan.Font = new Font("Segoe UI", 9.5F);
            lblCatatan.ForeColor = Color.FromArgb(33, 37, 41);
            lblCatatan.Location = new Point(20, 50);
            lblCatatan.Name = "lblCatatan";
            lblCatatan.Size = new Size(262, 21);
            lblCatatan.TabIndex = 1;
            lblCatatan.Text = "Catatan / Alasan Keputusan Mandor:";
            // 
            // txtCatatanMandor
            // 
            txtCatatanMandor.Font = new Font("Segoe UI", 10F);
            txtCatatanMandor.Location = new Point(20, 75);
            txtCatatanMandor.Multiline = true;
            txtCatatanMandor.Name = "txtCatatanMandor";
            txtCatatanMandor.Size = new Size(510, 82);
            txtCatatanMandor.TabIndex = 2;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(42, 157, 143);
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(550, 75);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(345, 37);
            btnApprove.TabIndex = 3;
            btnApprove.Text = "APPROVE TRANSAKSI";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(214, 40, 40);
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(550, 120);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(345, 37);
            btnReject.TabIndex = 4;
            btnReject.Text = "REJECT / MINTA TIMBANG ULANG";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // FormApprovalMandor
            // 
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

        private void dgvAnomali_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvAnomali.Rows[e.RowIndex];
                lblSelectedInfo.Text = $"Meninjau: {row.Cells["colId"].Value} | {row.Cells["colKomoditas"].Value} (Deviasi: {row.Cells["colDeviasi"].Value})";
            }
        }

        private void ProsesKeputusan(string statusBaru)
        {
            if (dgvAnomali.CurrentRow == null)
            {
                MessageBox.Show("Pilih baris transaksi terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idTrx = dgvAnomali.CurrentRow.Cells["colId"].Value?.ToString() ?? "";
            string catatan = string.IsNullOrWhiteSpace(txtCatatanMandor.Text) ? "-" : txtCatatanMandor.Text.Trim();

            dgvAnomali.CurrentRow.Cells["colStatus"].Value = statusBaru;
            txtCatatanMandor.Clear();

            MessageBox.Show($"Transaksi {idTrx} telah diubah menjadi {statusBaru}.\nCatatan: {catatan}",
                "Keputusan Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            ProsesKeputusan("APPROVED");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            ProsesKeputusan("REJECTED");
        }

        private void dgvAnomali_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
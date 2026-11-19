using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TimbangCrop.Data;

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
            pnlFilter.Location = new Point(20, 20);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(920, 75);
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
            dgvRiwayat.Location = new Point(20, 110);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowHeadersWidth = 51;
            dgvRiwayat.RowTemplate.Height = 35;
            dgvRiwayat.Size = new Size(920, 405);
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
            dgvRiwayat.Rows.Clear();
            dgvRiwayat.Rows.Add("TRX-001", "15/11/2026 08:15", "SJ/MTR/1101", "Edamame Segar", "495.00 kg", "1.00%", "AMAN");
            dgvRiwayat.Rows.Add("TRX-002", "15/11/2026 09:40", "SJ/MTR/1104", "Edamame Segar", "475.00 kg", "5.00%", "ANOMALI");
            dgvRiwayat.Rows.Add("TRX-003", "15/11/2026 11:05", "SJ/MTR/1107", "Okra Hijau", "318.50 kg", "0.47%", "AMAN");

            try
            {
                DataTable dt = PenimbanganDAO.GetRiwayatLog();
                foreach (DataRow row in dt.Rows)
                {
                    string idTmb = row["id_timbangan"]?.ToString() ?? "-";
                    string waktu = Convert.ToDateTime(row["timestamp"]).ToString("dd/MM/yyyy HH:mm");
                    string status = row["status"]?.ToString() ?? "-";
                    string detail = row["pesan_detail"]?.ToString() ?? "-";

                    dgvRiwayat.Rows.Insert(0, idTmb, waktu, detail, "Hasil Timbang DB", "-", "-", status);
                }
            }
            catch
            {
                // nampilin data awal kalo DB belum ada transaksi
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string filterStatus = cmbFilterStatus.SelectedItem?.ToString() ?? "Semua Status";
            string keyword = txtCari.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvRiwayat.Rows)
            {
                string rowStatus = row.Cells["colStatus"].Value?.ToString() ?? "";
                string rowText = $"{row.Cells["colId"].Value} {row.Cells["colNoSJ"].Value} {row.Cells["colKomoditas"].Value}".ToLower();

                bool matchStatus = filterStatus == "Semua Status" || rowStatus.Equals(filterStatus, StringComparison.OrdinalIgnoreCase);
                bool matchKeyword = string.IsNullOrEmpty(keyword) || rowText.Contains(keyword);

                row.Visible = matchStatus && matchKeyword;
            }
        }

        private void dgvRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
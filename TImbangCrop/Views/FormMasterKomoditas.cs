using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimbangCrop.Views
{
    public class FormMasterKomoditas : Form
    {
        private GroupBox gbFormKomoditas = null!;
        private Label lblKode = null!;
        private TextBox txtKode = null!;
        private Label lblNama = null!;
        private TextBox txtNama = null!;
        private Label lblToleransi = null!;
        private TextBox txtToleransi = null!;
        private Label lblKeterangan = null!;
        private TextBox txtKeterangan = null!;
        private Button btnTambah = null!;
        private Button btnUpdate = null!;
        private Button btnHapus = null!;
        private DataGridView dgvKomoditas = null!;
        private DataGridViewTextBoxColumn colKode = null!;
        private DataGridViewTextBoxColumn colNama = null!;
        private DataGridViewTextBoxColumn colToleransi = null!;
        private DataGridViewTextBoxColumn colKet = null!;

        public FormMasterKomoditas()
        {
            InitializeComponent();
            dgvKomoditas.Rows.Add("KMD-01", "Edamame Segar (Export Grade)", "2.0%", "Kualitas ekspor beku, susut maksimal 2%");
            dgvKomoditas.Rows.Add("KMD-02", "Okra Hijau", "2.5%", "Sortir grade A/B, toleransi susut 2.5%");
            dgvKomoditas.Rows.Add("KMD-03", "Okra Merah", "3.0%", "Komoditas musiman, toleransi susut 3%");
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gbFormKomoditas = new GroupBox();
            lblKode = new Label();
            txtKode = new TextBox();
            lblNama = new Label();
            txtNama = new TextBox();
            lblToleransi = new Label();
            txtToleransi = new TextBox();
            lblKeterangan = new Label();
            txtKeterangan = new TextBox();
            btnTambah = new Button();
            btnUpdate = new Button();
            btnHapus = new Button();
            dgvKomoditas = new DataGridView();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colToleransi = new DataGridViewTextBoxColumn();
            colKet = new DataGridViewTextBoxColumn();
            gbFormKomoditas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKomoditas).BeginInit();
            SuspendLayout();
            // 
            // gbFormKomoditas
            // 
            gbFormKomoditas.BackColor = Color.White;
            gbFormKomoditas.Controls.Add(lblKode);
            gbFormKomoditas.Controls.Add(txtKode);
            gbFormKomoditas.Controls.Add(lblNama);
            gbFormKomoditas.Controls.Add(txtNama);
            gbFormKomoditas.Controls.Add(lblToleransi);
            gbFormKomoditas.Controls.Add(txtToleransi);
            gbFormKomoditas.Controls.Add(lblKeterangan);
            gbFormKomoditas.Controls.Add(txtKeterangan);
            gbFormKomoditas.Controls.Add(btnTambah);
            gbFormKomoditas.Controls.Add(btnUpdate);
            gbFormKomoditas.Controls.Add(btnHapus);
            gbFormKomoditas.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            gbFormKomoditas.ForeColor = Color.FromArgb(27, 67, 50);
            gbFormKomoditas.Location = new Point(20, 20);
            gbFormKomoditas.Name = "gbFormKomoditas";
            gbFormKomoditas.Size = new Size(360, 495);
            gbFormKomoditas.TabIndex = 0;
            gbFormKomoditas.TabStop = false;
            gbFormKomoditas.Text = " Kelola Komoditas & Toleransi ";
            // 
            // lblKode
            // 
            lblKode.AutoSize = true;
            lblKode.Font = new Font("Segoe UI", 9.5F);
            lblKode.ForeColor = Color.FromArgb(33, 37, 41);
            lblKode.Location = new Point(20, 40);
            lblKode.Name = "lblKode";
            lblKode.Size = new Size(126, 21);
            lblKode.TabIndex = 0;
            lblKode.Text = "Kode Komoditas:";
            // 
            // txtKode
            // 
            txtKode.Font = new Font("Segoe UI", 10F);
            txtKode.Location = new Point(20, 64);
            txtKode.Name = "txtKode";
            txtKode.Size = new Size(320, 30);
            txtKode.TabIndex = 1;
            txtKode.Text = "KMD-04";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9.5F);
            lblNama.ForeColor = Color.FromArgb(33, 37, 41);
            lblNama.Location = new Point(20, 105);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(133, 21);
            lblNama.TabIndex = 2;
            lblNama.Text = "Nama Komoditas:";
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Segoe UI", 10F);
            txtNama.Location = new Point(20, 129);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(320, 30);
            txtNama.TabIndex = 3;
            txtNama.Text = "Buncis Kenya";
            // 
            // lblToleransi
            // 
            lblToleransi.AutoSize = true;
            lblToleransi.Font = new Font("Segoe UI", 9.5F);
            lblToleransi.ForeColor = Color.FromArgb(33, 37, 41);
            lblToleransi.Location = new Point(20, 170);
            lblToleransi.Name = "lblToleransi";
            lblToleransi.Size = new Size(185, 21);
            lblToleransi.TabIndex = 4;
            lblToleransi.Text = "Batas Toleransi Susut (%):";
            // 
            // txtToleransi
            // 
            txtToleransi.Font = new Font("Segoe UI", 10F);
            txtToleransi.Location = new Point(20, 194);
            txtToleransi.Name = "txtToleransi";
            txtToleransi.Size = new Size(320, 30);
            txtToleransi.TabIndex = 5;
            txtToleransi.Text = "2.5";
            // 
            // lblKeterangan
            // 
            lblKeterangan.AutoSize = true;
            lblKeterangan.Font = new Font("Segoe UI", 9.5F);
            lblKeterangan.ForeColor = Color.FromArgb(33, 37, 41);
            lblKeterangan.Location = new Point(20, 235);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(200, 21);
            lblKeterangan.TabIndex = 6;
            lblKeterangan.Text = "Standar Mutu / Keterangan:";
            // 
            // txtKeterangan
            // 
            txtKeterangan.Font = new Font("Segoe UI", 10F);
            txtKeterangan.Location = new Point(20, 259);
            txtKeterangan.Multiline = true;
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(320, 75);
            txtKeterangan.TabIndex = 7;
            txtKeterangan.Text = "Sortir segar harian pabrik";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(45, 106, 79);
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(20, 355);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(320, 38);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "+ TAMBAH KOMODITAS BARU";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(42, 157, 143);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(20, 402);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(155, 38);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "SIMPAN UBAH";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(214, 40, 40);
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(185, 402);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(155, 38);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "HAPUS";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // dgvKomoditas
            // 
            dgvKomoditas.AllowUserToAddRows = false;
            dgvKomoditas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKomoditas.BackgroundColor = Color.White;
            dgvKomoditas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(27, 67, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKomoditas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKomoditas.ColumnHeadersHeight = 44;
            dgvKomoditas.Columns.AddRange(new DataGridViewColumn[] { colKode, colNama, colToleransi, colKet });
            dgvKomoditas.EnableHeadersVisualStyles = false;
            dgvKomoditas.Font = new Font("Segoe UI", 9.5F);
            dgvKomoditas.Location = new Point(400, 28);
            dgvKomoditas.Name = "dgvKomoditas";
            dgvKomoditas.ReadOnly = true;
            dgvKomoditas.RowHeadersVisible = false;
            dgvKomoditas.RowHeadersWidth = 51;
            dgvKomoditas.RowTemplate.Height = 36;
            dgvKomoditas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKomoditas.Size = new Size(540, 487);
            dgvKomoditas.TabIndex = 1;
            dgvKomoditas.CellClick += dgvKomoditas_CellClick;
            dgvKomoditas.CellContentClick += dgvKomoditas_CellContentClick;
            // 
            // colKode
            // 
            colKode.FillWeight = 70F;
            colKode.HeaderText = "ID";
            colKode.MinimumWidth = 6;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 140F;
            colNama.HeaderText = "Nama Komoditas";
            colNama.MinimumWidth = 6;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colToleransi
            // 
            colToleransi.FillWeight = 75F;
            colToleransi.HeaderText = "Toleransi";
            colToleransi.MinimumWidth = 6;
            colToleransi.Name = "colToleransi";
            colToleransi.ReadOnly = true;
            // 
            // colKet
            // 
            colKet.FillWeight = 150F;
            colKet.HeaderText = "Keterangan";
            colKet.MinimumWidth = 6;
            colKet.Name = "colKet";
            colKet.ReadOnly = true;
            // 
            // FormMasterKomoditas
            // 
            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(960, 535);
            Controls.Add(gbFormKomoditas);
            Controls.Add(dgvKomoditas);
            Name = "FormMasterKomoditas";
            Text = "TimbangCrop - Master Data Komoditas";
            gbFormKomoditas.ResumeLayout(false);
            gbFormKomoditas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKomoditas).EndInit();
            ResumeLayout(false);
        }

        private void dgvKomoditas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvKomoditas.Rows[e.RowIndex];
                txtKode.Text = row.Cells["colKode"].Value?.ToString() ?? "";
                txtNama.Text = row.Cells["colNama"].Value?.ToString() ?? "";
                txtToleransi.Text = (row.Cells["colToleransi"].Value?.ToString() ?? "").Replace("%", "");
                txtKeterangan.Text = row.Cells["colKet"].Value?.ToString() ?? "";
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            dgvKomoditas.Rows.Add(txtKode.Text.Trim(), txtNama.Text.Trim(), txtToleransi.Text.Trim() + "%", txtKeterangan.Text.Trim());
            MessageBox.Show("Komoditas baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvKomoditas.CurrentRow != null)
            {
                dgvKomoditas.CurrentRow.Cells["colKode"].Value = txtKode.Text.Trim();
                dgvKomoditas.CurrentRow.Cells["colNama"].Value = txtNama.Text.Trim();
                dgvKomoditas.CurrentRow.Cells["colToleransi"].Value = txtToleransi.Text.Trim() + "%";
                dgvKomoditas.CurrentRow.Cells["colKet"].Value = txtKeterangan.Text.Trim();
                MessageBox.Show("Data komoditas diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKomoditas.CurrentRow != null)
            {
                dgvKomoditas.Rows.Remove(dgvKomoditas.CurrentRow);
                MessageBox.Show("Komoditas dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvKomoditas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
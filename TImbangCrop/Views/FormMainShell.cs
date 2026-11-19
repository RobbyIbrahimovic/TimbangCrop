using System;
using System.Drawing;
using System.Windows.Forms;
using TimbangCrop.Models;

namespace TimbangCrop.Views
{
    public class FormMainShell : Form
    {
        private Panel pnlSidebar;
        private Label lblBrand;
        private Panel pnlProfile;
        private Label lblUserName;
        private Label lblUserRole;
        private Button btnMenuPenerimaan;
        private Button btnMenuPenimbangan;
        private Button btnMenuRiwayat;
        private Label lblDividerMandor;
        private Button btnMenuMasterKomoditas;
        private Button btnMenuApproval;
        private Button btnMenuRekap;
        private Button btnLogout;
        private Panel pnlTopBar;
        private Label lblPageTitle;
        private Panel pnlMain;
        private Label lblPlaceholder;

        private Form _activeForm;

        public FormMainShell()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            lblBrand = new Label();
            pnlProfile = new Panel();
            lblUserName = new Label();
            lblUserRole = new Label();
            btnMenuPenerimaan = new Button();
            btnMenuPenimbangan = new Button();
            btnMenuRiwayat = new Button();
            lblDividerMandor = new Label();
            btnMenuMasterKomoditas = new Button();
            btnMenuApproval = new Button();
            btnMenuRekap = new Button();
            btnLogout = new Button();
            pnlTopBar = new Panel();
            lblPageTitle = new Label();
            pnlMain = new Panel();
            lblPlaceholder = new Label();
            pnlSidebar.SuspendLayout();
            pnlProfile.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(27, 67, 50);
            pnlSidebar.Controls.Add(lblBrand);
            pnlSidebar.Controls.Add(pnlProfile);
            pnlSidebar.Controls.Add(btnMenuPenerimaan);
            pnlSidebar.Controls.Add(btnMenuPenimbangan);
            pnlSidebar.Controls.Add(btnMenuRiwayat);
            pnlSidebar.Controls.Add(lblDividerMandor);
            pnlSidebar.Controls.Add(btnMenuMasterKomoditas);
            pnlSidebar.Controls.Add(btnMenuApproval);
            pnlSidebar.Controls.Add(btnMenuRekap);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(260, 711);
            pnlSidebar.TabIndex = 2;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(10, 15);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(240, 45);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "TimbangCrop";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.FromArgb(20, 52, 39);
            pnlProfile.Controls.Add(lblUserName);
            pnlProfile.Controls.Add(lblUserRole);
            pnlProfile.Location = new Point(12, 70);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(236, 65);
            pnlProfile.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(12, 10);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(210, 22);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User: Budi Santoso";
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblUserRole.ForeColor = Color.FromArgb(149, 213, 178);
            lblUserRole.Location = new Point(12, 34);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(210, 20);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = "Role: MANDOR GUDANG";
            // 
            // btnMenuPenerimaan
            // 
            btnMenuPenerimaan.BackColor = Color.FromArgb(27, 67, 50);
            btnMenuPenerimaan.FlatAppearance.BorderSize = 0;
            btnMenuPenerimaan.FlatStyle = FlatStyle.Flat;
            btnMenuPenerimaan.Font = new Font("Segoe UI", 10F);
            btnMenuPenerimaan.ForeColor = Color.White;
            btnMenuPenerimaan.Location = new Point(12, 155);
            btnMenuPenerimaan.Name = "btnMenuPenerimaan";
            btnMenuPenerimaan.Padding = new Padding(10, 0, 0, 0);
            btnMenuPenerimaan.Size = new Size(236, 42);
            btnMenuPenerimaan.TabIndex = 2;
            btnMenuPenerimaan.Text = "Input Penerimaan SJ";
            btnMenuPenerimaan.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPenerimaan.UseVisualStyleBackColor = false;
            btnMenuPenerimaan.Click += btnMenuPenerimaan_Click;
            // 
            // btnMenuPenimbangan
            // 
            btnMenuPenimbangan.BackColor = Color.FromArgb(45, 106, 79);
            btnMenuPenimbangan.FlatAppearance.BorderSize = 0;
            btnMenuPenimbangan.FlatStyle = FlatStyle.Flat;
            btnMenuPenimbangan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuPenimbangan.ForeColor = Color.White;
            btnMenuPenimbangan.Location = new Point(12, 202);
            btnMenuPenimbangan.Name = "btnMenuPenimbangan";
            btnMenuPenimbangan.Padding = new Padding(10, 0, 0, 0);
            btnMenuPenimbangan.Size = new Size(236, 42);
            btnMenuPenimbangan.TabIndex = 3;
            btnMenuPenimbangan.Text = "Penimbangan / Validasi";
            btnMenuPenimbangan.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPenimbangan.UseVisualStyleBackColor = false;
            btnMenuPenimbangan.Click += btnMenuPenimbangan_Click;
            // 
            // btnMenuRiwayat
            // 
            btnMenuRiwayat.BackColor = Color.FromArgb(27, 67, 50);
            btnMenuRiwayat.FlatAppearance.BorderSize = 0;
            btnMenuRiwayat.FlatStyle = FlatStyle.Flat;
            btnMenuRiwayat.Font = new Font("Segoe UI", 10F);
            btnMenuRiwayat.ForeColor = Color.White;
            btnMenuRiwayat.Location = new Point(12, 249);
            btnMenuRiwayat.Name = "btnMenuRiwayat";
            btnMenuRiwayat.Padding = new Padding(10, 0, 0, 0);
            btnMenuRiwayat.Size = new Size(236, 42);
            btnMenuRiwayat.TabIndex = 4;
            btnMenuRiwayat.Text = "Riwayat Log Timbang";
            btnMenuRiwayat.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuRiwayat.UseVisualStyleBackColor = false;
            btnMenuRiwayat.Click += btnMenuRiwayat_Click;
            // 
            // lblDividerMandor
            // 
            lblDividerMandor.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDividerMandor.ForeColor = Color.FromArgb(149, 213, 178);
            lblDividerMandor.Location = new Point(15, 310);
            lblDividerMandor.Name = "lblDividerMandor";
            lblDividerMandor.Size = new Size(230, 22);
            lblDividerMandor.TabIndex = 5;
            lblDividerMandor.Text = "MENU KHUSUS MANDOR";
            // 
            // btnMenuMasterKomoditas
            // 
            btnMenuMasterKomoditas.BackColor = Color.FromArgb(27, 67, 50);
            btnMenuMasterKomoditas.FlatAppearance.BorderSize = 0;
            btnMenuMasterKomoditas.FlatStyle = FlatStyle.Flat;
            btnMenuMasterKomoditas.Font = new Font("Segoe UI", 10F);
            btnMenuMasterKomoditas.ForeColor = Color.White;
            btnMenuMasterKomoditas.Location = new Point(12, 337);
            btnMenuMasterKomoditas.Name = "btnMenuMasterKomoditas";
            btnMenuMasterKomoditas.Padding = new Padding(10, 0, 0, 0);
            btnMenuMasterKomoditas.Size = new Size(236, 42);
            btnMenuMasterKomoditas.TabIndex = 6;
            btnMenuMasterKomoditas.Text = "Master Data Komoditas";
            btnMenuMasterKomoditas.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuMasterKomoditas.UseVisualStyleBackColor = false;
            btnMenuMasterKomoditas.Click += btnMenuMasterKomoditas_Click;
            // 
            // btnMenuApproval
            // 
            btnMenuApproval.BackColor = Color.FromArgb(27, 67, 50);
            btnMenuApproval.FlatAppearance.BorderSize = 0;
            btnMenuApproval.FlatStyle = FlatStyle.Flat;
            btnMenuApproval.Font = new Font("Segoe UI", 10F);
            btnMenuApproval.ForeColor = Color.White;
            btnMenuApproval.Location = new Point(12, 384);
            btnMenuApproval.Name = "btnMenuApproval";
            btnMenuApproval.Padding = new Padding(10, 0, 0, 0);
            btnMenuApproval.Size = new Size(236, 42);
            btnMenuApproval.TabIndex = 7;
            btnMenuApproval.Text = "Approval Anomali";
            btnMenuApproval.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuApproval.UseVisualStyleBackColor = false;
            btnMenuApproval.Click += btnMenuApproval_Click;
            // 
            // btnMenuRekap
            // 
            btnMenuRekap.BackColor = Color.FromArgb(27, 67, 50);
            btnMenuRekap.FlatAppearance.BorderSize = 0;
            btnMenuRekap.FlatStyle = FlatStyle.Flat;
            btnMenuRekap.Font = new Font("Segoe UI", 10F);
            btnMenuRekap.ForeColor = Color.White;
            btnMenuRekap.Location = new Point(12, 431);
            btnMenuRekap.Name = "btnMenuRekap";
            btnMenuRekap.Padding = new Padding(10, 0, 0, 0);
            btnMenuRekap.Size = new Size(236, 42);
            btnMenuRekap.TabIndex = 8;
            btnMenuRekap.Text = "Rekap Laporan Panen";
            btnMenuRekap.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuRekap.UseVisualStyleBackColor = false;
            btnMenuRekap.Click += btnMenuRekap_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(155, 34, 38);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 645);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(236, 42);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Keluar / Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(lblPageTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(260, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(924, 60);
            pnlTopBar.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblPageTitle.Location = new Point(25, 15);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(600, 30);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard Operasional TimbangCrop";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(244, 247, 245);
            pnlMain.Controls.Add(lblPlaceholder);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(260, 60);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(924, 651);
            pnlMain.TabIndex = 0;
            // 
            // lblPlaceholder
            // 
            lblPlaceholder.BorderStyle = BorderStyle.FixedSingle;
            lblPlaceholder.Font = new Font("Segoe UI", 12F);
            lblPlaceholder.ForeColor = Color.FromArgb(108, 117, 125);
            lblPlaceholder.Location = new Point(30, 30);
            lblPlaceholder.Name = "lblPlaceholder";
            lblPlaceholder.Size = new Size(860, 580);
            lblPlaceholder.TabIndex = 0;
            lblPlaceholder.Text = "[ AREA MAIN PANEL ]";
            lblPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            lblPlaceholder.Click += lblPlaceholder_Click;
            // 
            // FormMainShell
            // 
            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(1184, 711);
            Controls.Add(pnlMain);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            Name = "FormMainShell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TimbangCrop - Dashboard Utama";
            Load += FormMainShell_Load;
            pnlSidebar.ResumeLayout(false);
            pnlProfile.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void FormMainShell_Load(object sender, EventArgs e)
        {
            User activeUser = AppCore.CurrentUser ?? new Mandor("USR-002", "Bima Mandor", "mandor1", "123");

            lblUserName.Text = "User: " + activeUser.Nama;
            lblUserRole.Text = "Role: " + (activeUser is Mandor ? "MANDOR" : "PEKERJA");

            bool aksesMandor = activeUser.CanAccessModule("Approval");
            lblDividerMandor.Visible = aksesMandor;
            btnMenuMasterKomoditas.Visible = aksesMandor;
            btnMenuApproval.Visible = aksesMandor;
            btnMenuRekap.Visible = aksesMandor;

            OpenChildForm(new FormPenimbangan(), btnMenuPenimbangan, "Penimbangan & Validasi");
        }

        private void SetActiveMenu(Button activeButton)
        {
            Button[] menus = {
                btnMenuPenerimaan,
                btnMenuPenimbangan,
                btnMenuRiwayat,
                btnMenuMasterKomoditas,
                btnMenuApproval,
                btnMenuRekap
            };

            foreach (var btn in menus)
            {
                btn.BackColor = Color.FromArgb(27, 67, 50);
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }

            activeButton.BackColor = Color.FromArgb(45, 106, 79);
            activeButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void OpenChildForm(Form childForm, Button activeButton, string title)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            SetActiveMenu(activeButton);
            lblPageTitle.Text = title;

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnMenuPenerimaan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInputPenerimaan(), btnMenuPenerimaan, "Input Penerimaan Surat Jalan");
        }

        private void btnMenuPenimbangan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPenimbangan(), btnMenuPenimbangan, "Penimbangan & Validasi");
        }

        private void btnMenuRiwayat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRiwayatLog(), btnMenuRiwayat, "Riwayat Log Penimbangan");
        }

        private void btnMenuMasterKomoditas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMasterKomoditas(), btnMenuMasterKomoditas, "Master Data Komoditas");
        }

        private void btnMenuApproval_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormApprovalMandor(), btnMenuApproval, "Approval Anomali");
        }

        private void btnMenuRekap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRekapLaporan(), btnMenuRekap, "Rekapitulasi Laporan Panen");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AppCore.CurrentUser = null;
            this.Close();
        }

        private void lblPlaceholder_Click(object sender, EventArgs e)
        {
        }
    }
}
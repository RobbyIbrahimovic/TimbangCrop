using System;
using System.Drawing;
using System.Windows.Forms;
using TimbangCrop.Data;
using TimbangCrop.Models;

namespace TimbangCrop.Views
{
    public class FormLogin : Form
    {
        private Panel pnlCard;
        private Label lblLogo;
        private Label lblSubtitle;
        private Label lblUser;
        private TextBox txtUsername;
        private Label lblPass;
        private TextBox txtPassword;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblError;
        private Button btnLogin;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pnlCard = new Panel();
            lblLogo = new Label();
            lblSubtitle = new Label();
            lblUser = new Label();
            txtUsername = new TextBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblError = new Label();
            btnLogin = new Button();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblLogo);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblUser);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblPass);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(lblRole);
            pnlCard.Controls.Add(cmbRole);
            pnlCard.Controls.Add(lblError);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Location = new Point(242, 60);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(400, 440);
            pnlCard.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(27, 67, 50);
            lblLogo.Location = new Point(30, 30);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(340, 45);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "TimbangCrop";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitle.Location = new Point(30, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(340, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sistem Penerimaan dan Penimbangan Panen";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUser.Location = new Point(35, 120);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(87, 21);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(35, 143);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(330, 32);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "pekerja1";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPass.Location = new Point(35, 185);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(82, 21);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(35, 208);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(330, 32);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "123";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRole.Location = new Point(35, 250);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(101, 21);
            lblRole.TabIndex = 6;
            lblRole.Text = "Peran Akses";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10.5F);
            cmbRole.Items.AddRange(new object[] { "Pekerja", "Mandor" });
            cmbRole.Location = new Point(35, 273);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(330, 31);
            cmbRole.TabIndex = 7;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblError.ForeColor = Color.FromArgb(214, 40, 40);
            lblError.Location = new Point(35, 312);
            lblError.Name = "lblError";
            lblError.Size = new Size(330, 25);
            lblError.TabIndex = 8;
            lblError.Text = "* Pilih peran lalu klik Masuk";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(45, 106, 79);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(35, 348);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 42);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "MASUK KE SISTEM";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            BackColor = Color.FromArgb(27, 67, 50);
            ClientSize = new Size(884, 561);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TimbangCrop - Login Sistem Agroindustri";
            Load += FormLogin_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string selectedRole = cmbRole.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "* Username dan Password wajib diisi!";
                return;
            }

            if (string.IsNullOrEmpty(selectedRole))
            {
                lblError.Text = "* Pilih peran terlebih dahulu!";
                return;
            }

            try
            {
                User loggedInUser = UserDAO.Autentikasi(username, password);

                if (loggedInUser == null)
                {
                    lblError.Text = "* Username atau Password salah!";
                    return;
                }

                string actualRole = loggedInUser is Mandor ? "Mandor" : "Pekerja";
                if (!actualRole.Equals(selectedRole, StringComparison.OrdinalIgnoreCase))
                {
                    lblError.Text = $"* Akun ini terdaftar sebagai {actualRole}, bukan {selectedRole}!";
                    return;
                }

                AppCore.CurrentUser = loggedInUser;

                FormMainShell mainShell = new FormMainShell();
                mainShell.FormClosed += (s, args) => this.Show();
                this.Hide();
                mainShell.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database PostgreSQL:\n" + ex.Message,
                    "Error Koneksi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {
        }
    }
}
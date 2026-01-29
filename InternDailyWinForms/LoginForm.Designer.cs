namespace InternDailyWinForms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label3 = new Label();
            btnLogin = new Button();
            rbSupervisor = new RadioButton();
            rbIntern = new RadioButton();
            password = new Label();
            userName = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lnkRegister = new LinkLabel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(143, 26);
            label3.Name = "label3";
            label3.Size = new Size(540, 48);
            label3.TabIndex = 13;
            label3.Text = "Staj Takip Ekranına Hoşgeldiniz!";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnLogin.Location = new Point(337, 287);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(136, 40);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // rbSupervisor
            // 
            rbSupervisor.AutoSize = true;
            rbSupervisor.Location = new Point(353, 221);
            rbSupervisor.Name = "rbSupervisor";
            rbSupervisor.Size = new Size(104, 19);
            rbSupervisor.TabIndex = 14;
            rbSupervisor.TabStop = true;
            rbSupervisor.Text = "Staj Sorumlusu";
            rbSupervisor.UseVisualStyleBackColor = true;
            // 
            // rbIntern
            // 
            rbIntern.AutoSize = true;
            rbIntern.Location = new Point(353, 246);
            rbIntern.Name = "rbIntern";
            rbIntern.Size = new Size(60, 19);
            rbIntern.TabIndex = 15;
            rbIntern.TabStop = true;
            rbIntern.Text = "Stajyer";
            rbIntern.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold | FontStyle.Italic);
            password.Location = new Point(250, 170);
            password.Name = "password";
            password.Size = new Size(53, 21);
            password.TabIndex = 17;
            password.Text = "Şifre:";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold | FontStyle.Italic);
            userName.Location = new Point(191, 122);
            userName.Name = "userName";
            userName.Size = new Size(112, 21);
            userName.TabIndex = 16;
            userName.Text = "Kullanıcı Adı:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 19;
            textBox2.UseSystemPasswordChar = true;
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(340, 347);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(137, 15);
            lnkRegister.TabIndex = 20;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Hesabın yok mu? Kaydol";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lnkRegister);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(rbIntern);
            Controls.Add(rbSupervisor);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnLogin;
        private RadioButton rbSupervisor;
        private RadioButton rbIntern;
        private Label password;
        private Label userName;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel lnkRegister;
    }
}

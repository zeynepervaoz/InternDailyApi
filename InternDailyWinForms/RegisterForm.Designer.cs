namespace InternDailyWinForms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            password = new Label();
            userName = new Label();
            rbIntern = new RadioButton();
            rbSupervisor = new RadioButton();
            label3 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(311, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 23);
            txtPassword.TabIndex = 28;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(311, 153);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(189, 23);
            txtUserName.TabIndex = 27;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            password.Location = new Point(237, 201);
            password.Name = "password";
            password.Size = new Size(53, 21);
            password.TabIndex = 26;
            password.Text = "Şifre:";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            userName.Location = new Point(178, 153);
            userName.Name = "userName";
            userName.Size = new Size(112, 21);
            userName.TabIndex = 25;
            userName.Text = "Kullanıcı Adı:";
            // 
            // rbIntern
            // 
            rbIntern.AutoSize = true;
            rbIntern.Location = new Point(340, 277);
            rbIntern.Name = "rbIntern";
            rbIntern.Size = new Size(60, 19);
            rbIntern.TabIndex = 24;
            rbIntern.TabStop = true;
            rbIntern.Text = "Stajyer";
            rbIntern.UseVisualStyleBackColor = true;
            // 
            // rbSupervisor
            // 
            rbSupervisor.AutoSize = true;
            rbSupervisor.Location = new Point(340, 252);
            rbSupervisor.Name = "rbSupervisor";
            rbSupervisor.Size = new Size(104, 19);
            rbSupervisor.TabIndex = 23;
            rbSupervisor.TabStop = true;
            rbSupervisor.Text = "Staj Sorumlusu";
            rbSupervisor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 53);
            label3.Name = "label3";
            label3.Size = new Size(578, 48);
            label3.TabIndex = 22;
            label3.Text = "Staj Takip Ekranına Sen de Kaydol!";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRegister.Location = new Point(324, 318);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(136, 40);
            btnRegister.TabIndex = 21;
            btnRegister.Text = "Kaydol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(rbIntern);
            Controls.Add(rbSupervisor);
            Controls.Add(label3);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label password;
        private Label userName;
        private RadioButton rbIntern;
        private RadioButton rbSupervisor;
        private Label label3;
        private Button btnRegister;
    }
}
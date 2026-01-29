namespace InternDailyWinForms
{
    partial class Form2
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
            lblWelcome = new Label();
            btnGet = new Button();
            listBoxDailyInfos = new ListBox();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(253, 23);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 48);
            lblWelcome.TabIndex = 13;
            // 
            // btnGet
            // 
            btnGet.BackColor = SystemColors.InactiveBorder;
            btnGet.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGet.Location = new Point(12, 233);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(166, 40);
            btnGet.TabIndex = 10;
            btnGet.Text = "Günlük Bilgileri Getir";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // listBoxDailyInfos
            // 
            listBoxDailyInfos.BackColor = SystemColors.InactiveBorder;
            listBoxDailyInfos.FormattingEnabled = true;
            listBoxDailyInfos.ItemHeight = 15;
            listBoxDailyInfos.Location = new Point(253, 123);
            listBoxDailyInfos.Name = "listBoxDailyInfos";
            listBoxDailyInfos.Size = new Size(473, 289);
            listBoxDailyInfos.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnGet);
            panel1.Location = new Point(22, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 289);
            panel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(160, 112);
            label2.TabIndex = 12;
            label2.Text = "Bu ekranda,\r\nsize ait günlük \r\nbilgiler\r\nlistelenmektedir.\r\nLütfen görevle-\r\nrinizin takibini\r\nyapınız.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(8, 12);
            label3.Name = "label3";
            label3.Size = new Size(178, 34);
            label3.TabIndex = 16;
            label3.Text = "Stajyer Ekranı";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listBoxDailyInfos);
            Controls.Add(lblWelcome);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnGet;
        private ListBox listBoxDailyInfos;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
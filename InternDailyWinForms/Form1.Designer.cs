namespace InternDailyWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            rtbDescription = new RichTextBox();
            btnAdd = new Button();
            cmbIntern = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 83);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 1;
            label1.Text = "Stajyer Seç:";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(213, 107);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(425, 210);
            rtbDescription.TabIndex = 3;
            rtbDescription.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(341, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Günlük Bilgi Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            // 
            // cmbIntern
            // 
            cmbIntern.FormattingEnabled = true;
            cmbIntern.Location = new Point(45, 107);
            cmbIntern.Name = "cmbIntern";
            cmbIntern.Size = new Size(121, 23);
            cmbIntern.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(224, 83);
            label2.Name = "label2";
            label2.Size = new Size(174, 21);
            label2.TabIndex = 6;
            label2.Text = "Günlük Bilgi / Görev:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(224, 16);
            label3.Name = "label3";
            label3.Size = new Size(375, 48);
            label3.TabIndex = 7;
            label3.Text = "Staj Sorumlusu Ekranı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbIntern);
            Controls.Add(btnAdd);
            Controls.Add(rtbDescription);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbDescription;
        private Button btnAdd;
        private ComboBox cmbIntern;
        private Label label2;
        private Label label3;
    }
}

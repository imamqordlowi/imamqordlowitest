namespace WinFormsAppTest
{
    partial class AdminSecurity
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textKeyString = new TextBox();
            textString = new TextBox();
            textEncryptString = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 41);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Key String";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 90);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Text String";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 141);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Encrypt String";
            // 
            // textKeyString
            // 
            textKeyString.Location = new Point(196, 33);
            textKeyString.Name = "textKeyString";
            textKeyString.Size = new Size(249, 23);
            textKeyString.TabIndex = 3;
            // 
            // textString
            // 
            textString.Location = new Point(196, 82);
            textString.Name = "textString";
            textString.Size = new Size(249, 23);
            textString.TabIndex = 4;
            // 
            // textEncryptString
            // 
            textEncryptString.Location = new Point(196, 133);
            textEncryptString.Name = "textEncryptString";
            textEncryptString.Size = new Size(249, 23);
            textEncryptString.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(121, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Encrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(286, 203);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Decrypt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(543, 203);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AdminSecurity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 270);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textEncryptString);
            Controls.Add(textString);
            Controls.Add(textKeyString);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminSecurity";
            Text = "AdminSecurity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textKeyString;
        private TextBox textString;
        private TextBox textEncryptString;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
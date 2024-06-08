namespace AES_GUI
{
    partial class AES
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
            btn_genKey = new Button();
            btn_encrypt = new Button();
            btn_decrpyt = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_genKey
            // 
            btn_genKey.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            btn_genKey.Location = new Point(88, 76);
            btn_genKey.Name = "btn_genKey";
            btn_genKey.Size = new Size(130, 55);
            btn_genKey.TabIndex = 0;
            btn_genKey.Text = "KEYGEN";
            btn_genKey.UseVisualStyleBackColor = true;
            btn_genKey.Click += button1_Click;
            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            btn_encrypt.Location = new Point(88, 156);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(130, 54);
            btn_encrypt.TabIndex = 2;
            btn_encrypt.Text = "ENCRYPT";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Click += btn_encrypt_Click;
            // 
            // btn_decrpyt
            // 
            btn_decrpyt.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            btn_decrpyt.Location = new Point(88, 241);
            btn_decrpyt.Name = "btn_decrpyt";
            btn_decrpyt.Size = new Size(130, 48);
            btn_decrpyt.TabIndex = 3;
            btn_decrpyt.Text = "DECRYPT";
            btn_decrpyt.UseVisualStyleBackColor = true;
            btn_decrpyt.Click += btn_decrpyt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 33);
            label1.TabIndex = 4;
            label1.Text = "AES";
            // 
            // AES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 325);
            Controls.Add(label1);
            Controls.Add(btn_decrpyt);
            Controls.Add(btn_encrypt);
            Controls.Add(btn_genKey);
            Name = "AES";
            Text = "AES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_genKey;
        private Button btn_encrypt;
        private Button btn_decrpyt;
        private Label label1;
    }
}

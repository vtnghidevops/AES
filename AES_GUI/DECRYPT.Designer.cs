namespace AES_GUI
{
    partial class DECRYPT
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
            label7 = new Label();
            tb_pathCipher = new TextBox();
            tb_pathPlaintext = new TextBox();
            btn_selectPathPlaintext = new Button();
            btn_selectPathCipher = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tb_pathIV = new TextBox();
            tb_pathKey = new TextBox();
            label3 = new Label();
            label2 = new Label();
            prc_time = new ProgressBar();
            btn_selectPathKey = new Button();
            btn_genKey = new Button();
            btn_selectPathIV = new Button();
            cb_formatKey = new ComboBox();
            cb_mod = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 246);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 55;
            label1.Text = "Cipher File";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 296);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 54;
            label7.Text = "Output File";
            // 
            // tb_pathCipher
            // 
            tb_pathCipher.Location = new Point(138, 246);
            tb_pathCipher.Name = "tb_pathCipher";
            tb_pathCipher.ReadOnly = true;
            tb_pathCipher.Size = new Size(272, 27);
            tb_pathCipher.TabIndex = 53;
            // 
            // tb_pathPlaintext
            // 
            tb_pathPlaintext.Location = new Point(138, 293);
            tb_pathPlaintext.Name = "tb_pathPlaintext";
            tb_pathPlaintext.ReadOnly = true;
            tb_pathPlaintext.Size = new Size(272, 27);
            tb_pathPlaintext.TabIndex = 52;
            // 
            // btn_selectPathPlaintext
            // 
            btn_selectPathPlaintext.Location = new Point(449, 292);
            btn_selectPathPlaintext.Name = "btn_selectPathPlaintext";
            btn_selectPathPlaintext.Size = new Size(122, 29);
            btn_selectPathPlaintext.TabIndex = 51;
            btn_selectPathPlaintext.Text = "Save File";
            btn_selectPathPlaintext.UseVisualStyleBackColor = true;
            btn_selectPathPlaintext.Click += btn_selectPathPlaintext_Click;
            // 
            // btn_selectPathCipher
            // 
            btn_selectPathCipher.Location = new Point(449, 244);
            btn_selectPathCipher.Name = "btn_selectPathCipher";
            btn_selectPathCipher.Size = new Size(122, 29);
            btn_selectPathCipher.TabIndex = 50;
            btn_selectPathCipher.Text = "Select Cipher";
            btn_selectPathCipher.UseVisualStyleBackColor = true;
            btn_selectPathCipher.Click += btn_selectPathCipher_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(244, 29);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 49;
            label6.Text = "Decryption AES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 198);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 48;
            label5.Text = "IV File";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 137);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 47;
            label4.Text = "Key File";
            // 
            // tb_pathIV
            // 
            tb_pathIV.Location = new Point(138, 195);
            tb_pathIV.Name = "tb_pathIV";
            tb_pathIV.ReadOnly = true;
            tb_pathIV.Size = new Size(272, 27);
            tb_pathIV.TabIndex = 46;
            // 
            // tb_pathKey
            // 
            tb_pathKey.Location = new Point(138, 137);
            tb_pathKey.Name = "tb_pathKey";
            tb_pathKey.ReadOnly = true;
            tb_pathKey.Size = new Size(272, 27);
            tb_pathKey.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 81);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 44;
            label3.Text = "Format Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 81);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 43;
            label2.Text = "Mode";
            // 
            // prc_time
            // 
            prc_time.Location = new Point(66, 348);
            prc_time.Name = "prc_time";
            prc_time.Size = new Size(462, 29);
            prc_time.TabIndex = 42;
            // 
            // btn_selectPathKey
            // 
            btn_selectPathKey.Location = new Point(449, 136);
            btn_selectPathKey.Name = "btn_selectPathKey";
            btn_selectPathKey.Size = new Size(101, 29);
            btn_selectPathKey.TabIndex = 41;
            btn_selectPathKey.Text = "Select Key";
            btn_selectPathKey.UseVisualStyleBackColor = true;
            btn_selectPathKey.Click += btn_selectPathKey_Click;
            // 
            // btn_genKey
            // 
            btn_genKey.Location = new Point(267, 404);
            btn_genKey.Name = "btn_genKey";
            btn_genKey.Size = new Size(94, 29);
            btn_genKey.TabIndex = 40;
            btn_genKey.Text = "Decrypt";
            btn_genKey.UseVisualStyleBackColor = true;
            btn_genKey.Click += btn_genKey_Click;
            // 
            // btn_selectPathIV
            // 
            btn_selectPathIV.Location = new Point(449, 193);
            btn_selectPathIV.Name = "btn_selectPathIV";
            btn_selectPathIV.Size = new Size(101, 29);
            btn_selectPathIV.TabIndex = 39;
            btn_selectPathIV.Text = "Select IV";
            btn_selectPathIV.UseVisualStyleBackColor = true;
            btn_selectPathIV.Click += btn_selectPathIV_Click;
            // 
            // cb_formatKey
            // 
            cb_formatKey.FormattingEnabled = true;
            cb_formatKey.Items.AddRange(new object[] { "hex", "bin", "base64" });
            cb_formatKey.Location = new Point(439, 78);
            cb_formatKey.Name = "cb_formatKey";
            cb_formatKey.Size = new Size(92, 28);
            cb_formatKey.TabIndex = 38;
            // 
            // cb_mod
            // 
            cb_mod.FormattingEnabled = true;
            cb_mod.Items.AddRange(new object[] { "ECB", "CBC", "OFB", "CFB ", "CTR", "XTS ", "CCM", "GCM" });
            cb_mod.Location = new Point(138, 78);
            cb_mod.Name = "cb_mod";
            cb_mod.Size = new Size(110, 28);
            cb_mod.TabIndex = 37;
            // 
            // DECRYPT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(tb_pathCipher);
            Controls.Add(tb_pathPlaintext);
            Controls.Add(btn_selectPathPlaintext);
            Controls.Add(btn_selectPathCipher);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb_pathIV);
            Controls.Add(tb_pathKey);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(prc_time);
            Controls.Add(btn_selectPathKey);
            Controls.Add(btn_genKey);
            Controls.Add(btn_selectPathIV);
            Controls.Add(cb_formatKey);
            Controls.Add(cb_mod);
            Name = "DECRYPT";
            Text = "DECRYPT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private TextBox tb_pathCipher;
        private TextBox tb_pathPlaintext;
        private Button btn_selectPathPlaintext;
        private Button btn_selectPathCipher;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tb_pathIV;
        private TextBox tb_pathKey;
        private Label label3;
        private Label label2;
        private ProgressBar prc_time;
        private Button btn_selectPathKey;
        private Button btn_genKey;
        private Button btn_selectPathIV;
        private ComboBox cb_formatKey;
        private ComboBox cb_mod;
    }
}
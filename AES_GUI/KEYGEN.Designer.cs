namespace AES_GUI
{
    partial class KEYGEN
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
            cb_mod = new ComboBox();
            cb_formatKey = new ComboBox();
            btn_selectPathIV = new Button();
            btn_genKey = new Button();
            cb_keySize = new ComboBox();
            label1 = new Label();
            btn_selectPathKey = new Button();
            prc_time = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            tb_pathKey = new TextBox();
            tb_pathIV = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // cb_mod
            // 
            cb_mod.FormattingEnabled = true;
            cb_mod.Items.AddRange(new object[] { "ECB", "CBC", "OFB", "CFB ", "CTR", "XTS ", "CCM", "GCM" });
            cb_mod.Location = new Point(387, 79);
            cb_mod.Name = "cb_mod";
            cb_mod.Size = new Size(110, 28);
            cb_mod.TabIndex = 0;
            // 
            // cb_formatKey
            // 
            cb_formatKey.FormattingEnabled = true;
            cb_formatKey.Items.AddRange(new object[] { "hex", "bin", "base64" });
            cb_formatKey.Location = new Point(138, 147);
            cb_formatKey.Name = "cb_formatKey";
            cb_formatKey.Size = new Size(92, 28);
            cb_formatKey.TabIndex = 1;
            // 
            // btn_selectPathIV
            // 
            btn_selectPathIV.Location = new Point(417, 277);
            btn_selectPathIV.Name = "btn_selectPathIV";
            btn_selectPathIV.Size = new Size(80, 29);
            btn_selectPathIV.TabIndex = 2;
            btn_selectPathIV.Text = "Save IV";
            btn_selectPathIV.UseVisualStyleBackColor = true;
            btn_selectPathIV.Click += btn_selectPathIV_Click;
            // 
            // btn_genKey
            // 
            btn_genKey.Location = new Point(236, 399);
            btn_genKey.Name = "btn_genKey";
            btn_genKey.Size = new Size(94, 29);
            btn_genKey.TabIndex = 3;
            btn_genKey.Text = "Gen";
            btn_genKey.UseVisualStyleBackColor = true;
            btn_genKey.Click += btn_genKey_Click;
            // 
            // cb_keySize
            // 
            cb_keySize.FormattingEnabled = true;
            cb_keySize.Items.AddRange(new object[] { "128", "192", "256" });
            cb_keySize.Location = new Point(138, 76);
            cb_keySize.Name = "cb_keySize";
            cb_keySize.Size = new Size(92, 28);
            cb_keySize.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 79);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Key Size";
            // 
            // btn_selectPathKey
            // 
            btn_selectPathKey.Location = new Point(417, 220);
            btn_selectPathKey.Name = "btn_selectPathKey";
            btn_selectPathKey.Size = new Size(80, 29);
            btn_selectPathKey.TabIndex = 6;
            btn_selectPathKey.Text = "Save Key";
            btn_selectPathKey.UseVisualStyleBackColor = true;
            btn_selectPathKey.Click += btn_selectPathKey_Click;
            // 
            // prc_time
            // 
            prc_time.Location = new Point(35, 343);
            prc_time.Name = "prc_time";
            prc_time.Size = new Size(462, 29);
            prc_time.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 82);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 8;
            label2.Text = "Mode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 150);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 9;
            label3.Text = "Format Key";
            // 
            // tb_pathKey
            // 
            tb_pathKey.Location = new Point(106, 221);
            tb_pathKey.Name = "tb_pathKey";
            tb_pathKey.ReadOnly = true;
            tb_pathKey.Size = new Size(272, 27);
            tb_pathKey.TabIndex = 10;
            // 
            // tb_pathIV
            // 
            tb_pathIV.Location = new Point(106, 279);
            tb_pathIV.Name = "tb_pathIV";
            tb_pathIV.ReadOnly = true;
            tb_pathIV.Size = new Size(272, 27);
            tb_pathIV.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 221);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 13;
            label4.Text = "Key File";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 282);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 14;
            label5.Text = "IV File";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(213, 24);
            label6.Name = "label6";
            label6.Size = new Size(137, 28);
            label6.TabIndex = 15;
            label6.Text = "KEY GEN AES";
            // 
            // KEYGEN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(549, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb_pathIV);
            Controls.Add(tb_pathKey);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(prc_time);
            Controls.Add(btn_selectPathKey);
            Controls.Add(label1);
            Controls.Add(cb_keySize);
            Controls.Add(btn_genKey);
            Controls.Add(btn_selectPathIV);
            Controls.Add(cb_formatKey);
            Controls.Add(cb_mod);
            Name = "KEYGEN";
            Text = "KEYGEN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_mod;
        private ComboBox cb_formatKey;
        private Button btn_selectPathIV;
        private Button btn_genKey;
        private ComboBox cb_keySize;
        private Label label1;
        private Button btn_selectPathKey;
        private ProgressBar prc_time;
        private Label label2;
        private Label label3;
        private TextBox tb_pathKey;
        private TextBox tb_pathIV;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
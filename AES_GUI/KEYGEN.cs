using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //dll
using System.Diagnostics;


namespace AES_GUI
{
    public partial class KEYGEN : Form
    {
        [DllImport("D:\\WorkSpace\\Crypto\\OffClass_Task_AES-dll\\AES_DLL\\x64\\Debug\\AES_DLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void GenerateKeyAndIV(string mode, string keyformat, string keyFile, string ivFile, int keyLength);
        public KEYGEN()
        {
            InitializeComponent();
        }

        private void btn_genKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cb_keySize.Text) ||
            string.IsNullOrWhiteSpace(cb_mod.Text) ||
            string.IsNullOrWhiteSpace(cb_formatKey.Text) ||
            string.IsNullOrWhiteSpace(tb_pathKey.Text) ||
            string.IsNullOrWhiteSpace(tb_pathIV.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mode = cb_mod.SelectedItem.ToString();
                string keyformat = cb_formatKey.SelectedItem.ToString();
                string keyFile = tb_pathKey.Text;
                string ivFile = tb_pathIV.Text;
                int keyLength = int.Parse(cb_keySize.SelectedItem.ToString());

                prc_time.Value = 0;
                prc_time.Maximum = 100;


                var stopwatch = Stopwatch.StartNew();
                try
                {
                    GenerateKeyAndIV(mode, keyformat, keyFile, ivFile, keyLength);
                    // Update progress bar to indicate completion
                    prc_time.Value = prc_time.Maximum;
                    MessageBox.Show($"Key and IV generation completed in {stopwatch.ElapsedMilliseconds} ms.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
                stopwatch.Stop();
                

            }


        }

        private void btn_selectPathKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Chọn loại file bạn muốn cho phép người dùng chọn
            openFileDialog.Title = "Select Key File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                tb_pathKey.Text = selectedFilePath; // Hiển thị đường dẫn file đã chọn vào tb_pathKey
            }
        }

        private void btn_selectPathIV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Chọn loại file bạn muốn cho phép người dùng chọn
            openFileDialog.Title = "Select IV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                tb_pathIV.Text = selectedFilePath; // Hiển thị đường dẫn file đã chọn vào tb_pathIV
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çoklu_dil_çevirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        public async Task<string> TranslateText(string text, string targetLang)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl=auto&tl={targetLang}&dt=t&q={Uri.EscapeDataString(text)}";

                string result = await client.GetStringAsync(url);

                var match = Regex.Match(result, "\\[\\[\\[\"(.*?)\"");
                return match.Groups[1].Value;
            }
        }

       
        private async void btnCevir_Click(object sender, EventArgs e)
        {
            string input = txtMetin.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Metin boş olamaz!");
                return;
            }

            txtSonuc.Clear();

            foreach (var item in clbDiller.CheckedItems)
            {
                string full = item.ToString();
                string langCode = full.Substring(full.IndexOf("(") + 1, 2);

                string translation = await TranslateText(input, langCode);

                txtSonuc.AppendText($"{full}: {translation}\r\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void clbDiller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

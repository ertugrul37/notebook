using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void duzenKes_Click(object sender, EventArgs e)
        {
            yazialani.Cut();
        }

        private void duzenKopyala_Click(object sender, EventArgs e)
        {
            yazialani.Copy();
        }

        private void duzenYapistir_Click(object sender, EventArgs e)
        {
            yazialani.Paste();
        }

        private void formCikis_Click(object sender, EventArgs e)
        {
            
            
            DialogResult mesaj = new DialogResult();
            mesaj = MessageBox.Show("Dosya Kaydedilmedi Kaydedilmeden Kapatırsanız Yaptığınız Değişiklikler Kaydedilmeyecek Kaydedicekmisiniz ?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (mesaj == DialogResult.Yes)
            {
                SaveFileDialog kaydet = new SaveFileDialog();
                kaydet.Filter = "Text Uygulaması |*.txt| Tüm Dosyalar |*.*";
                DialogResult cevap = kaydet.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    yazialani.SaveFile(kaydet.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Close();
            }
            else if (mesaj == DialogResult.No)
            {
                this.Close();
            }
            
        }

        private void dosyaKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Not Uygulaması|*.txt| Word Dosyası|*.docx";
            DialogResult cevap = kaydet.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                yazialani.SaveFile(kaydet.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            PrintDialog yazdir = new PrintDialog();
            yazdir.ShowDialog();
            DialogResult cevap = yazdir.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                belge.Print();
            }
        }

        private void düzenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Dosyaları | *.txt";
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                yazialani.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ProductName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMPtoCcode
{
    public partial class Form1 : Form
    {
        string bmpFileName;

        string fontFileName;
        int fontSize;

        string applicationPath;
        
        public Form1()
        {
            InitializeComponent();
            FontSizeCombo.SelectedIndex = 0;
            OutFormatComboBox.Items.Add("4 bpp");
            OutFormatComboBox.Items.Add("24 bpp");
            OutFormatComboBox.SelectedIndex = 0;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            applicationPath = Application.StartupPath.ToString();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            bmpFileName = OpenFileDialog.FileName;
            BMPaddressTextBox.Text = bmpFileName;
            OpenFile.BackColor = Color.Green;
        }

        private void Put24bpp(StreamWriter sw, Bitmap bmp)
        {
            for (int col = 0; col < bmp.Height; col++)
            {
                sw.Write("\t");
                for (int row = 0; row < bmp.Width; row++)
                {
                    Color pixel = bmp.GetPixel(row, col);
                    sw.Write("0x" + string.Format("{0:X2}", pixel.R) + ", ");
                    sw.Write("0x" + string.Format("{0:X2}", pixel.G) + ", ");
                    sw.Write("0x" + string.Format("{0:X2}", pixel.B) + ", ");
                }
                sw.WriteLine("");
            }
        }

        private void Put4bpp(StreamWriter sw, Bitmap bmp)
        {
            int bmpWidth = bmp.Width / 2 + bmp.Width % 2;

            for (int col = 0; col < bmp.Height; col++)
            {
                sw.Write("\t");
                int pcnt = 0;
                for (int row = 0; row < bmpWidth; row++)
                {
                    int upper = (bmp.GetPixel(pcnt++, col).ToArgb() << 4) & 0x0F0;
                    int lower = pcnt < bmp.Width ? (bmp.GetPixel(pcnt++, col).ToArgb()) & 0x0F : 0;
                    sw.Write("0x" + string.Format("{0:X2}", (byte)(upper | lower)) + ", ");
                }
                sw.WriteLine("");
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(bmpFileName);

            int start = bmpFileName.LastIndexOf('\\') + 1;
            int end = bmpFileName.LastIndexOf('.');
            string path = bmpFileName.Substring(0, end);
            string fileName = bmpFileName.Substring(start, end - start);

            using (StreamWriter fstream = new StreamWriter(applicationPath + path + ".c"))
            {
                fstream.WriteLine("/*");
                fstream.WriteLine(" * " + fileName + ".c");
                fstream.WriteLine(" *");
                fstream.WriteLine(" */");
                fstream.WriteLine("");
                fstream.WriteLine("#include <bitmaps.h>");
                fstream.WriteLine("");
                fstream.WriteLine("const uint8_t " + fileName + "[] = {");
                fstream.WriteLine("");

                switch (OutFormatComboBox.SelectedIndex)
                {
                    case 0:
                        Put4bpp(fstream, bmp);
                        break;
                    case 1:
                        Put24bpp(fstream, bmp);
                        break;
                    default:
                        break;
                }

                fstream.WriteLine("");
                fstream.WriteLine("};");
                fstream.WriteLine("");
                fstream.WriteLine("const bitmap_info_t " + fileName + "_info = {");
                fstream.WriteLine("");
                fstream.WriteLine("\t.width = " + bmp.Width + ",");
                fstream.WriteLine("\t.height = " + bmp.Height + ",");
                fstream.WriteLine("\t.bitmap = " + fileName);
                fstream.WriteLine("");
                fstream.WriteLine("};");
                fstream.WriteLine("");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertFontBtn_Click(object sender, EventArgs e)
        {

        }

        private void FontSizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontSize = int.Parse(FontSizeCombo.GetItemText(FontSizeCombo.SelectedItem));
        }

        private void OpenFont_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            fontFileName = OpenFileDialog.FileName;
            FontAddressTextBox.Text = fontFileName;
            OpenFont.BackColor = Color.Green;
        }
    }
}

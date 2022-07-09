using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.OCR;
using Emgu.CV;
using Emgu.CV.Structure;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Teser
{
    public partial class Form1 : Form
    {
        private string filePath = string.Empty;
        private string lang = "rus";
        //private string pdfFilePath = string.Empty;
        private DataBase db = new DataBase();
        //private bool connection = false;

        public Form1()
        {
            InitializeComponent();
            nameToolStripTextBox.Click += (s, a) => 
            { if (nameToolStripTextBox.ForeColor != Color.Black)
                { nameToolStripTextBox.Clear(); nameToolStripTextBox.ForeColor = Color.Black; } };
        }

        private void CheckConnection()
        {
            db.PostInfo(TextBox.Text);
        }

        private void openPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = ImageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = ImageDialog.FileName;
                pictureBox.Image = Image.FromFile(filePath);
                Words.ScanPath = filePath;
            }
            else
            {
                MessageBox.Show("Картинка не выбрана!", "Выберите картинку", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void openPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = PDFdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = PDFdialog.FileName;
                Words.ScanPath = filePath;
            }
            else
                MessageBox.Show("PDF-файл не выбран.", "Выберите PDF-файл", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }

        private void connectToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckConnection();
        }

        private void closeDBConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (connection == true)
            db.CloseConnection();
        }

        private void recognizePicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(filePath))
                {
                    throw new Exception("Картинка не выбрана");
                }

                Tesseract tesseract = new Tesseract(@"C:\Users\EABS\Desktop\TeserData", lang,
                    OcrEngineMode.TesseractLstmCombined);
                tesseract.SetImage(new Image<Bgr, byte>(filePath));
                tesseract.Recognize();
                TextBox.Text = tesseract.GetUTF8Text();
                tesseract.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void recognizePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(filePath))
                {
                    throw new Exception("PDF-файл не выбран");
                }

                using (PdfReader reader = new PdfReader(filePath))
                {
                    for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
                    {
                        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                        string text = PdfTextExtractor.GetTextFromPage(reader, pageNumber, strategy);
                        text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8,
                            Encoding.Default.GetBytes(text)));
                        TextBox.Text += text;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void createDocxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Words.DocName = nameToolStripTextBox.Text;
            Words words = new Words();
            words.CreateWord();
        }
    }
}
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
        private string pdfFilePath = string.Empty;
        private DataBase db = new DataBase();
        private bool connection = false;

        #region param

        private string obj = String.Empty;
        private string cost = String.Empty;
        private string kdNumber = string.Empty;
        private string KDdateDetermenation = String.Empty;
        private string tax = String.Empty;
        private string dropTax = String.Empty;
        private string dropTaxYear = String.Empty;
        private string saving = String.Empty;
        private string notes = String.Empty;

        #endregion

        public Form1()
        {
            InitializeComponent();
            //if (!connection)
            //{
            //    connection = true;
            //    try
            //    {
            //        db.OpenConnection();
            //    }
            //    catch (Exception e)
            //    {
            //        MessageBox.Show("Что-то плохое");
            //        throw;
            //    }
            //}
        }

        private void CheckConnection()
        {
            db.PostInfo(TextBox.Text);
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = ImageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = ImageDialog.FileName;
                pictureBox.Image = Image.FromFile(filePath);
            }
            else
            {
                MessageBox.Show("Картинка не выбрана.", "Пожалуйста выберите картинку", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void открытьPDFфайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = PDFdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pdfFilePath = PDFdialog.FileName;
            }
            else
                MessageBox.Show("Файл не выбран.", "Пожалуйста выберите PDF-файл", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(pdfFilePath) || string.IsNullOrEmpty(pdfFilePath))
                {
                    throw new Exception("Картинка не выбрана");
                }

                Tesseract tesseract = new Tesseract(@"C:\Users\zayce\Desktop\testData", lang,
                    OcrEngineMode.TesseractLstmCombined);
                tesseract.SetImage(new Image<Bgr, byte>(pdfFilePath));
                tesseract.Recognize();
                TextBox.Text = tesseract.GetUTF8Text();
                tesseract.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(pdfFilePath) || string.IsNullOrEmpty(pdfFilePath))
                {
                    throw new Exception("Файл не выбран");
                }

                using (PdfReader reader = new PdfReader(pdfFilePath))
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
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CreatWordDoc_Click(object sender, EventArgs e)
        {
            Words words = new Words();
            words.CreateWord();
        }

        private void подключитьсяКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckConnection();
        }

        private void разорватьСоединениеСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (connection == true)
            db.CloseConnection();
        }
    }
}
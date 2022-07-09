namespace Teser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SelectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.картинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFдокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разорватьСоединениеСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.создатьdocxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.ImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.PDFdialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.базаДанныхToolStripMenuItem,
            this.nameToolStripTextBox,
            this.создатьdocxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(917, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SelectFileToolStripMenuItem
            // 
            this.SelectFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPictureToolStripMenuItem,
            this.OpenPDFToolStripMenuItem});
            this.SelectFileToolStripMenuItem.Name = "SelectFileToolStripMenuItem";
            this.SelectFileToolStripMenuItem.Size = new System.Drawing.Size(120, 27);
            this.SelectFileToolStripMenuItem.Text = "Открыть файл";
            // 
            // OpenPictureToolStripMenuItem
            // 
            this.OpenPictureToolStripMenuItem.Name = "OpenPictureToolStripMenuItem";
            this.OpenPictureToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.OpenPictureToolStripMenuItem.Text = "Открыть изображение";
            this.OpenPictureToolStripMenuItem.Click += new System.EventHandler(this.openPictureToolStripMenuItem_Click);
            // 
            // OpenPDFToolStripMenuItem
            // 
            this.OpenPDFToolStripMenuItem.Name = "OpenPDFToolStripMenuItem";
            this.OpenPDFToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.OpenPDFToolStripMenuItem.Text = "Открыть PDF-файл";
            this.OpenPDFToolStripMenuItem.Click += new System.EventHandler(this.openPDFToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.картинкуToolStripMenuItem,
            this.pDFдокументToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 27);
            this.toolStripMenuItem1.Text = "Распознать";
            // 
            // картинкуToolStripMenuItem
            // 
            this.картинкуToolStripMenuItem.Name = "картинкуToolStripMenuItem";
            this.картинкуToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.картинкуToolStripMenuItem.Text = "Картинку";
            this.картинкуToolStripMenuItem.Click += new System.EventHandler(this.recognizePicToolStripMenuItem_Click);
            // 
            // pDFдокументToolStripMenuItem
            // 
            this.pDFдокументToolStripMenuItem.Name = "pDFдокументToolStripMenuItem";
            this.pDFдокументToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.pDFдокументToolStripMenuItem.Text = "PDF-документ";
            this.pDFдокументToolStripMenuItem.Click += new System.EventHandler(this.recognizePDFToolStripMenuItem_Click);
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитьсяКБДToolStripMenuItem,
            this.разорватьСоединениеСБДToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // подключитьсяКБДToolStripMenuItem
            // 
            this.подключитьсяКБДToolStripMenuItem.Name = "подключитьсяКБДToolStripMenuItem";
            this.подключитьсяКБДToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.подключитьсяКБДToolStripMenuItem.Text = "Подключиться к БД и занести данные";
            this.подключитьсяКБДToolStripMenuItem.Click += new System.EventHandler(this.connectToDBToolStripMenuItem_Click);
            // 
            // разорватьСоединениеСБДToolStripMenuItem
            // 
            this.разорватьСоединениеСБДToolStripMenuItem.Name = "разорватьСоединениеСБДToolStripMenuItem";
            this.разорватьСоединениеСБДToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.разорватьСоединениеСБДToolStripMenuItem.Text = "Разорвать соединение с БД";
            this.разорватьСоединениеСБДToolStripMenuItem.Click += new System.EventHandler(this.closeDBConnectionToolStripMenuItem_Click);
            // 
            // nameToolStripTextBox
            // 
            this.nameToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameToolStripTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameToolStripTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nameToolStripTextBox.Name = "nameToolStripTextBox";
            this.nameToolStripTextBox.Size = new System.Drawing.Size(175, 27);
            this.nameToolStripTextBox.Text = "Название_файла";
            this.nameToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // создатьdocxToolStripMenuItem
            // 
            this.создатьdocxToolStripMenuItem.Name = "создатьdocxToolStripMenuItem";
            this.создатьdocxToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.создатьdocxToolStripMenuItem.Text = "Создать .docx";
            this.создатьdocxToolStripMenuItem.Click += new System.EventHandler(this.createDocxToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 427);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(5, 5);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(448, 417);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Location = new System.Drawing.Point(463, 5);
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(449, 417);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "";
            // 
            // ImageDialog
            // 
            this.ImageDialog.FileName = "openFileDialog1";
            this.ImageDialog.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // PDFdialog
            // 
            this.PDFdialog.FileName = "PDFdialog";
            this.PDFdialog.Filter = "PDF|*.pdf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SelectFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenPictureToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.OpenFileDialog ImageDialog;
        private System.Windows.Forms.OpenFileDialog PDFdialog;
        private System.Windows.Forms.ToolStripMenuItem OpenPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разорватьСоединениеСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem картинкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFдокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьdocxToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
    }
}


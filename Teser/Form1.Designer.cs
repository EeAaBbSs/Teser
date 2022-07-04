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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распознатьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьPDFфайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripImage = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.ImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.PDFdialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CreatWordDoc = new System.Windows.Forms.ToolStripButton();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разорватьСоединениеСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripImage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.базаДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(917, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.распознатьТекстToolStripMenuItem,
            this.открытьPDFфайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // распознатьТекстToolStripMenuItem
            // 
            this.распознатьТекстToolStripMenuItem.Name = "распознатьТекстToolStripMenuItem";
            this.распознатьТекстToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.распознатьТекстToolStripMenuItem.Text = "Открыть изображение";
            this.распознатьТекстToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // открытьPDFфайлToolStripMenuItem
            // 
            this.открытьPDFфайлToolStripMenuItem.Name = "открытьPDFфайлToolStripMenuItem";
            this.открытьPDFфайлToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.открытьPDFфайлToolStripMenuItem.Text = "Открыть PDF-файл";
            this.открытьPDFфайлToolStripMenuItem.Click += new System.EventHandler(this.открытьPDFфайлToolStripMenuItem_Click);
            // 
            // toolStripImage
            // 
            this.toolStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.CreatWordDoc});
            this.toolStripImage.Location = new System.Drawing.Point(0, 25);
            this.toolStripImage.Name = "toolStripImage";
            this.toolStripImage.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripImage.Size = new System.Drawing.Size(917, 25);
            this.toolStripImage.TabIndex = 1;
            this.toolStripImage.Text = "Распознать текст";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 22);
            this.toolStripButton1.Text = "Распознать текст";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(128, 22);
            this.toolStripButton2.Text = "Распознать документ";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 410);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(5, 5);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(448, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // TextBox
            // 
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Location = new System.Drawing.Point(463, 5);
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(449, 400);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CreatWordDoc
            // 
            this.CreatWordDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreatWordDoc.Image = ((System.Drawing.Image)(resources.GetObject("CreatWordDoc.Image")));
            this.CreatWordDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreatWordDoc.Name = "CreatWordDoc";
            this.CreatWordDoc.Size = new System.Drawing.Size(130, 22);
            this.CreatWordDoc.Text = "Creat Word Document";
            this.CreatWordDoc.ToolTipText = "Creat Word Doc";
            this.CreatWordDoc.Click += new System.EventHandler(this.CreatWordDoc_Click);
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитьсяКБДToolStripMenuItem,
            this.разорватьСоединениеСБДToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(87, 19);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // подключитьсяКБДToolStripMenuItem
            // 
            this.подключитьсяКБДToolStripMenuItem.Name = "подключитьсяКБДToolStripMenuItem";
            this.подключитьсяКБДToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.подключитьсяКБДToolStripMenuItem.Text = "Подключиться к БД";
            this.подключитьсяКБДToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяКБДToolStripMenuItem_Click);
            // 
            // разорватьСоединениеСБДToolStripMenuItem
            // 
            this.разорватьСоединениеСБДToolStripMenuItem.Name = "разорватьСоединениеСБДToolStripMenuItem";
            this.разорватьСоединениеСБДToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.разорватьСоединениеСБДToolStripMenuItem.Text = "Разорвать соединение с БД";
            this.разорватьСоединениеСБДToolStripMenuItem.Click += new System.EventHandler(this.разорватьСоединениеСБДToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripImage);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripImage.ResumeLayout(false);
            this.toolStripImage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распознатьТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripImage;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.OpenFileDialog ImageDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.OpenFileDialog PDFdialog;
        private System.Windows.Forms.ToolStripMenuItem открытьPDFфайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CreatWordDoc;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разорватьСоединениеСБДToolStripMenuItem;
    }
}


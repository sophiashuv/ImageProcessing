namespace ImageProcessingLab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            formatBMRRLEToolStripMenuItem = new ToolStripMenuItem();
            formatTIFFLZWToolStripMenuItem = new ToolStripMenuItem();
            formatJPEGSEToolStripMenuItem = new ToolStripMenuItem();
            differenceToolStripMenuItem = new ToolStripMenuItem();
            bMRTIFFLZWToolStripMenuItem = new ToolStripMenuItem();
            bMRJPEGSEToolStripMenuItem = new ToolStripMenuItem();
            tIFFJPEGSEToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            textBox35 = new TextBox();
            textBox34 = new TextBox();
            textBox33 = new TextBox();
            textBox32 = new TextBox();
            textBox31 = new TextBox();
            textBox30 = new TextBox();
            textBox29 = new TextBox();
            textBox28 = new TextBox();
            textBox27 = new TextBox();
            textBox26 = new TextBox();
            textBox25 = new TextBox();
            textBox24 = new TextBox();
            textBox23 = new TextBox();
            textBox22 = new TextBox();
            textBox21 = new TextBox();
            textBox20 = new TextBox();
            textBox19 = new TextBox();
            textBox18 = new TextBox();
            label29 = new Label();
            label28 = new Label();
            textBox17 = new TextBox();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox9 = new TextBox();
            label23 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label15 = new Label();
            label17 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            textBox6 = new TextBox();
            label22 = new Label();
            textBox16 = new TextBox();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox3 = new TextBox();
            label18 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label16 = new Label();
            textBox12 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxRecordJPEG = new TextBox();
            textBoxRecordTIFF = new TextBox();
            textBoxRecordBMP = new TextBox();
            textBoxDecodingJPEG = new TextBox();
            textBoxDecodingTIFF = new TextBox();
            textBoxDecodingBMP = new TextBox();
            textBoxEncodingJPEG = new TextBox();
            textBoxEncodingTIFF = new TextBox();
            textBoxEncodingBMP = new TextBox();
            textBoxReadingJPEG = new TextBox();
            textBoxReadingTIFF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxReadingBMP = new TextBox();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            RGB_rb = new RadioButton();
            radioButton2 = new RadioButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, differenceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1157, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formatBMRRLEToolStripMenuItem, formatTIFFLZWToolStripMenuItem, formatJPEGSEToolStripMenuItem });
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(224, 26);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // formatBMRRLEToolStripMenuItem
            // 
            formatBMRRLEToolStripMenuItem.Name = "formatBMRRLEToolStripMenuItem";
            formatBMRRLEToolStripMenuItem.Size = new Size(224, 26);
            formatBMRRLEToolStripMenuItem.Text = "Format BMP (RLE)";
            formatBMRRLEToolStripMenuItem.Click += formatBMRRLEToolStripMenuItem_Click;
            // 
            // formatTIFFLZWToolStripMenuItem
            // 
            formatTIFFLZWToolStripMenuItem.Name = "formatTIFFLZWToolStripMenuItem";
            formatTIFFLZWToolStripMenuItem.Size = new Size(224, 26);
            formatTIFFLZWToolStripMenuItem.Text = "Format TIFF (LZW)";
            formatTIFFLZWToolStripMenuItem.Click += formatTIFFLZWToolStripMenuItem_Click;
            // 
            // formatJPEGSEToolStripMenuItem
            // 
            formatJPEGSEToolStripMenuItem.Name = "formatJPEGSEToolStripMenuItem";
            formatJPEGSEToolStripMenuItem.Size = new Size(224, 26);
            formatJPEGSEToolStripMenuItem.Text = "Format JPEG (SE)";
            formatJPEGSEToolStripMenuItem.Click += formatJPEGSEToolStripMenuItem_Click;
            // 
            // differenceToolStripMenuItem
            // 
            differenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bMRTIFFLZWToolStripMenuItem, bMRJPEGSEToolStripMenuItem, tIFFJPEGSEToolStripMenuItem });
            differenceToolStripMenuItem.Name = "differenceToolStripMenuItem";
            differenceToolStripMenuItem.Size = new Size(92, 24);
            differenceToolStripMenuItem.Text = "Difference";
            // 
            // bMRTIFFLZWToolStripMenuItem
            // 
            bMRTIFFLZWToolStripMenuItem.Name = "bMRTIFFLZWToolStripMenuItem";
            bMRTIFFLZWToolStripMenuItem.Size = new Size(224, 26);
            bMRTIFFLZWToolStripMenuItem.Text = "BMP - BMR (RLE)";
            bMRTIFFLZWToolStripMenuItem.Click += bMRTIFFLZWToolStripMenuItem_Click;
            // 
            // bMRJPEGSEToolStripMenuItem
            // 
            bMRJPEGSEToolStripMenuItem.Name = "bMRJPEGSEToolStripMenuItem";
            bMRJPEGSEToolStripMenuItem.Size = new Size(224, 26);
            bMRJPEGSEToolStripMenuItem.Text = "BMP -TIFF (LZW)";
            bMRJPEGSEToolStripMenuItem.Click += bMRJPEGSEToolStripMenuItem_Click;
            // 
            // tIFFJPEGSEToolStripMenuItem
            // 
            tIFFJPEGSEToolStripMenuItem.Name = "tIFFJPEGSEToolStripMenuItem";
            tIFFJPEGSEToolStripMenuItem.Size = new Size(224, 26);
            tIFFJPEGSEToolStripMenuItem.Text = "BMP - JPEG (SE)";
            tIFFJPEGSEToolStripMenuItem.Click += tIFFJPEGSEToolStripMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(525, 717);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel5);
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(572, 795);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Properties";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(textBox35, 3, 9);
            tableLayoutPanel5.Controls.Add(textBox34, 2, 9);
            tableLayoutPanel5.Controls.Add(textBox33, 1, 9);
            tableLayoutPanel5.Controls.Add(textBox32, 3, 8);
            tableLayoutPanel5.Controls.Add(textBox31, 2, 8);
            tableLayoutPanel5.Controls.Add(textBox30, 1, 8);
            tableLayoutPanel5.Controls.Add(textBox29, 3, 7);
            tableLayoutPanel5.Controls.Add(textBox28, 2, 7);
            tableLayoutPanel5.Controls.Add(textBox27, 1, 7);
            tableLayoutPanel5.Controls.Add(textBox26, 3, 6);
            tableLayoutPanel5.Controls.Add(textBox25, 2, 6);
            tableLayoutPanel5.Controls.Add(textBox24, 1, 6);
            tableLayoutPanel5.Controls.Add(textBox23, 3, 5);
            tableLayoutPanel5.Controls.Add(textBox22, 2, 5);
            tableLayoutPanel5.Controls.Add(textBox21, 1, 5);
            tableLayoutPanel5.Controls.Add(textBox20, 3, 4);
            tableLayoutPanel5.Controls.Add(textBox19, 2, 4);
            tableLayoutPanel5.Controls.Add(textBox18, 1, 4);
            tableLayoutPanel5.Controls.Add(label29, 0, 9);
            tableLayoutPanel5.Controls.Add(label28, 0, 8);
            tableLayoutPanel5.Controls.Add(textBox17, 3, 3);
            tableLayoutPanel5.Controls.Add(textBox15, 1, 3);
            tableLayoutPanel5.Controls.Add(textBox14, 3, 2);
            tableLayoutPanel5.Controls.Add(textBox13, 2, 2);
            tableLayoutPanel5.Controls.Add(textBox9, 1, 2);
            tableLayoutPanel5.Controls.Add(label23, 0, 3);
            tableLayoutPanel5.Controls.Add(textBox4, 3, 1);
            tableLayoutPanel5.Controls.Add(textBox5, 2, 1);
            tableLayoutPanel5.Controls.Add(label15, 1, 0);
            tableLayoutPanel5.Controls.Add(label17, 2, 0);
            tableLayoutPanel5.Controls.Add(label19, 3, 0);
            tableLayoutPanel5.Controls.Add(label20, 0, 1);
            tableLayoutPanel5.Controls.Add(label21, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox6, 1, 1);
            tableLayoutPanel5.Controls.Add(label22, 0, 2);
            tableLayoutPanel5.Controls.Add(textBox16, 2, 3);
            tableLayoutPanel5.Controls.Add(label24, 0, 4);
            tableLayoutPanel5.Controls.Add(label25, 0, 5);
            tableLayoutPanel5.Controls.Add(label26, 0, 6);
            tableLayoutPanel5.Controls.Add(label27, 0, 7);
            tableLayoutPanel5.Location = new Point(17, 413);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 10;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.Size = new Size(538, 373);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // textBox35
            // 
            textBox35.BorderStyle = BorderStyle.None;
            textBox35.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox35.Location = new Point(405, 336);
            textBox35.Name = "textBox35";
            textBox35.ReadOnly = true;
            textBox35.Size = new Size(125, 20);
            textBox35.TabIndex = 39;
            // 
            // textBox34
            // 
            textBox34.BorderStyle = BorderStyle.None;
            textBox34.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox34.Location = new Point(271, 336);
            textBox34.Name = "textBox34";
            textBox34.ReadOnly = true;
            textBox34.Size = new Size(125, 20);
            textBox34.TabIndex = 38;
            // 
            // textBox33
            // 
            textBox33.BorderStyle = BorderStyle.None;
            textBox33.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox33.Location = new Point(137, 336);
            textBox33.Name = "textBox33";
            textBox33.ReadOnly = true;
            textBox33.Size = new Size(125, 20);
            textBox33.TabIndex = 37;
            // 
            // textBox32
            // 
            textBox32.BorderStyle = BorderStyle.None;
            textBox32.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox32.Location = new Point(405, 299);
            textBox32.Name = "textBox32";
            textBox32.ReadOnly = true;
            textBox32.Size = new Size(125, 20);
            textBox32.TabIndex = 36;
            // 
            // textBox31
            // 
            textBox31.BorderStyle = BorderStyle.None;
            textBox31.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox31.Location = new Point(271, 299);
            textBox31.Name = "textBox31";
            textBox31.ReadOnly = true;
            textBox31.Size = new Size(125, 20);
            textBox31.TabIndex = 35;
            // 
            // textBox30
            // 
            textBox30.BorderStyle = BorderStyle.None;
            textBox30.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox30.Location = new Point(137, 299);
            textBox30.Name = "textBox30";
            textBox30.ReadOnly = true;
            textBox30.Size = new Size(125, 20);
            textBox30.TabIndex = 34;
            // 
            // textBox29
            // 
            textBox29.BorderStyle = BorderStyle.None;
            textBox29.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox29.Location = new Point(405, 262);
            textBox29.Name = "textBox29";
            textBox29.ReadOnly = true;
            textBox29.Size = new Size(125, 20);
            textBox29.TabIndex = 33;
            // 
            // textBox28
            // 
            textBox28.BorderStyle = BorderStyle.None;
            textBox28.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox28.Location = new Point(271, 262);
            textBox28.Name = "textBox28";
            textBox28.ReadOnly = true;
            textBox28.Size = new Size(125, 20);
            textBox28.TabIndex = 32;
            // 
            // textBox27
            // 
            textBox27.BorderStyle = BorderStyle.None;
            textBox27.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox27.Location = new Point(137, 262);
            textBox27.Name = "textBox27";
            textBox27.ReadOnly = true;
            textBox27.Size = new Size(125, 20);
            textBox27.TabIndex = 31;
            // 
            // textBox26
            // 
            textBox26.BorderStyle = BorderStyle.None;
            textBox26.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox26.Location = new Point(405, 225);
            textBox26.Name = "textBox26";
            textBox26.ReadOnly = true;
            textBox26.Size = new Size(125, 20);
            textBox26.TabIndex = 30;
            // 
            // textBox25
            // 
            textBox25.BorderStyle = BorderStyle.None;
            textBox25.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox25.Location = new Point(271, 225);
            textBox25.Name = "textBox25";
            textBox25.ReadOnly = true;
            textBox25.Size = new Size(125, 20);
            textBox25.TabIndex = 29;
            // 
            // textBox24
            // 
            textBox24.BorderStyle = BorderStyle.None;
            textBox24.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox24.Location = new Point(137, 225);
            textBox24.Name = "textBox24";
            textBox24.ReadOnly = true;
            textBox24.Size = new Size(125, 20);
            textBox24.TabIndex = 28;
            // 
            // textBox23
            // 
            textBox23.BorderStyle = BorderStyle.None;
            textBox23.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox23.Location = new Point(405, 188);
            textBox23.Name = "textBox23";
            textBox23.ReadOnly = true;
            textBox23.Size = new Size(125, 20);
            textBox23.TabIndex = 27;
            // 
            // textBox22
            // 
            textBox22.BorderStyle = BorderStyle.None;
            textBox22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox22.Location = new Point(271, 188);
            textBox22.Name = "textBox22";
            textBox22.ReadOnly = true;
            textBox22.Size = new Size(125, 20);
            textBox22.TabIndex = 26;
            // 
            // textBox21
            // 
            textBox21.BorderStyle = BorderStyle.None;
            textBox21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox21.Location = new Point(137, 188);
            textBox21.Name = "textBox21";
            textBox21.ReadOnly = true;
            textBox21.Size = new Size(125, 20);
            textBox21.TabIndex = 25;
            // 
            // textBox20
            // 
            textBox20.BorderStyle = BorderStyle.None;
            textBox20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox20.Location = new Point(405, 151);
            textBox20.Name = "textBox20";
            textBox20.ReadOnly = true;
            textBox20.Size = new Size(125, 20);
            textBox20.TabIndex = 24;
            // 
            // textBox19
            // 
            textBox19.BorderStyle = BorderStyle.None;
            textBox19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox19.Location = new Point(271, 151);
            textBox19.Name = "textBox19";
            textBox19.ReadOnly = true;
            textBox19.Size = new Size(125, 20);
            textBox19.TabIndex = 23;
            // 
            // textBox18
            // 
            textBox18.BorderStyle = BorderStyle.None;
            textBox18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox18.Location = new Point(137, 151);
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            textBox18.Size = new Size(125, 20);
            textBox18.TabIndex = 15;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.Blue;
            label29.Location = new Point(3, 333);
            label29.Name = "label29";
            label29.Size = new Size(74, 20);
            label29.TabIndex = 22;
            label29.Text = "B (PSNR)";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.Green;
            label28.Location = new Point(3, 296);
            label28.Name = "label28";
            label28.Size = new Size(75, 20);
            label28.TabIndex = 21;
            label28.Text = "G (PSNR)";
            // 
            // textBox17
            // 
            textBox17.BorderStyle = BorderStyle.None;
            textBox17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox17.Location = new Point(405, 114);
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new Size(125, 20);
            textBox17.TabIndex = 16;
            // 
            // textBox15
            // 
            textBox15.BorderStyle = BorderStyle.None;
            textBox15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox15.Location = new Point(137, 114);
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(125, 20);
            textBox15.TabIndex = 14;
            // 
            // textBox14
            // 
            textBox14.BorderStyle = BorderStyle.None;
            textBox14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.Location = new Point(405, 77);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(125, 20);
            textBox14.TabIndex = 13;
            // 
            // textBox13
            // 
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(271, 77);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(125, 20);
            textBox13.TabIndex = 12;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(137, 77);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(125, 20);
            textBox9.TabIndex = 8;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Blue;
            label23.Location = new Point(3, 111);
            label23.Name = "label23";
            label23.Size = new Size(19, 20);
            label23.TabIndex = 11;
            label23.Text = "B";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(405, 40);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 20);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(271, 40);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(125, 20);
            textBox5.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(137, 0);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 0;
            label15.Text = "BMP (RLE)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(271, 0);
            label17.Name = "label17";
            label17.Size = new Size(87, 20);
            label17.TabIndex = 1;
            label17.Text = "TIFF (LZW)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(405, 0);
            label19.Name = "label19";
            label19.Size = new Size(76, 20);
            label19.TabIndex = 2;
            label19.Text = "JPEG (SE)";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(3, 37);
            label20.Name = "label20";
            label20.Size = new Size(19, 20);
            label20.TabIndex = 3;
            label20.Text = "R";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = SystemColors.Control;
            label21.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.DarkCyan;
            label21.Location = new Point(3, 0);
            label21.Name = "label21";
            label21.Size = new Size(101, 25);
            label21.TabIndex = 7;
            label21.Text = "Difference";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(137, 40);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(125, 20);
            textBox6.TabIndex = 1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Green;
            label22.Location = new Point(3, 74);
            label22.Name = "label22";
            label22.Size = new Size(20, 20);
            label22.TabIndex = 10;
            label22.Text = "G";
            // 
            // textBox16
            // 
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox16.Location = new Point(271, 114);
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(125, 20);
            textBox16.TabIndex = 15;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Red;
            label24.Location = new Point(3, 148);
            label24.Name = "label24";
            label24.Size = new Size(75, 20);
            label24.TabIndex = 17;
            label24.Text = "R (RMSE)";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Green;
            label25.Location = new Point(3, 185);
            label25.Name = "label25";
            label25.Size = new Size(76, 20);
            label25.TabIndex = 18;
            label25.Text = "G (RMSE)";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.Blue;
            label26.Location = new Point(3, 222);
            label26.Name = "label26";
            label26.Size = new Size(75, 20);
            label26.TabIndex = 19;
            label26.Text = "B (RMSE)";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.Red;
            label27.Location = new Point(3, 259);
            label27.Name = "label27";
            label27.Size = new Size(74, 20);
            label27.TabIndex = 20;
            label27.Text = "R (PSNR)";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel3.Controls.Add(label18, 0, 0);
            tableLayoutPanel3.Location = new Point(17, 237);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(268, 39);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(137, 3);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 20);
            textBox3.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.Control;
            label18.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.DarkCyan;
            label18.Location = new Point(3, 0);
            label18.Name = "label18";
            label18.Size = new Size(117, 25);
            label18.TabIndex = 7;
            label18.Text = "Original size";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(textBox10, 3, 1);
            tableLayoutPanel2.Controls.Add(textBox11, 2, 1);
            tableLayoutPanel2.Controls.Add(label9, 1, 0);
            tableLayoutPanel2.Controls.Add(label10, 2, 0);
            tableLayoutPanel2.Controls.Add(label11, 3, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 1);
            tableLayoutPanel2.Controls.Add(label16, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox12, 1, 1);
            tableLayoutPanel2.Location = new Point(17, 296);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(538, 95);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(405, 50);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(125, 20);
            textBox10.TabIndex = 9;
            // 
            // textBox11
            // 
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(271, 50);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(125, 20);
            textBox11.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(137, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 0;
            label9.Text = "BMP (RLE)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(271, 0);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 1;
            label10.Text = "TIFF (LZW)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(405, 0);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 2;
            label11.Text = "JPEG (SE)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 47);
            label12.Name = "label12";
            label12.Size = new Size(98, 40);
            label12.TabIndex = 3;
            label12.Text = "Size after compression";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.Control;
            label16.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkCyan;
            label16.Location = new Point(3, 0);
            label16.Name = "label16";
            label16.Size = new Size(46, 25);
            label16.TabIndex = 7;
            label16.Text = "Size";
            // 
            // textBox12
            // 
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.Location = new Point(137, 50);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(125, 20);
            textBox12.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(textBoxRecordJPEG, 3, 4);
            tableLayoutPanel1.Controls.Add(textBoxRecordTIFF, 2, 4);
            tableLayoutPanel1.Controls.Add(textBoxRecordBMP, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxDecodingJPEG, 3, 3);
            tableLayoutPanel1.Controls.Add(textBoxDecodingTIFF, 2, 3);
            tableLayoutPanel1.Controls.Add(textBoxDecodingBMP, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxEncodingJPEG, 3, 2);
            tableLayoutPanel1.Controls.Add(textBoxEncodingTIFF, 2, 2);
            tableLayoutPanel1.Controls.Add(textBoxEncodingBMP, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxReadingJPEG, 3, 1);
            tableLayoutPanel1.Controls.Add(textBoxReadingTIFF, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 3, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxReadingBMP, 1, 1);
            tableLayoutPanel1.Location = new Point(17, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(538, 180);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxRecordJPEG
            // 
            textBoxRecordJPEG.BorderStyle = BorderStyle.None;
            textBoxRecordJPEG.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRecordJPEG.Location = new Point(405, 147);
            textBoxRecordJPEG.Name = "textBoxRecordJPEG";
            textBoxRecordJPEG.ReadOnly = true;
            textBoxRecordJPEG.Size = new Size(125, 20);
            textBoxRecordJPEG.TabIndex = 18;
            // 
            // textBoxRecordTIFF
            // 
            textBoxRecordTIFF.BorderStyle = BorderStyle.None;
            textBoxRecordTIFF.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRecordTIFF.Location = new Point(271, 147);
            textBoxRecordTIFF.Name = "textBoxRecordTIFF";
            textBoxRecordTIFF.ReadOnly = true;
            textBoxRecordTIFF.Size = new Size(125, 20);
            textBoxRecordTIFF.TabIndex = 17;
            // 
            // textBoxRecordBMP
            // 
            textBoxRecordBMP.BorderStyle = BorderStyle.None;
            textBoxRecordBMP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRecordBMP.Location = new Point(137, 147);
            textBoxRecordBMP.Name = "textBoxRecordBMP";
            textBoxRecordBMP.ReadOnly = true;
            textBoxRecordBMP.Size = new Size(125, 20);
            textBoxRecordBMP.TabIndex = 16;
            // 
            // textBoxDecodingJPEG
            // 
            textBoxDecodingJPEG.BorderStyle = BorderStyle.None;
            textBoxDecodingJPEG.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDecodingJPEG.Location = new Point(405, 111);
            textBoxDecodingJPEG.Name = "textBoxDecodingJPEG";
            textBoxDecodingJPEG.ReadOnly = true;
            textBoxDecodingJPEG.Size = new Size(125, 20);
            textBoxDecodingJPEG.TabIndex = 15;
            // 
            // textBoxDecodingTIFF
            // 
            textBoxDecodingTIFF.BorderStyle = BorderStyle.None;
            textBoxDecodingTIFF.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDecodingTIFF.Location = new Point(271, 111);
            textBoxDecodingTIFF.Name = "textBoxDecodingTIFF";
            textBoxDecodingTIFF.ReadOnly = true;
            textBoxDecodingTIFF.Size = new Size(125, 20);
            textBoxDecodingTIFF.TabIndex = 14;
            // 
            // textBoxDecodingBMP
            // 
            textBoxDecodingBMP.BorderStyle = BorderStyle.None;
            textBoxDecodingBMP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDecodingBMP.Location = new Point(137, 111);
            textBoxDecodingBMP.Name = "textBoxDecodingBMP";
            textBoxDecodingBMP.ReadOnly = true;
            textBoxDecodingBMP.Size = new Size(125, 20);
            textBoxDecodingBMP.TabIndex = 13;
            // 
            // textBoxEncodingJPEG
            // 
            textBoxEncodingJPEG.BorderStyle = BorderStyle.None;
            textBoxEncodingJPEG.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEncodingJPEG.Location = new Point(405, 75);
            textBoxEncodingJPEG.Name = "textBoxEncodingJPEG";
            textBoxEncodingJPEG.ReadOnly = true;
            textBoxEncodingJPEG.Size = new Size(125, 20);
            textBoxEncodingJPEG.TabIndex = 12;
            // 
            // textBoxEncodingTIFF
            // 
            textBoxEncodingTIFF.BorderStyle = BorderStyle.None;
            textBoxEncodingTIFF.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEncodingTIFF.Location = new Point(271, 75);
            textBoxEncodingTIFF.Name = "textBoxEncodingTIFF";
            textBoxEncodingTIFF.ReadOnly = true;
            textBoxEncodingTIFF.Size = new Size(125, 20);
            textBoxEncodingTIFF.TabIndex = 11;
            // 
            // textBoxEncodingBMP
            // 
            textBoxEncodingBMP.BorderStyle = BorderStyle.None;
            textBoxEncodingBMP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEncodingBMP.Location = new Point(137, 75);
            textBoxEncodingBMP.Name = "textBoxEncodingBMP";
            textBoxEncodingBMP.ReadOnly = true;
            textBoxEncodingBMP.Size = new Size(125, 20);
            textBoxEncodingBMP.TabIndex = 10;
            // 
            // textBoxReadingJPEG
            // 
            textBoxReadingJPEG.BorderStyle = BorderStyle.None;
            textBoxReadingJPEG.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReadingJPEG.Location = new Point(405, 39);
            textBoxReadingJPEG.Name = "textBoxReadingJPEG";
            textBoxReadingJPEG.ReadOnly = true;
            textBoxReadingJPEG.Size = new Size(125, 20);
            textBoxReadingJPEG.TabIndex = 9;
            // 
            // textBoxReadingTIFF
            // 
            textBoxReadingTIFF.BorderStyle = BorderStyle.None;
            textBoxReadingTIFF.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReadingTIFF.Location = new Point(271, 39);
            textBoxReadingTIFF.Name = "textBoxReadingTIFF";
            textBoxReadingTIFF.ReadOnly = true;
            textBoxReadingTIFF.Size = new Size(125, 20);
            textBoxReadingTIFF.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "BMP (RLE)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(271, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "TIFF (LZW)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(405, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "JPEG (SE)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 36);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Reading";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 72);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Encoding";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 108);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 5;
            label6.Text = "Decoding";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 144);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 6;
            label7.Text = "Record";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 25);
            label8.TabIndex = 7;
            label8.Text = "Time";
            // 
            // textBoxReadingBMP
            // 
            textBoxReadingBMP.BorderStyle = BorderStyle.None;
            textBoxReadingBMP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReadingBMP.Location = new Point(137, 39);
            textBoxReadingBMP.Name = "textBoxReadingBMP";
            textBoxReadingBMP.ReadOnly = true;
            textBoxReadingBMP.Size = new Size(125, 20);
            textBoxReadingBMP.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(17, 35);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(538, 180);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(tableLayoutPanel7);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(600, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(549, 795);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Image";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.7619057F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1428566F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.Controls.Add(radioButton3, 3, 0);
            tableLayoutPanel7.Controls.Add(radioButton1, 0, 0);
            tableLayoutPanel7.Controls.Add(RGB_rb, 1, 0);
            tableLayoutPanel7.Controls.Add(radioButton2, 2, 0);
            tableLayoutPanel7.Location = new Point(6, 749);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(525, 30);
            tableLayoutPanel7.TabIndex = 7;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.Blue;
            radioButton3.Location = new Point(396, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(40, 24);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "B";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "RGB";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // RGB_rb
            // 
            RGB_rb.AutoSize = true;
            RGB_rb.ForeColor = Color.Red;
            RGB_rb.Location = new Point(134, 3);
            RGB_rb.Name = "RGB_rb";
            RGB_rb.Size = new Size(40, 24);
            RGB_rb.TabIndex = 5;
            RGB_rb.TabStop = true;
            RGB_rb.Text = "R";
            RGB_rb.UseVisualStyleBackColor = true;
            RGB_rb.CheckedChanged += RGB_rb_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Green;
            radioButton2.Location = new Point(264, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "G";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(textBox1, 3, 1);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(153, 23);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(44, 20);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(103, 3);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(44, 20);
            textBox2.TabIndex = 8;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Controls.Add(textBox7, 3, 1);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(153, 23);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(44, 20);
            textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(103, 3);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(44, 20);
            textBox8.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 837);
            Controls.Add(groupBox2);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox3);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem formatBMRRLEToolStripMenuItem;
        private ToolStripMenuItem formatTIFFLZWToolStripMenuItem;
        private ToolStripMenuItem formatJPEGSEToolStripMenuItem;
        private ToolStripMenuItem differenceToolStripMenuItem;
        private ToolStripMenuItem bMRTIFFLZWToolStripMenuItem;
        private ToolStripMenuItem bMRJPEGSEToolStripMenuItem;
        private ToolStripMenuItem tIFFJPEGSEToolStripMenuItem;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox3;
        private TextBox textBoxRecordJPEG;
        private TextBox textBoxRecordTIFF;
        private TextBox textBoxRecordBMP;
        private TextBox textBoxDecodingJPEG;
        private TextBox textBoxDecodingTIFF;
        private TextBox textBoxDecodingBMP;
        private TextBox textBoxEncodingJPEG;
        private TextBox textBoxEncodingTIFF;
        private TextBox textBoxEncodingBMP;
        private TextBox textBoxReadingJPEG;
        private TextBox textBoxReadingTIFF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxReadingBMP;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label18;
        private TextBox textBox3;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label16;
        private TextBox textBox12;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label23;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label15;
        private Label label17;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox textBox6;
        private Label label22;
        private TableLayoutPanel tableLayoutPanel7;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton RGB_rb;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox17;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox9;
        private Label label28;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label29;
        private TextBox textBox35;
        private TextBox textBox34;
        private TextBox textBox33;
        private TextBox textBox32;
        private TextBox textBox31;
        private TextBox textBox30;
        private TextBox textBox29;
        private TextBox textBox28;
        private TextBox textBox27;
        private TextBox textBox26;
        private TextBox textBox25;
        private TextBox textBox24;
        private TextBox textBox23;
        private TextBox textBox22;
        private TextBox textBox21;
        private TextBox textBox20;
        private TextBox textBox19;
        private TextBox textBox18;
    }
}
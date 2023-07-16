using ImageMagick;
using System.Diagnostics;
using System.Drawing.Imaging;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using ImageMagick;
using System.Linq;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImageProcessingLab1
{
    public partial class Form1 : Form
    {
        private Image BmpImage;
        private byte[] bmpBytes;
        private string filePath;
        private string bmp_filePath;
        private string tif_filePath;
        private string jpeg_filePath;
        private string current_file;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Set the size mode to Zoom to fit the image

        }

        public object ConvertSize(long value)
        {
            double length = Convert.ToDouble(value);
            string[] sizes = new string[4] { "B", "KB", "MB", "GB" };
            int type = 0;
            while (length >= 1024)
            {
                length /= 1024;
                ++type;
            }
            return $"{Math.Round(length, 2)} {sizes[type]}";
        }

        public object ConvertTime(object value)
        {
            double time = Convert.ToDouble(value);
            if (time < 1000)
            {
                return $"{time} ms";
            }
            return $"{(int)time / 1000} s {(int)time % 1000} ms";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file dialog to select image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP files (*.bmp)|*.bmp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                bmpBytes = File.ReadAllBytes(filePath);
                BmpImage = Image.FromFile(filePath);
                pictureBox1.Image = BmpImage;
                var SizeBeforeCompressing = new FileInfo(filePath).Length;
                textBox3.Text = ConvertSize(SizeBeforeCompressing).ToString();
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void formatBMRRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "bmp(*.bmp)|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp_filePath = sfd.FileName;

                var compression = new MagickReadSettings
                {
                    Compression = CompressionMethod.RLE
                };

                var stopWatch = new Stopwatch();
                stopWatch.Start();
                var image = new MagickImage(bmpBytes, compression);

                var imageBytes = image.ToByteArray(MagickFormat.Bmp);
                stopWatch.Stop();
                textBoxEncodingBMP.Text = ConvertTime(stopWatch.Elapsed.TotalMilliseconds).ToString();
                stopWatch.Reset();

                stopWatch.Start();
                File.WriteAllBytes(sfd.FileName, imageBytes);
                stopWatch.Stop();
                textBoxRecordBMP.Text = ConvertTime(stopWatch.Elapsed.Milliseconds).ToString();
                stopWatch.Reset();

                stopWatch.Start();
                var rleBytes = File.ReadAllBytes(sfd.FileName);
                stopWatch.Stop();
                textBoxReadingBMP.Text = ConvertTime(stopWatch.Elapsed.Milliseconds).ToString();
                stopWatch.Reset();

                stopWatch.Start();
                var rleImage = new MagickImage(rleBytes);
                stopWatch.Stop();
                textBoxDecodingBMP.Text = ConvertTime(stopWatch.Elapsed.TotalMilliseconds).ToString();

                var SizeAfterCompressing = new FileInfo(sfd.FileName).Length;
                textBox12.Text = ConvertSize(SizeAfterCompressing).ToString();

                var img = Image.FromFile(sfd.FileName);
                pictureBox1.Image = img;
            }
        }


        private void formatTIFFLZWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "tif(*.tif)|*.tif";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tif_filePath = sfd.FileName;

                var compression = new MagickReadSettings
                {
                    Compression = CompressionMethod.LZW
                };

                var stopWatch = new Stopwatch();
                stopWatch.Start();
                var image = new MagickImage(bmpBytes, compression);
                var imageBytes = image.ToByteArray(MagickFormat.Tiff);
                stopWatch.Stop();
                textBoxEncodingTIFF.Text = ConvertTime(stopWatch.Elapsed.TotalMilliseconds).ToString();
                stopWatch.Reset();

                stopWatch.Start();
                File.WriteAllBytes(sfd.FileName, imageBytes);
                stopWatch.Stop();
                textBoxRecordTIFF.Text = ConvertTime(stopWatch.Elapsed.Milliseconds).ToString();
                stopWatch.Reset();

                stopWatch.Start();
                var lzwBytes = File.ReadAllBytes(sfd.FileName);
                stopWatch.Stop();
                textBoxReadingTIFF.Text = ConvertTime(stopWatch.Elapsed.Milliseconds).ToString();
                stopWatch.Reset();

                stopWatch.Start();
                var lzwImage = new MagickImage(lzwBytes);
                stopWatch.Stop();
                textBoxDecodingTIFF.Text = ConvertTime(stopWatch.Elapsed.TotalMilliseconds).ToString();

                var sizeAfterCompressing = new FileInfo(sfd.FileName).Length;
                textBox11.Text = ConvertSize(sizeAfterCompressing).ToString();

                var img = Image.FromFile(sfd.FileName);
                pictureBox1.Image = img;
            }
        }

        private void formatJPEGSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpeg(*.jpeg)|*.jpeg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                jpeg_filePath = sfd.FileName;

                var compression = new MagickReadSettings
                {
                    Compression = CompressionMethod.JPEG
                };

                var stopWatch = new Stopwatch();
                stopWatch.Start();
                var image = new MagickImage(bmpBytes, compression);
                var imageBytes = image.ToByteArray(MagickFormat.Jpeg);
                stopWatch.Stop();
                textBoxEncodingJPEG.Text = ConvertTime(stopWatch.Elapsed.TotalMilliseconds).ToString();
                stopWatch.Reset();

                stopWatch.Start();
                File.WriteAllBytes(sfd.FileName, imageBytes);
                stopWatch.Stop();
                textBoxRecordJPEG.Text = ConvertTime(stopWatch.Elapsed.Milliseconds).ToString();
                stopWatch.Reset();

                stopWatch.Start();
                var jpegBytes = File.ReadAllBytes(sfd.FileName);
                stopWatch.Stop();
                textBoxReadingJPEG.Text = ConvertTime(stopWatch.Elapsed.Milliseconds).ToString();
                stopWatch.Reset();

                stopWatch.Start();
                var decode = new MagickImage(jpegBytes);
                stopWatch.Stop();
                textBoxDecodingJPEG.Text = ConvertTime(stopWatch.Elapsed.TotalMilliseconds).ToString();

                var sizeAfterCompressing = new FileInfo(sfd.FileName).Length;
                textBox10.Text = ConvertSize(sizeAfterCompressing).ToString();

                var img = Image.FromFile(sfd.FileName);
                pictureBox1.Image = img;
            }
        }

        private int[] ImagesDifference(string compressedFilePath)
        {
            var compressedFileName = Path.GetFileNameWithoutExtension(compressedFilePath);
            var bmpImage = new Bitmap(filePath);
            var redBmpImage = new Bitmap(filePath);
            var greenBmpImage = new Bitmap(filePath);
            var blueBmpImage = new Bitmap(filePath);
            var otherImage = new Bitmap(Image.FromFile(compressedFilePath));

            var colors = new short[bmpImage.Width, bmpImage.Height, 3];
            var mins = new int[3] { 255, 255, 255 };
            var maxs = new int[3] { 0, 0, 0 };
            var amounts = new int[3];

            for (var i = 0; i < bmpImage.Width; i++)
            {
                for (var j = 0; j < bmpImage.Height; j++)
                {
                    var minusRlePixel = otherImage.GetPixel(i, j);
                    var minusBmpPixel = bmpImage.GetPixel(i, j);

                    colors[i, j, 0] = (short)Math.Abs(minusBmpPixel.R - minusRlePixel.R);
                    colors[i, j, 1] = (short)Math.Abs(minusBmpPixel.G - minusRlePixel.G);
                    colors[i, j, 2] = (short)Math.Abs(minusBmpPixel.B - minusRlePixel.B);

                    for (var k = 0; k < 3; k++)
                    {
                        var dif = colors[i, j, k];
                        if (dif > 0)
                            amounts[k]++;

                        if (dif < mins[k])
                            mins[k] = dif;

                        if (dif > maxs[k])
                            maxs[k] = dif;
                    }
                }
            }

            for (var i = 0; i < bmpImage.Width; i++)
            {
                for (var j = 0; j < bmpImage.Height; j++)
                {
                    var newColors = new int[3];
                    for (var k = 0; k < 3; k++)
                    {
                        var color = colors[i, j, k];
                        newColors[k] = NormalizedColor(color, maxs[k], mins[k]);
                    }

                    redBmpImage.SetPixel(i, j, Color.FromArgb(newColors[0], 0, 0));
                    greenBmpImage.SetPixel(i, j, Color.FromArgb(0, newColors[1], 0));
                    blueBmpImage.SetPixel(i, j, Color.FromArgb(0, 0, newColors[2]));
                    bmpImage.SetPixel(i, j, Color.FromArgb(newColors[0], newColors[1], newColors[2]));
                }
            }

            bmpImage.Save($"{filePath}_minus_{compressedFileName}.bmp");
            redBmpImage.Save($"{filePath}_minus_{compressedFileName}_red.bmp");
            greenBmpImage.Save($"{filePath}_minus_{compressedFileName}_green.bmp");
            blueBmpImage.Save($"{filePath}_minus_{compressedFileName}_blue.bmp");
            return amounts;
        }

        private static int NormalizedColor(int x, int maxX, int minX)
        {
            var range = maxX - minX;
            if (range == 0)
            {
                return 0;
            }

            var normalized = (int)((x - minX) / (double)range * 255);
            return Math.Max(Math.Min(normalized, 255), 0);
        }


        private void bMRTIFFLZWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var amounts = ImagesDifference(bmp_filePath);
            var compressedFileName = Path.GetFileNameWithoutExtension(bmp_filePath);
            current_file = bmp_filePath;
            textBox6.Text = amounts[0].ToString();
            textBox9.Text = amounts[1].ToString();
            textBox15.Text = amounts[2].ToString();
            pictureBox1.Image = RGB_rb.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_red.bmp")
                            : radioButton2.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_green.bmp")
                            : radioButton3.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_blue.bmp")
                            : radioButton1.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}.bmp")
                            : null;

            var imageToCompare = new MagickImage(bmp_filePath);
            var initialImage = new MagickImage(filePath);
            var format = imageToCompare.Format.ToString().ToLower();
            var bitDepth = imageToCompare.DetermineBitDepth();

            var result = imageToCompare.Format == MagickFormat.Bmp ? $"{bitDepth}bpp {format}" : format;

            Console.WriteLine();

            var jpegRedMse = imageToCompare.Compare(initialImage, ErrorMetric.RootMeanSquared, Channels.Red);
            var jpegGreenMse = imageToCompare.Compare(initialImage, ErrorMetric.RootMeanSquared, Channels.Green);
            var jpegBlueMse = imageToCompare.Compare(initialImage, ErrorMetric.RootMeanSquared, Channels.Blue);

            textBox18.Text = jpegRedMse.ToString();
            textBox21.Text = jpegGreenMse.ToString();
            textBox24.Text = jpegBlueMse.ToString();

            var jpegRedPsnr = imageToCompare.Compare(initialImage, ErrorMetric.PeakSignalToNoiseRatio, Channels.Red);
            var jpegGreenPsnr = imageToCompare.Compare(initialImage, ErrorMetric.PeakSignalToNoiseRatio, Channels.Green);
            var jpegBluePsnr = imageToCompare.Compare(initialImage, ErrorMetric.PeakSignalToNoiseRatio, Channels.Blue);

            textBox27.Text = jpegRedPsnr.ToString();
            textBox30.Text = jpegGreenPsnr.ToString();
            textBox33.Text = jpegBluePsnr.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = RGB_rb.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_red.bmp")
                            : radioButton2.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_green.bmp")
                            : radioButton3.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_blue.bmp")
                            : radioButton1.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}.bmp")
                            : null;
        }

        private void RGB_rb_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = RGB_rb.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_red.bmp")
                            : radioButton2.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_green.bmp")
                            : radioButton3.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_blue.bmp")
                            : radioButton1.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}.bmp")
                            : null;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var compressedFileName = Path.GetFileNameWithoutExtension(bmp_filePath);
            pictureBox1.Image = RGB_rb.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_red.bmp")
                            : radioButton2.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_green.bmp")
                            : radioButton3.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_blue.bmp")
                            : radioButton1.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}.bmp")
                            : null;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var compressedFileName = Path.GetFileNameWithoutExtension(bmp_filePath);
            pictureBox1.Image = RGB_rb.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_red.bmp")
                            : radioButton2.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_green.bmp")
                            : radioButton3.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_blue.bmp")
                            : radioButton1.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}.bmp")
                            : null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bMRJPEGSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var amounts = ImagesDifference(tif_filePath);
            var compressedFileName = Path.GetFileNameWithoutExtension(tif_filePath);
            current_file = tif_filePath;
            textBox5.Text = amounts[0].ToString();
            textBox13.Text = amounts[1].ToString();
            textBox16.Text = amounts[2].ToString();
            pictureBox1.Image = RGB_rb.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_red.bmp")
                            : radioButton2.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_green.bmp")
                            : radioButton3.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_blue.bmp")
                            : radioButton1.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}.bmp")
                            : null;

            var imageToCompare = new MagickImage(tif_filePath);
            var initialImage = new MagickImage(filePath);
            var format = imageToCompare.Format.ToString().ToLower();
            var bitDepth = imageToCompare.DetermineBitDepth();

            var jpegRedMse = imageToCompare.Compare(initialImage, ErrorMetric.RootMeanSquared, Channels.Red);
            var jpegGreenMse = imageToCompare.Compare(initialImage, ErrorMetric.RootMeanSquared, Channels.Green);
            var jpegBlueMse = imageToCompare.Compare(initialImage, ErrorMetric.RootMeanSquared, Channels.Blue);

            textBox19.Text = jpegRedMse.ToString();
            textBox22.Text = jpegGreenMse.ToString();
            textBox25.Text = jpegBlueMse.ToString();

            var jpegRedPsnr = imageToCompare.Compare(initialImage, ErrorMetric.PeakSignalToNoiseRatio, Channels.Red);
            var jpegGreenPsnr = imageToCompare.Compare(initialImage, ErrorMetric.PeakSignalToNoiseRatio, Channels.Green);
            var jpegBluePsnr = imageToCompare.Compare(initialImage, ErrorMetric.PeakSignalToNoiseRatio, Channels.Blue);

            textBox28.Text = jpegRedPsnr.ToString();
            textBox31.Text = jpegGreenPsnr.ToString();
            textBox34.Text = jpegBluePsnr.ToString();
        }

        private void tIFFJPEGSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var amounts = ImagesDifference(jpeg_filePath);
            var compressedFileName = Path.GetFileNameWithoutExtension(jpeg_filePath);
            current_file = jpeg_filePath;
            textBox4.Text = amounts[0].ToString();
            textBox14.Text = amounts[1].ToString();
            textBox17.Text = amounts[2].ToString();
            pictureBox1.Image = RGB_rb.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_red.bmp")
                            : radioButton2.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_green.bmp")
                            : radioButton3.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}_blue.bmp")
                            : radioButton1.Checked ? Image.FromFile($"{filePath}_minus_{Path.GetFileNameWithoutExtension(current_file)}.bmp")
                            : null;
            var imageToCompare = new MagickImage(jpeg_filePath);
            var initialImage = new MagickImage(filePath);
            var format = imageToCompare.Format.ToString().ToLower();
            var bitDepth = imageToCompare.DetermineBitDepth();

            var result = imageToCompare.Format == MagickFormat.Bmp ? $"{bitDepth}bpp {format}" : format;

            Console.WriteLine();

            var jpegRedMse = imageToCompare.Compare(initialImage, ErrorMetric.RootMeanSquared, Channels.Red);
            var jpegGreenMse = imageToCompare.Compare(initialImage, ErrorMetric.RootMeanSquared, Channels.Green);
            var jpegBlueMse = imageToCompare.Compare(initialImage, ErrorMetric.RootMeanSquared, Channels.Blue);

            textBox20.Text = jpegRedMse.ToString();
            textBox23.Text = jpegGreenMse.ToString();
            textBox26.Text = jpegBlueMse.ToString();

            var jpegRedPsnr = imageToCompare.Compare(initialImage, ErrorMetric.PeakSignalToNoiseRatio, Channels.Red);
            var jpegGreenPsnr = imageToCompare.Compare(initialImage, ErrorMetric.PeakSignalToNoiseRatio, Channels.Green);
            var jpegBluePsnr = imageToCompare.Compare(initialImage, ErrorMetric.PeakSignalToNoiseRatio, Channels.Blue);

            textBox29.Text = jpegRedPsnr.ToString();
            textBox32.Text = jpegGreenPsnr.ToString();
            textBox35.Text = jpegBluePsnr.ToString();
        }
    }
}
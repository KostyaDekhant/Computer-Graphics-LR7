namespace Computer_Graphics_LR7
{
    public partial class Form1 : Form
    {
        private Image image;
        private Image img;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar_init(tB_filter_size);
            tB_filter_size.Maximum = 11;
            trackBar_init(tB_sigma);
            tB_sigma.Maximum = 500;
            trackBar_init(tB_scale);
        }

        private void trackBar_init(TrackBar trackBar)
        {
            trackBar.Minimum = 1;
            trackBar.Maximum = 100;
            trackBar.Value = 1;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите изображение";
                openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Все файлы|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    image = Image.FromFile(filePath);   //Хранит в себе загруженную фотографию в первоначальном виде
                    img = image;                        //Хранит в себе копию выбранного фото для дальнейших преобразований
                    panel_img.Invalidate();             //Перерисовка панели, где будет отображаться само фото
                }
            }
        }

        private void ApplyGaussianFilter(int filterSize, double sigma)
        {
            Bitmap bitmap = new Bitmap(img);
            double[,] gaussianKernel = CreateGaussianKernel(filterSize, sigma);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    double r = 0, g = 0, b = 0;

                    for (int i = -filterSize / 2; i <= filterSize / 2; i++)
                    {
                        for (int j = -filterSize / 2; j <= filterSize / 2; j++)
                        {
                            int newX = Math.Min(Math.Max(x + i, 0), bitmap.Width - 1);
                            int newY = Math.Min(Math.Max(y + j, 0), bitmap.Height - 1);
                            Color color = bitmap.GetPixel(newX, newY);

                            r += color.R * gaussianKernel[i + filterSize / 2, j + filterSize / 2];
                            g += color.G * gaussianKernel[i + filterSize / 2, j + filterSize / 2];
                            b += color.B * gaussianKernel[i + filterSize / 2, j + filterSize / 2];
                        }
                    }
                    r = Math.Min(Math.Max(r, 0), 255);
                    g = Math.Min(Math.Max(g, 0), 255);
                    b = Math.Min(Math.Max(b, 0), 255);
                    bitmap.SetPixel(x, y, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }

            img = bitmap;
            panel_img.Invalidate();
        }

        private double[,] CreateGaussianKernel(int size, double sigma)
        {
            double[,] kernel = new double[size, size];
            int halfSize = size / 2;
            double total = 0;

            for (int x = -halfSize; x <= halfSize; x++)
            {
                for (int y = -halfSize; y <= halfSize; y++)
                {
                    double g = Math.Exp(-(x * x + y * y) / (2 * sigma * sigma)) / (2 * Math.PI * sigma * sigma);
                    kernel[x + halfSize, y + halfSize] = g;
                    total += g;
                }
            }

            // Нормализация
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] /= total;
                }
            }

            return kernel;
        }

        private void neigh_bttn_Click(object sender, EventArgs e)
        {
            if (image == null) return;

            float scaleFactor = (float)tB_scale.Value / 10;

            Bitmap bitmap = new Bitmap(img);
            int newWidth = (int)(bitmap.Width * scaleFactor);
            int newHeight = (int)(bitmap.Height * scaleFactor);
            Bitmap newBitmap = new Bitmap(newWidth, newHeight);

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int originalX = (int)(x / scaleFactor);
                    int originalY = (int)(y / scaleFactor);
                    newBitmap.SetPixel(x, y, bitmap.GetPixel(originalX, originalY));
                }
            }

            img = newBitmap;
            panel_img.Invalidate();
        }

        private void bilinear_bttn_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            float scaleFactor = (float)tB_scale.Value / 10;

            Bitmap bitmap = new Bitmap(img);
            int newWidth = (int)(bitmap.Width * scaleFactor);
            int newHeight = (int)(bitmap.Height * scaleFactor);
            Bitmap newBitmap = new Bitmap(newWidth, newHeight);

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    float originalX = x / scaleFactor;
                    float originalY = y / scaleFactor;

                    int x1 = (int)Math.Floor(originalX);
                    int y1 = (int)Math.Floor(originalY);
                    int x2 = Math.Min(x1 + 1, bitmap.Width - 1);
                    int y2 = Math.Min(y1 + 1, bitmap.Height - 1);

                    Color color1 = bitmap.GetPixel(x1, y1);
                    Color color2 = bitmap.GetPixel(x2, y1);
                    Color color3 = bitmap.GetPixel(x1, y2);
                    Color color4 = bitmap.GetPixel(x2, y2);

                    float xFraction = originalX - x1;
                    float yFraction = originalY - y1;

                    Color topColor = InterpolateColors(color1, color2, xFraction);
                    Color bottomColor = InterpolateColors(color3, color4, xFraction);

                    Color finalColor = InterpolateColors(topColor, bottomColor, yFraction);
                    newBitmap.SetPixel(x, y, finalColor);
                }
            }
            img = newBitmap;
            panel_img.Invalidate();

        }

        //Метод для интерполяции цветов
        private static Color InterpolateColors(Color color1, Color color2, float fraction)
        {
            int r = (int)(color1.R + (color2.R - color1.R) * fraction);
            int g = (int)(color1.G + (color2.G - color1.G) * fraction);
            int b = (int)(color1.B + (color2.B - color1.B) * fraction);
            return Color.FromArgb(r, g, b);
        }

        private void gaussian_filter_bttn_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            int filter_size = tB_filter_size.Value;
            double sigma = (double)tB_sigma.Value / 100;
            ApplyGaussianFilter(filter_size, sigma);
        }

        private void tB_scale_Scroll(object sender, EventArgs e)
        {
            scale_lb.Text = (((double)tB_scale.Value / 10)).ToString();
        }

        private void tB_filter_size_Scroll(object sender, EventArgs e)
        {
            if (tB_filter_size.Value % 2 == 0)
                tB_filter_size.Value = tB_filter_size.Value + 1;
            filter_size_lb.Text = (tB_filter_size.Value).ToString();
        }

        private void tB_sigma_Scroll(object sender, EventArgs e)
        {
            sigma_lb.Text = (((double)tB_sigma.Value / 100)).ToString();
        }

        private void panel_img_Paint(object sender, PaintEventArgs e)
        {
            if (image != null)
            {
                groupB.Width = img.Width + 20;
                groupB.Height = img.Height + 20;
                e.Graphics.DrawImage(new Bitmap(img), 0, 0);
            }
        }


        private void восстановитьФотоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image == null) return;

            img = image;
            panel_img.Invalidate();
        }
    }
}

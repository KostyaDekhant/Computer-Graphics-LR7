namespace Computer_Graphics_LR7
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            другоеToolStripMenuItem = new ToolStripMenuItem();
            восстановитьФотоToolStripMenuItem = new ToolStripMenuItem();
            groupB = new GroupBox();
            panel_img = new Panel();
            groupB_params = new GroupBox();
            filter_size_lb = new Label();
            tB_filter_size = new TrackBar();
            sigma_lb = new Label();
            tB_sigma = new TrackBar();
            gaussian_filter_bttn = new Button();
            circ_lb = new Label();
            scale_lb = new Label();
            bilinear_bttn = new Button();
            neigh_bttn = new Button();
            tB_scale = new TrackBar();
            menuStrip1.SuspendLayout();
            groupB.SuspendLayout();
            groupB_params.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tB_filter_size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tB_sigma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tB_scale).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, другоеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1185, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(150, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // другоеToolStripMenuItem
            // 
            другоеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { восстановитьФотоToolStripMenuItem });
            другоеToolStripMenuItem.Name = "другоеToolStripMenuItem";
            другоеToolStripMenuItem.Size = new Size(72, 24);
            другоеToolStripMenuItem.Text = "Другое";
            // 
            // восстановитьФотоToolStripMenuItem
            // 
            восстановитьФотоToolStripMenuItem.Name = "восстановитьФотоToolStripMenuItem";
            восстановитьФотоToolStripMenuItem.Size = new Size(225, 26);
            восстановитьФотоToolStripMenuItem.Text = "Восстановить фото";
            восстановитьФотоToolStripMenuItem.Click += восстановитьФотоToolStripMenuItem_Click;
            // 
            // groupB
            // 
            groupB.Controls.Add(panel_img);
            groupB.Location = new Point(580, 31);
            groupB.Name = "groupB";
            groupB.Size = new Size(530, 435);
            groupB.TabIndex = 4;
            groupB.TabStop = false;
            // 
            // panel_img
            // 
            panel_img.Dock = DockStyle.Fill;
            panel_img.Location = new Point(3, 23);
            panel_img.Name = "panel_img";
            panel_img.Size = new Size(524, 409);
            panel_img.TabIndex = 0;
            panel_img.Paint += panel_img_Paint;
            // 
            // groupB_params
            // 
            groupB_params.Controls.Add(filter_size_lb);
            groupB_params.Controls.Add(tB_filter_size);
            groupB_params.Controls.Add(sigma_lb);
            groupB_params.Controls.Add(tB_sigma);
            groupB_params.Controls.Add(gaussian_filter_bttn);
            groupB_params.Controls.Add(circ_lb);
            groupB_params.Controls.Add(scale_lb);
            groupB_params.Controls.Add(bilinear_bttn);
            groupB_params.Controls.Add(neigh_bttn);
            groupB_params.Controls.Add(tB_scale);
            groupB_params.Location = new Point(12, 31);
            groupB_params.Name = "groupB_params";
            groupB_params.Size = new Size(562, 572);
            groupB_params.TabIndex = 5;
            groupB_params.TabStop = false;
            // 
            // filter_size_lb
            // 
            filter_size_lb.AutoSize = true;
            filter_size_lb.Location = new Point(364, 231);
            filter_size_lb.Name = "filter_size_lb";
            filter_size_lb.Size = new Size(17, 20);
            filter_size_lb.TabIndex = 13;
            filter_size_lb.Text = "1";
            // 
            // tB_filter_size
            // 
            tB_filter_size.Location = new Point(21, 231);
            tB_filter_size.Name = "tB_filter_size";
            tB_filter_size.Size = new Size(337, 56);
            tB_filter_size.TabIndex = 12;
            tB_filter_size.Scroll += tB_filter_size_Scroll;
            // 
            // sigma_lb
            // 
            sigma_lb.AutoSize = true;
            sigma_lb.Location = new Point(364, 300);
            sigma_lb.Name = "sigma_lb";
            sigma_lb.Size = new Size(28, 20);
            sigma_lb.TabIndex = 11;
            sigma_lb.Text = "0,1";
            // 
            // tB_sigma
            // 
            tB_sigma.Location = new Point(21, 300);
            tB_sigma.Name = "tB_sigma";
            tB_sigma.Size = new Size(337, 56);
            tB_sigma.TabIndex = 10;
            tB_sigma.Scroll += tB_sigma_Scroll;
            // 
            // gaussian_filter_bttn
            // 
            gaussian_filter_bttn.Location = new Point(403, 258);
            gaussian_filter_bttn.Name = "gaussian_filter_bttn";
            gaussian_filter_bttn.Size = new Size(133, 29);
            gaussian_filter_bttn.TabIndex = 9;
            gaussian_filter_bttn.Text = "фильтр гаусса";
            gaussian_filter_bttn.UseVisualStyleBackColor = true;
            gaussian_filter_bttn.Click += gaussian_filter_bttn_Click;
            // 
            // circ_lb
            // 
            circ_lb.AutoSize = true;
            circ_lb.Location = new Point(364, 154);
            circ_lb.Name = "circ_lb";
            circ_lb.Size = new Size(13, 20);
            circ_lb.TabIndex = 8;
            circ_lb.Text = " ";
            // 
            // scale_lb
            // 
            scale_lb.AutoSize = true;
            scale_lb.Location = new Point(508, 26);
            scale_lb.Name = "scale_lb";
            scale_lb.Size = new Size(28, 20);
            scale_lb.TabIndex = 6;
            scale_lb.Text = "0,1";
            // 
            // bilinear_bttn
            // 
            bilinear_bttn.Location = new Point(334, 88);
            bilinear_bttn.Name = "bilinear_bttn";
            bilinear_bttn.Size = new Size(202, 29);
            bilinear_bttn.TabIndex = 3;
            bilinear_bttn.Text = "Билинейное сглаживание";
            bilinear_bttn.UseVisualStyleBackColor = true;
            bilinear_bttn.Click += bilinear_bttn_Click;
            // 
            // neigh_bttn
            // 
            neigh_bttn.Location = new Point(21, 88);
            neigh_bttn.Name = "neigh_bttn";
            neigh_bttn.Size = new Size(202, 29);
            neigh_bttn.TabIndex = 1;
            neigh_bttn.Text = "Ближ. соседа";
            neigh_bttn.UseVisualStyleBackColor = true;
            neigh_bttn.Click += neigh_bttn_Click;
            // 
            // tB_scale
            // 
            tB_scale.Location = new Point(21, 26);
            tB_scale.Name = "tB_scale";
            tB_scale.Size = new Size(481, 56);
            tB_scale.TabIndex = 0;
            tB_scale.Scroll += tB_scale_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 647);
            Controls.Add(groupB_params);
            Controls.Add(groupB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupB.ResumeLayout(false);
            groupB_params.ResumeLayout(false);
            groupB_params.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tB_filter_size).EndInit();
            ((System.ComponentModel.ISupportInitialize)tB_sigma).EndInit();
            ((System.ComponentModel.ISupportInitialize)tB_scale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private GroupBox groupB;
        private Panel panel_img;
        private GroupBox groupB_params;
        private Label filter_size_lb;
        private TrackBar tB_filter_size;
        private Label sigma_lb;
        private TrackBar tB_sigma;
        private Button gaussian_filter_bttn;
        private Label circ_lb;
        private Label scale_lb;
        private Button bilinear_bttn;
        private Button neigh_bttn;
        private TrackBar tB_scale;
        private ToolStripMenuItem другоеToolStripMenuItem;
        private ToolStripMenuItem восстановитьФотоToolStripMenuItem;
    }
}

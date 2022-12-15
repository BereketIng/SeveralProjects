namespace TestImageControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.ImageList = this.imageCollection1;
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.imageSlider1.Location = new System.Drawing.Point(1341, 482);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(492, 734);
            this.imageSlider1.TabIndex = 0;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(1000, 1000);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "_120422292_africa_coups_dec-nc.png");
            this.imageCollection1.Images.SetKeyName(1, "10.1_Menelik_Lion.jpg");
            this.imageCollection1.Images.SetKeyName(2, "1234.png");
            this.imageCollection1.Images.SetKeyName(3, "241133191_1255196504941190_1952835435219191559_n.jpg");
            this.imageCollection1.Images.SetKeyName(4, "6142824705_d350b22a0b_o.jpg");
            this.imageCollection1.Images.SetKeyName(5, "django-leonardo-di-caprio-samuel-jackson-slave-colonial-ftr.jpg");
            this.imageCollection1.Images.SetKeyName(6, "DS-70000_LT_ANG.jpg");
            this.imageCollection1.Images.SetKeyName(7, "Fotter 1.bmp");
            this.imageCollection1.Images.SetKeyName(8, "Fotter 2.bmp");
            this.imageCollection1.Images.SetKeyName(9, "Fotter 3.bmp");
            this.imageCollection1.Images.SetKeyName(10, "Marvel-Movie-Universe.jpg");
            this.imageCollection1.Images.SetKeyName(11, "maxresdefault.jpg");
            this.imageCollection1.Images.SetKeyName(12, "MEL_MCUTimeline.jpg");
            this.imageCollection1.Images.SetKeyName(13, "mitu.jpg");
            this.imageCollection1.Images.SetKeyName(14, "photo_2020-11-29_08-46-37.jpg");
            this.imageCollection1.Images.SetKeyName(15, "photo_2020-11-29_08-46-38.jpg");
            this.imageCollection1.Images.SetKeyName(16, "photo_2021-08-11_12-25-38.jpg");
            this.imageCollection1.Images.SetKeyName(17, "photo_2021-08-11_12-25-39.jpg");
            this.imageCollection1.Images.SetKeyName(18, "photo_2021-08-11_12-41-34.jpg");
            this.imageCollection1.Images.SetKeyName(19, "Result_Format.bmp");
            this.imageCollection1.Images.SetKeyName(20, "Semeret.jpg");
            this.imageCollection1.Images.SetKeyName(21, "The-Falcon-and-the-Winter-Soldier.jpg");
            this.imageCollection1.Images.SetKeyName(22, "Theme1.png");
            this.imageCollection1.Images.SetKeyName(23, "Theme2.png");
            this.imageCollection1.Images.SetKeyName(24, "TigrayChildrens.png");
            this.imageCollection1.Images.SetKeyName(25, "WandaVision.jpg");
            this.imageCollection1.Images.SetKeyName(26, "yy.jpg");
            this.imageCollection1.Images.SetKeyName(27, "Zebra GC420t.png");
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.Dock = System.Windows.Forms.DockStyle.Left;
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Image Group Test";
            galleryItem1.Caption = "Item2";
            galleryItem1.ImageOptions.ImageIndex = 1;
            galleryItem2.Caption = "Item3";
            galleryItem2.ImageOptions.ImageIndex = 2;
            galleryItem3.Caption = "Item4";
            galleryItem3.ImageOptions.ImageIndex = 3;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3});
            this.galleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryControl1.Gallery.Images = this.imageCollection1;
            this.galleryControl1.Location = new System.Drawing.Point(0, 0);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(720, 733);
            this.galleryControl1.TabIndex = 1;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(699, 729);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.DocumentFilePath = "C:\\Users\\HP\\Desktop\\Habesha Tender Home of Business Opportunities (www.habeshaten" +
    "der.com).pdf";
            this.pdfViewer1.Location = new System.Drawing.Point(720, 0);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(891, 733);
            this.pdfViewer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 733);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.galleryControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF2IMG_Binder
{
    public partial class Form1 : Form
    {
        string version = "version: 1.1";
        string txtPath = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            clearFiles();
           

            openFileDialog1.ShowDialog();
            txtPath = openFileDialog1.FileName;

            try
            {

                run();

                CombineImages();
                clearFiles();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error  | Ayad");
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            
        }


        private void CombineImages(string path="")
        {
            DirectoryInfo directory;
            if (path =="")
                directory = new DirectoryInfo("temp");
            else
                directory = new DirectoryInfo(path);

            FileInfo[] files = directory.GetFiles();
                
            
            //change the location to store the final image.
            string finalImage = Path.Combine(txtSavePath.Text,"FinalImage.jpg");
            List<int> imageHeights = new List<int>();

            int nIndex = 0;
            int width = 0;


            foreach (FileInfo file in files)
            {
                Image img = Image.FromFile(file.FullName);
                imageHeights.Add(img.Height);
                width += img.Width;
                img.Dispose();
            }



            imageHeights.Sort();

            int height = imageHeights[imageHeights.Count - 1];

            Bitmap img3 = new Bitmap(width, height);

            Graphics g = Graphics.FromImage(img3);
            g.Clear(SystemColors.AppWorkspace);
            foreach (FileInfo file in files)
            {
                Image img = Image.FromFile(file.FullName);
                if (nIndex == 0)
                {
                    g.DrawImage(img, x: 0, y: 0, width: img.Width, height:img.Height);
                    nIndex++;
                    width = img.Width;
                }
                else
                {
                    g.DrawImage(img, x: width, y: 0, width: img.Width, height: img.Height);
                    width += img.Width;
                }
                img.Dispose();
            }
            g.Dispose();
            img3.Save(finalImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            pictureBox.Image = (Image)img3;
            //img3.Dispose();

           
        }

        void run()
        {
  
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "pdftopng.exe";
            startInfo.Arguments = "\""+ txtPath + "\"" + " temp\\ayad";
            process.StartInfo = startInfo;
            process.Start();
            
            process.WaitForExit(25000);
        }

        void clearFiles()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("temp");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearFiles();
            lblVersion.Text = this.version;
        }

        private void BtnSelectStorePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtSavePath.Text = folderBrowserDialog1.SelectedPath;
        }




        private void BtnCheckUpdate_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ayad0net/PDF2IMG-Binder/releases");
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ayad0net/PDF2IMG-Binder");
        }

        private void BtnDonation_Click(object sender, EventArgs e)
        {
            Process.Start("https://ko-fi.com/ayad0net");
        }

        private void btnSelectImagesFolder_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.ShowDialog();
            
                txtPath = folderBrowserDialog1.SelectedPath;
                CombineImages(txtPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error  | Ayad");
            }

        }
    }
}

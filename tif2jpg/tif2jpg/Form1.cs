using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tif2jpg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _tifPath;
        private string _tifName;
        private void btnTif2jpg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_tifPath))
            {
                if (_tifPath.LastIndexOf(".tif") < 0)
                {
                    MessageBox.Show(@"Selected file is incorret");
                }
                else
                {
                    tif2jpg();
                    MessageBox.Show(@"Success.");
                }
            }
            else
            {
                MessageBox.Show(@"please slecte file");
            }
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            _tifPath = openFileDialog1.FileName; 
            _tifName = Path.GetFileName(openFileDialog1.FileName);
            this.txtPath.Text = _tifPath;
        }

        public void tif2jpg()
        {  
                int len =_tifPath.LastIndexOf(".tif");

                _tifName = _tifName.Substring(0, _tifName.Length - 4);  
                string filePath = Path.GetDirectoryName(_tifPath);

                FileStream stream = File.OpenRead(_tifPath);
                Bitmap bmp = new Bitmap(stream);
                Image image = bmp;
                Guid objGuid = image.FrameDimensionsList[0];
                FrameDimension objDimension = new FrameDimension(objGuid);
                int totFrame = image.GetFrameCount(objDimension);
            this.progressBar1.Maximum = totFrame;
                //  count = totFrame;
                for (int i = 0; i < totFrame; i++)//循环生成多张图片
                {
                    image.SelectActiveFrame(objDimension, i);
                    string newName =string.Format("{0}_{1}.jpg", _tifName,i+1);
                    string newPaht = Path.Combine(filePath, newName);
                    image.Save(newPaht, ImageFormat.Jpeg);
                    this.progressBar1.Value = i + 1;
                }
                bmp.Dispose();
                image.Dispose();
                stream.Close();  

        }

    }
}

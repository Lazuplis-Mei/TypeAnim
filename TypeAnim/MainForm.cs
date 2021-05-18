using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeAnim
{
    public partial class MainForm : Form
    {
        private readonly Process ffmpeg;
        private Size imageSize;
        private string defaultFileName = "anim.mp4";
        private string CommandArgs => $"-f image2 -i images/image%d.jpg -vcodec libx264 -r 100 {defaultFileName}";
        public MainForm()
        {
            InitializeComponent();
            ffmpeg =  new Process();
            ffmpeg.StartInfo.FileName = "ffmpeg.exe";
            ffmpeg.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            ffmpeg.StartInfo.UseShellExecute = true;
            TB_Font.Text = LB_Text.Font.Name;
            Directory.CreateDirectory("images");
            TopMost = !Debugger.IsAttached;
        }

        private void SaveImage(int n)
        {
            LB_Text.Update();
            var bmp = new Bitmap(imageSize.Width, imageSize.Height);
            LB_Text.DrawToBitmap(bmp, new Rectangle(Point.Empty, imageSize));
            bmp.Save(Path.Combine("images", $"image{n}.jpg"), ImageFormat.Jpeg);
        }

        private void PrepareSaveImage()
        {
            LB_Text.Text = TB_Text.Text;
            LB_Text.Update();
            imageSize = (LB_Text.Size / 2)*2;
            ffmpeg.StartInfo.Arguments = CommandArgs;
            Directory.GetFiles("images", "*.jpg").ToList().ForEach(File.Delete);
            File.Delete(defaultFileName);
        }

        private void Btn_SaveAnim_Click(object sender, EventArgs e)
        {
            LB_Text.BorderStyle = BorderStyle.None;
            PrepareSaveImage();
            for (int i = 1; i <= TB_Text.TextLength; i++)
            {
                LB_Text.Text = TB_Text.Text.Substring(0, i);
                SaveImage(i);
            }
            ffmpeg.Start();
            ffmpeg.WaitForExit();
            LB_Text.BorderStyle = BorderStyle.FixedSingle;
        }

        private void TB_Text_TextChanged(object sender, EventArgs e)
        {
            LB_Text.Text = TB_Text.Text;
        }

        private void TB_FileName_TextChanged(object sender, EventArgs e)
        {
            defaultFileName = TB_FileName.Text;
        }

        private void Btn_View_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ffplay.exe", defaultFileName);
            }
            catch
            {

            }
        }

        private void Btn_font_Click(object sender, EventArgs e)
        {
            if (Dlg_font.ShowDialog()== DialogResult.OK)
            {
                LB_Text.Font = Dlg_font.Font;
                TB_Font.Text = LB_Text.Font.Name;
                LB_Text.ForeColor = Dlg_font.Color;
            }
        }
    }
}

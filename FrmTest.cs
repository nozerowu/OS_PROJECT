using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
namespace HazeRemovalTest
{
    public unsafe partial class FrmTest : Form
    {
        // dll的代码中用的是StdCall，这里也要用StdCall，如果用Cdecl，则会出现对 PInvoke 函数“....”的调用导致堆栈不对称错误，再次按F5又可以运行
       
        [DllImport("HazeRemoval.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern void HazeRemovalUseDarkChannelPrior(byte* Src, byte* Dest, int Width, int Height, int Stride, int Radius,int GuideRadius, int MaxAtom, float Omega, float Epsilon, float T0);

        private bool Busy = false;

        public FrmTest()
        {
            InitializeComponent();
        }
     

        private void CmdOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicSrc.Image.Dispose();
                PicDest.Image.Dispose();
                PicSrc.Image = Bitmap.FromFile(openFileDialog.FileName);
                PicDest.Image = Bitmap.FromFile(openFileDialog.FileName);
                Application.DoEvents();
                ShowHazeRemovalResult();
            }
        }

        private void CmdHazeRemoval_Click(object sender, EventArgs e)
        {
            ShowHazeRemovalResult();
        }

        private void ShowHazeRemovalResult()
        {
            Busy = true;
            Bitmap SrcB = (Bitmap)PicSrc.Image;
            Bitmap DstB = (Bitmap)PicDest.Image;
            BitmapData SrcBmpData = SrcB.LockBits(new Rectangle(0, 0, SrcB.Width, SrcB.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData DstBmpData = DstB.LockBits(new Rectangle(0, 0, DstB.Width, DstB.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            Stopwatch Sw = new Stopwatch();
            Sw.Start();
            HazeRemovalUseDarkChannelPrior((byte*)SrcBmpData.Scan0, (byte*)DstBmpData.Scan0, SrcBmpData.Width, SrcBmpData.Height, SrcBmpData.Stride, BlockSize.Value, GuideBlockSize.Value, MaxAtom.Value, Omega.Value * 0.01f, Epsilon.Value * 0.001f, T0.Value * 0.01f);
            Sw.Stop();
            this.Text = Sw.ElapsedMilliseconds.ToString();

            SrcB.UnlockBits(SrcBmpData);
            DstB.UnlockBits(DstBmpData);
            PicDest.Invalidate();
            Busy = false;
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            ShowHazeRemovalResult();
        }

        private void BlockSize_Scroll(object sender, ScrollEventArgs e)
        {
            LblBlockSize.Text = BlockSize.Value.ToString();
            if (Busy==false) ShowHazeRemovalResult();
        }

        private void GuideBlockSize_Scroll(object sender, ScrollEventArgs e)
        {
            LblGuideBlockSize.Text = GuideBlockSize.Value.ToString();
            if (Busy == false) ShowHazeRemovalResult();
        }

        private void Omega_Scroll(object sender, ScrollEventArgs e)
        {
            LblOmega.Text = Omega.Value.ToString() + "%";
            if (Busy == false) ShowHazeRemovalResult();
        }

        private void MaxAtom_Scroll(object sender, ScrollEventArgs e)
        {
            LbLAtom.Text = MaxAtom.Value.ToString();
            if (Busy == false) ShowHazeRemovalResult();
        }

        private void Epsilon_Scroll(object sender, ScrollEventArgs e)
        {
            LblEpsilon.Text = (Epsilon.Value * 0.0001).ToString();
            if (Busy == false) ShowHazeRemovalResult();
        }

        private void T0_Scroll(object sender, ScrollEventArgs e)
        {
            LblT0.Text = (T0.Value * 0.01).ToString();
            if (Busy == false) ShowHazeRemovalResult();
        }

  
    }
}

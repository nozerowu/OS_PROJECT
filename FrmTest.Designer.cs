namespace HazeRemovalTest
{
    unsafe partial class FrmTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            this.LblGuideBlockSize = new System.Windows.Forms.Label();
            this.导向半径 = new System.Windows.Forms.Label();
            this.GuideBlockSize = new System.Windows.Forms.HScrollBar();
            this.LbLAtom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxAtom = new System.Windows.Forms.HScrollBar();
            this.LblBlockSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BlockSize = new System.Windows.Forms.HScrollBar();
            this.CmdHazeRemoval = new System.Windows.Forms.Button();
            this.CmdOpen = new System.Windows.Forms.Button();
            this.PicSrc = new System.Windows.Forms.PictureBox();
            this.PicDest = new System.Windows.Forms.PictureBox();
            this.LblOmega = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Omega = new System.Windows.Forms.HScrollBar();
            this.LblEpsilon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Epsilon = new System.Windows.Forms.HScrollBar();
            this.LblT0 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.T0 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.PicSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDest)).BeginInit();
            this.SuspendLayout();
            // 
            // LblGuideBlockSize
            // 
            this.LblGuideBlockSize.AutoSize = true;
            this.LblGuideBlockSize.Location = new System.Drawing.Point(766, 14);
            this.LblGuideBlockSize.Name = "LblGuideBlockSize";
            this.LblGuideBlockSize.Size = new System.Drawing.Size(17, 12);
            this.LblGuideBlockSize.TabIndex = 32;
            this.LblGuideBlockSize.Text = "50";
            // 
            // 导向半径
            // 
            this.导向半径.AutoSize = true;
            this.导向半径.Location = new System.Drawing.Point(448, 14);
            this.导向半径.Name = "导向半径";
            this.导向半径.Size = new System.Drawing.Size(53, 12);
            this.导向半径.TabIndex = 31;
            this.导向半径.Text = "导向半径";
            // 
            // GuideBlockSize
            // 
            this.GuideBlockSize.LargeChange = 1;
            this.GuideBlockSize.Location = new System.Drawing.Point(504, 14);
            this.GuideBlockSize.Maximum = 400;
            this.GuideBlockSize.Minimum = 20;
            this.GuideBlockSize.Name = "GuideBlockSize";
            this.GuideBlockSize.Size = new System.Drawing.Size(250, 17);
            this.GuideBlockSize.TabIndex = 30;
            this.GuideBlockSize.Value = 50;
            this.GuideBlockSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GuideBlockSize_Scroll);
            // 
            // LbLAtom
            // 
            this.LbLAtom.AutoSize = true;
            this.LbLAtom.Location = new System.Drawing.Point(412, 48);
            this.LbLAtom.Name = "LbLAtom";
            this.LbLAtom.Size = new System.Drawing.Size(23, 12);
            this.LbLAtom.TabIndex = 29;
            this.LbLAtom.Text = "220";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "最大大气光";
            // 
            // MaxAtom
            // 
            this.MaxAtom.LargeChange = 1;
            this.MaxAtom.Location = new System.Drawing.Point(159, 48);
            this.MaxAtom.Maximum = 255;
            this.MaxAtom.Minimum = 100;
            this.MaxAtom.Name = "MaxAtom";
            this.MaxAtom.Size = new System.Drawing.Size(250, 17);
            this.MaxAtom.TabIndex = 27;
            this.MaxAtom.Value = 220;
            this.MaxAtom.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MaxAtom_Scroll);
            // 
            // LblBlockSize
            // 
            this.LblBlockSize.AutoSize = true;
            this.LblBlockSize.Location = new System.Drawing.Point(412, 14);
            this.LblBlockSize.Name = "LblBlockSize";
            this.LblBlockSize.Size = new System.Drawing.Size(17, 12);
            this.LblBlockSize.TabIndex = 26;
            this.LblBlockSize.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "Block大小";
            // 
            // BlockSize
            // 
            this.BlockSize.LargeChange = 1;
            this.BlockSize.Location = new System.Drawing.Point(159, 14);
            this.BlockSize.Minimum = 10;
            this.BlockSize.Name = "BlockSize";
            this.BlockSize.Size = new System.Drawing.Size(250, 17);
            this.BlockSize.TabIndex = 24;
            this.BlockSize.Value = 15;
            this.BlockSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlockSize_Scroll);
            // 
            // CmdHazeRemoval
            // 
            this.CmdHazeRemoval.Location = new System.Drawing.Point(4, 40);
            this.CmdHazeRemoval.Name = "CmdHazeRemoval";
            this.CmdHazeRemoval.Size = new System.Drawing.Size(75, 29);
            this.CmdHazeRemoval.TabIndex = 22;
            this.CmdHazeRemoval.Text = "去雾";
            this.CmdHazeRemoval.UseVisualStyleBackColor = true;
            this.CmdHazeRemoval.Click += new System.EventHandler(this.CmdHazeRemoval_Click);
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(4, 6);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(75, 29);
            this.CmdOpen.TabIndex = 21;
            this.CmdOpen.Text = "打开图像";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // PicSrc
            // 
            this.PicSrc.Image = global::HazeRemovalTest.Properties.Resources._75;
            this.PicSrc.Location = new System.Drawing.Point(12, 75);
            this.PicSrc.Name = "PicSrc";
            this.PicSrc.Size = new System.Drawing.Size(550, 550);
            this.PicSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSrc.TabIndex = 33;
            this.PicSrc.TabStop = false;
            // 
            // PicDest
            // 
            this.PicDest.Image = global::HazeRemovalTest.Properties.Resources._75;
            this.PicDest.Location = new System.Drawing.Point(617, 75);
            this.PicDest.Name = "PicDest";
            this.PicDest.Size = new System.Drawing.Size(550, 550);
            this.PicDest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDest.TabIndex = 34;
            this.PicDest.TabStop = false;
            // 
            // LblOmega
            // 
            this.LblOmega.AutoSize = true;
            this.LblOmega.Location = new System.Drawing.Point(1127, 14);
            this.LblOmega.Name = "LblOmega";
            this.LblOmega.Size = new System.Drawing.Size(23, 12);
            this.LblOmega.TabIndex = 37;
            this.LblOmega.Text = "95%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(807, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "去雾程度";
            // 
            // Omega
            // 
            this.Omega.LargeChange = 1;
            this.Omega.Location = new System.Drawing.Point(863, 14);
            this.Omega.Minimum = 50;
            this.Omega.Name = "Omega";
            this.Omega.Size = new System.Drawing.Size(250, 17);
            this.Omega.TabIndex = 35;
            this.Omega.Value = 95;
            this.Omega.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Omega_Scroll);
            // 
            // LblEpsilon
            // 
            this.LblEpsilon.AutoSize = true;
            this.LblEpsilon.Location = new System.Drawing.Point(766, 48);
            this.LblEpsilon.Name = "LblEpsilon";
            this.LblEpsilon.Size = new System.Drawing.Size(29, 12);
            this.LblEpsilon.TabIndex = 40;
            this.LblEpsilon.Text = "0.01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "Epsilon";
            // 
            // Epsilon
            // 
            this.Epsilon.LargeChange = 1;
            this.Epsilon.Location = new System.Drawing.Point(504, 48);
            this.Epsilon.Maximum = 500;
            this.Epsilon.Minimum = 10;
            this.Epsilon.Name = "Epsilon";
            this.Epsilon.Size = new System.Drawing.Size(250, 17);
            this.Epsilon.TabIndex = 38;
            this.Epsilon.Value = 10;
            this.Epsilon.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Epsilon_Scroll);
            // 
            // LblT0
            // 
            this.LblT0.AutoSize = true;
            this.LblT0.Location = new System.Drawing.Point(1125, 43);
            this.LblT0.Name = "LblT0";
            this.LblT0.Size = new System.Drawing.Size(23, 12);
            this.LblT0.TabIndex = 43;
            this.LblT0.Text = "0.1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(843, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 42;
            this.label8.Text = "T0";
            // 
            // T0
            // 
            this.T0.LargeChange = 1;
            this.T0.Location = new System.Drawing.Point(863, 43);
            this.T0.Maximum = 50;
            this.T0.Minimum = 1;
            this.T0.Name = "T0";
            this.T0.Size = new System.Drawing.Size(250, 17);
            this.T0.TabIndex = 41;
            this.T0.Value = 10;
            this.T0.Scroll += new System.Windows.Forms.ScrollEventHandler(this.T0_Scroll);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 630);
            this.Controls.Add(this.LblT0);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.T0);
            this.Controls.Add(this.LblEpsilon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Epsilon);
            this.Controls.Add(this.LblOmega);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Omega);
            this.Controls.Add(this.PicDest);
            this.Controls.Add(this.PicSrc);
            this.Controls.Add(this.LblGuideBlockSize);
            this.Controls.Add(this.导向半径);
            this.Controls.Add(this.GuideBlockSize);
            this.Controls.Add(this.LbLAtom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxAtom);
            this.Controls.Add(this.LblBlockSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlockSize);
            this.Controls.Add(this.CmdHazeRemoval);
            this.Controls.Add(this.CmdOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图像去雾";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGuideBlockSize;
        private System.Windows.Forms.Label 导向半径;
        private System.Windows.Forms.HScrollBar GuideBlockSize;
        private System.Windows.Forms.Label LbLAtom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar MaxAtom;
        private System.Windows.Forms.Label LblBlockSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar BlockSize;
        private System.Windows.Forms.Button CmdHazeRemoval;
        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.PictureBox PicSrc;
        private System.Windows.Forms.PictureBox PicDest;
        private System.Windows.Forms.Label LblOmega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar Omega;
        private System.Windows.Forms.Label LblEpsilon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar Epsilon;
        private System.Windows.Forms.Label LblT0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar T0;

    }
}



namespace flappygame
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
            this.pipeup = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeup
            // 
            this.pipeup.Image = ((System.Drawing.Image)(resources.GetObject("pipeup.Image")));
            this.pipeup.Location = new System.Drawing.Point(489, 0);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(173, 93);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeup.TabIndex = 0;
            this.pipeup.TabStop = false;
            this.pipeup.Click += new System.EventHandler(this.pipeup_Click);
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(115, 183);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(106, 60);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = ((System.Drawing.Image)(resources.GetObject("pipedown.Image")));
            this.pipedown.Location = new System.Drawing.Point(487, 249);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(173, 93);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipedown.TabIndex = 2;
            this.pipedown.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-2, 337);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(895, 128);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(37, 314);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(51, 20);
            this.Score.TabIndex = 4;
            this.Score.Text = "label1";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 250;
            this.gametimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(893, 466);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeup;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gametimer;
    }
}


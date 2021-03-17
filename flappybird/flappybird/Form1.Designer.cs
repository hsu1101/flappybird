namespace flappybird
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.replay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.h6 = new System.Windows.Forms.PictureBox();
            this.h7 = new System.Windows.Forms.PictureBox();
            this.h5 = new System.Windows.Forms.PictureBox();
            this.h8 = new System.Windows.Forms.PictureBox();
            this.h3 = new System.Windows.Forms.PictureBox();
            this.h4 = new System.Windows.Forms.PictureBox();
            this.h2 = new System.Windows.Forms.PictureBox();
            this.h1 = new System.Windows.Forms.PictureBox();
            this.t2 = new System.Windows.Forms.PictureBox();
            this.t3 = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.h6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 70;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Game Over";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "0";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(389, 267);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 29);
            this.start.TabIndex = 16;
            this.start.Text = "開始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Button1_Click);
            // 
            // replay
            // 
            this.replay.Enabled = false;
            this.replay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.replay.Location = new System.Drawing.Point(496, 267);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(112, 42);
            this.replay.TabIndex = 17;
            this.replay.Text = "再玩一次";
            this.replay.UseVisualStyleBackColor = true;
            this.replay.Visible = false;
            this.replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "分數";
            // 
            // h6
            // 
            this.h6.BackColor = System.Drawing.Color.Gray;
            this.h6.Image = global::flappybird.Properties.Resources._221437059211983;
            this.h6.Location = new System.Drawing.Point(571, -2);
            this.h6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h6.Name = "h6";
            this.h6.Size = new System.Drawing.Size(65, 262);
            this.h6.TabIndex = 12;
            this.h6.TabStop = false;
            // 
            // h7
            // 
            this.h7.BackColor = System.Drawing.Color.Gray;
            this.h7.Image = global::flappybird.Properties.Resources._221437059211983;
            this.h7.Location = new System.Drawing.Point(836, 320);
            this.h7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h7.Name = "h7";
            this.h7.Size = new System.Drawing.Size(68, 269);
            this.h7.TabIndex = 11;
            this.h7.TabStop = false;
            // 
            // h5
            // 
            this.h5.BackColor = System.Drawing.Color.Gray;
            this.h5.Image = global::flappybird.Properties.Resources._221437059211983;
            this.h5.Location = new System.Drawing.Point(571, 378);
            this.h5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h5.Name = "h5";
            this.h5.Size = new System.Drawing.Size(65, 211);
            this.h5.TabIndex = 10;
            this.h5.TabStop = false;
            // 
            // h8
            // 
            this.h8.BackColor = System.Drawing.Color.Gray;
            this.h8.Image = global::flappybird.Properties.Resources._221437059211983;
            this.h8.Location = new System.Drawing.Point(836, -2);
            this.h8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h8.Name = "h8";
            this.h8.Size = new System.Drawing.Size(68, 188);
            this.h8.TabIndex = 9;
            this.h8.TabStop = false;
            // 
            // h3
            // 
            this.h3.BackColor = System.Drawing.Color.Gray;
            this.h3.Image = global::flappybird.Properties.Resources._221437059211983;
            this.h3.Location = new System.Drawing.Point(281, 320);
            this.h3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(71, 269);
            this.h3.TabIndex = 8;
            this.h3.TabStop = false;
            // 
            // h4
            // 
            this.h4.BackColor = System.Drawing.Color.Gray;
            this.h4.Image = global::flappybird.Properties.Resources._221437059211983;
            this.h4.Location = new System.Drawing.Point(281, -2);
            this.h4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h4.Name = "h4";
            this.h4.Size = new System.Drawing.Size(71, 222);
            this.h4.TabIndex = 7;
            this.h4.TabStop = false;
            // 
            // h2
            // 
            this.h2.BackColor = System.Drawing.Color.Gray;
            this.h2.Image = global::flappybird.Properties.Resources._221437059211983;
            this.h2.Location = new System.Drawing.Point(35, -2);
            this.h2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(62, 188);
            this.h2.TabIndex = 6;
            this.h2.TabStop = false;
            // 
            // h1
            // 
            this.h1.BackColor = System.Drawing.Color.Gray;
            this.h1.Image = global::flappybird.Properties.Resources._221437059211983;
            this.h1.Location = new System.Drawing.Point(35, 344);
            this.h1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(62, 245);
            this.h1.TabIndex = 5;
            this.h1.TabStop = false;
            // 
            // t2
            // 
            this.t2.Image = global::flappybird.Properties.Resources.tree_removebg_preview;
            this.t2.Location = new System.Drawing.Point(461, 435);
            this.t2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(69, 59);
            this.t2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.t2.TabIndex = 4;
            this.t2.TabStop = false;
            // 
            // t3
            // 
            this.t3.Image = global::flappybird.Properties.Resources.tree_removebg_preview;
            this.t3.Location = new System.Drawing.Point(719, 435);
            this.t3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(69, 59);
            this.t3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.t3.TabIndex = 3;
            this.t3.TabStop = false;
            // 
            // t1
            // 
            this.t1.Image = global::flappybird.Properties.Resources.tree_removebg_preview;
            this.t1.Location = new System.Drawing.Point(163, 436);
            this.t1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(68, 59);
            this.t1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.t1.TabIndex = 2;
            this.t1.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::flappybird.Properties.Resources.下載_removebg_preview;
            this.bird.Location = new System.Drawing.Point(1, 236);
            this.bird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(48, 38);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(1, 500);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(941, 580);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.h6);
            this.Controls.Add(this.h7);
            this.Controls.Add(this.h5);
            this.Controls.Add(this.h8);
            this.Controls.Add(this.h3);
            this.Controls.Add(this.h4);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.h6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox t1;
        private System.Windows.Forms.PictureBox t3;
        private System.Windows.Forms.PictureBox t2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox h1;
        private System.Windows.Forms.PictureBox h2;
        private System.Windows.Forms.PictureBox h4;
        private System.Windows.Forms.PictureBox h3;
        private System.Windows.Forms.PictureBox h8;
        private System.Windows.Forms.PictureBox h5;
        private System.Windows.Forms.PictureBox h7;
        private System.Windows.Forms.PictureBox h6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button replay;
        private System.Windows.Forms.Label label3;
    }
}


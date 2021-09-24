namespace flappy_game
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
            this.pipDown = new System.Windows.Forms.Panel();
            this.pipUp = new System.Windows.Forms.Panel();
            this.ground = new System.Windows.Forms.Panel();
            this.lbl_score = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_test = new System.Windows.Forms.Label();
            this.lbl_gameOver = new System.Windows.Forms.Label();
            this.ground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pipDown
            // 
            this.pipDown.BackColor = System.Drawing.Color.Red;
            this.pipDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pipDown.Location = new System.Drawing.Point(328, 251);
            this.pipDown.Name = "pipDown";
            this.pipDown.Size = new System.Drawing.Size(76, 191);
            this.pipDown.TabIndex = 0;
            // 
            // pipUp
            // 
            this.pipUp.BackColor = System.Drawing.Color.Red;
            this.pipUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pipUp.Location = new System.Drawing.Point(482, -6);
            this.pipUp.Name = "pipUp";
            this.pipUp.Size = new System.Drawing.Size(75, 129);
            this.pipUp.TabIndex = 1;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ground.Controls.Add(this.lbl_score);
            this.ground.Location = new System.Drawing.Point(-15, 386);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(723, 41);
            this.ground.TabIndex = 2;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_score.Location = new System.Drawing.Point(26, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(88, 24);
            this.lbl_score.TabIndex = 4;
            this.lbl_score.Text = "Score: 0";
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Lime;
            this.bird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bird.Location = new System.Drawing.Point(71, 146);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(54, 34);
            this.bird.TabIndex = 3;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tag = "stoped";
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_test.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_test.Location = new System.Drawing.Point(12, 18);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(50, 24);
            this.lbl_test.TabIndex = 4;
            this.lbl_test.Text = "Test";
            // 
            // lbl_gameOver
            // 
            this.lbl_gameOver.AutoSize = true;
            this.lbl_gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_gameOver.Location = new System.Drawing.Point(209, 171);
            this.lbl_gameOver.Name = "lbl_gameOver";
            this.lbl_gameOver.Size = new System.Drawing.Size(249, 39);
            this.lbl_gameOver.TabIndex = 5;
            this.lbl_gameOver.Text = "Game Over !!!";
            this.lbl_gameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(664, 420);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.lbl_gameOver);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.pipUp);
            this.Controls.Add(this.pipDown);
            this.Controls.Add(this.bird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "flappy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            this.ground.ResumeLayout(false);
            this.ground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pipDown;
        private System.Windows.Forms.Panel pipUp;
        private System.Windows.Forms.Panel ground;
        private System.Windows.Forms.Panel bird;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_test;
        public System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lbl_gameOver;
    }
}


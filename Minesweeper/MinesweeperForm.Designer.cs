namespace Minesweeper
{
    partial class MinesweeperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinesweeperForm));
            this.Exit = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Watch = new System.Windows.Forms.Label();
            this.WatchLabel = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Button();
            this.FlagLabel = new System.Windows.Forms.Label();
            this.Flag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.DimGray;
            this.Exit.Location = new System.Drawing.Point(444, 317);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(86, 39);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.Play.ForeColor = System.Drawing.Color.DimGray;
            this.Play.Location = new System.Drawing.Point(444, 207);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(86, 39);
            this.Play.TabIndex = 1;
            this.Play.Text = "PLAY";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.PlayButtonClick);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(422, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(131, 23);
            this.Title.TabIndex = 66;
            this.Title.Text = "MINESWEEPER";
            // 
            // Watch
            // 
            this.Watch.AutoSize = true;
            this.Watch.Font = new System.Drawing.Font("Consolas", 10F);
            this.Watch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Watch.Location = new System.Drawing.Point(455, 158);
            this.Watch.Name = "Watch";
            this.Watch.Size = new System.Drawing.Size(64, 17);
            this.Watch.TabIndex = 67;
            this.Watch.Text = "00 : 00";
            // 
            // WatchLabel
            // 
            this.WatchLabel.AutoSize = true;
            this.WatchLabel.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatchLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WatchLabel.Location = new System.Drawing.Point(455, 140);
            this.WatchLabel.Name = "WatchLabel";
            this.WatchLabel.Size = new System.Drawing.Size(56, 18);
            this.WatchLabel.TabIndex = 68;
            this.WatchLabel.Text = " TIMER";
            // 
            // Pause
            // 
            this.Pause.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.Pause.ForeColor = System.Drawing.Color.DimGray;
            this.Pause.Location = new System.Drawing.Point(444, 262);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(86, 39);
            this.Pause.TabIndex = 69;
            this.Pause.Text = "PAUSE";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.PauseButtonClick);
            // 
            // FlagLabel
            // 
            this.FlagLabel.AutoSize = true;
            this.FlagLabel.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FlagLabel.Location = new System.Drawing.Point(464, 82);
            this.FlagLabel.Name = "FlagLabel";
            this.FlagLabel.Size = new System.Drawing.Size(40, 18);
            this.FlagLabel.TabIndex = 71;
            this.FlagLabel.Text = "FLAG";
            // 
            // Flag
            // 
            this.Flag.AutoSize = true;
            this.Flag.Font = new System.Drawing.Font("Consolas", 10F);
            this.Flag.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Flag.Location = new System.Drawing.Point(472, 100);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(24, 17);
            this.Flag.TabIndex = 70;
            this.Flag.Text = "10";
            // 
            // MinesweeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 396);
            this.Controls.Add(this.FlagLabel);
            this.Controls.Add(this.Flag);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.WatchLabel);
            this.Controls.Add(this.Watch);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MinesweeperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Watch;
        private System.Windows.Forms.Label WatchLabel;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label FlagLabel;
        private System.Windows.Forms.Label Flag;
    }
}


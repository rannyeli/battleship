namespace BattleShip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start = new System.Windows.Forms.PictureBox();
            this.instructions = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.musicOn = new System.Windows.Forms.PictureBox();
            this.musicOff = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicOff)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.Location = new System.Drawing.Point(596, 269);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 84);
            this.start.TabIndex = 4;
            this.start.TabStop = false;
            this.start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.start_MouseClick);
            // 
            // instructions
            // 
            this.instructions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instructions.BackColor = System.Drawing.Color.Transparent;
            this.instructions.Image = ((System.Drawing.Image)(resources.GetObject("instructions.Image")));
            this.instructions.Location = new System.Drawing.Point(596, 390);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(200, 84);
            this.instructions.TabIndex = 5;
            this.instructions.TabStop = false;
            this.instructions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.instructions_MouseClick);
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(596, 512);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(200, 84);
            this.exit.TabIndex = 6;
            this.exit.TabStop = false;
            this.exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exit_MouseClick);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(480, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(482, 99);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // musicOn
            // 
            this.musicOn.BackColor = System.Drawing.Color.Transparent;
            this.musicOn.Image = ((System.Drawing.Image)(resources.GetObject("musicOn.Image")));
            this.musicOn.Location = new System.Drawing.Point(12, 113);
            this.musicOn.Name = "musicOn";
            this.musicOn.Size = new System.Drawing.Size(46, 34);
            this.musicOn.TabIndex = 7;
            this.musicOn.TabStop = false;
            this.musicOn.Click += new System.EventHandler(this.musicOn_Click);
            // 
            // musicOff
            // 
            this.musicOff.BackColor = System.Drawing.Color.Transparent;
            this.musicOff.Image = ((System.Drawing.Image)(resources.GetObject("musicOff.Image")));
            this.musicOff.Location = new System.Drawing.Point(12, 113);
            this.musicOff.Name = "musicOff";
            this.musicOff.Size = new System.Drawing.Size(29, 34);
            this.musicOff.TabIndex = 8;
            this.musicOff.TabStop = false;
            this.musicOff.Click += new System.EventHandler(this.musicOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.musicOff);
            this.Controls.Add(this.musicOn);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.start);
            this.Controls.Add(this.logo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox instructions;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox musicOn;
        private System.Windows.Forms.PictureBox musicOff;
    }
}


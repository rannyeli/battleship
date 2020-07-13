namespace BattleShip
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.battle = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logo = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.explain = new System.Windows.Forms.PictureBox();
            this.EnemyTurn = new System.Windows.Forms.PictureBox();
            this.PlayerTurn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.battle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // battle
            // 
            this.battle.BackColor = System.Drawing.Color.Transparent;
            this.battle.Image = ((System.Drawing.Image)(resources.GetObject("battle.Image")));
            this.battle.Location = new System.Drawing.Point(34, 578);
            this.battle.Name = "battle";
            this.battle.Size = new System.Drawing.Size(130, 120);
            this.battle.TabIndex = 10;
            this.battle.TabStop = false;
            this.battle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.battle_MouseClick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(1201, 578);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(130, 124);
            this.menu.TabIndex = 11;
            this.menu.TabStop = false;
            this.menu.Tag = "";
            this.menu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.instructionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1359, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click_1);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(478, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(482, 99);
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(351, 167);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(138, 53);
            this.player.TabIndex = 15;
            this.player.TabStop = false;
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.Image = ((System.Drawing.Image)(resources.GetObject("enemy.Image")));
            this.enemy.Location = new System.Drawing.Point(857, 167);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(138, 53);
            this.enemy.TabIndex = 16;
            this.enemy.TabStop = false;
            // 
            // explain
            // 
            this.explain.Image = ((System.Drawing.Image)(resources.GetObject("explain.Image")));
            this.explain.Location = new System.Drawing.Point(931, 155);
            this.explain.Name = "explain";
            this.explain.Size = new System.Drawing.Size(400, 150);
            this.explain.TabIndex = 17;
            this.explain.TabStop = false;
            // 
            // EnemyTurn
            // 
            this.EnemyTurn.BackColor = System.Drawing.Color.Transparent;
            this.EnemyTurn.Image = ((System.Drawing.Image)(resources.GetObject("EnemyTurn.Image")));
            this.EnemyTurn.Location = new System.Drawing.Point(594, 155);
            this.EnemyTurn.Name = "EnemyTurn";
            this.EnemyTurn.Size = new System.Drawing.Size(151, 51);
            this.EnemyTurn.TabIndex = 18;
            this.EnemyTurn.TabStop = false;
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTurn.Image = ((System.Drawing.Image)(resources.GetObject("PlayerTurn.Image")));
            this.PlayerTurn.Location = new System.Drawing.Point(596, 155);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(150, 51);
            this.PlayerTurn.TabIndex = 19;
            this.PlayerTurn.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1359, 741);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.EnemyTurn);
            this.Controls.Add(this.explain);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.player);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.battle);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Game1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Game1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.battle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox battle;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.PictureBox explain;
        private System.Windows.Forms.PictureBox EnemyTurn;
        private System.Windows.Forms.PictureBox PlayerTurn;

    }
}
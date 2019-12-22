using System;
using System.Windows.Forms;

namespace RatGamev0._2
{
    partial class frmMain
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
            this.dgvMaze = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tekOyunculuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgisayaraOynatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbCheese = new System.Windows.Forms.PictureBox();
            this.pbRat = new System.Windows.Forms.PictureBox();
            this.pbWall = new System.Windows.Forms.PictureBox();
            this.pbRoute = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.grpMoves = new System.Windows.Forms.GroupBox();
            this.lblKarsilama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaze)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoute)).BeginInit();
            this.grpItems.SuspendLayout();
            this.grpMoves.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaze
            // 
            this.dgvMaze.AllowUserToAddRows = false;
            this.dgvMaze.AllowUserToDeleteRows = false;
            this.dgvMaze.AllowUserToResizeColumns = false;
            this.dgvMaze.AllowUserToResizeRows = false;
            this.dgvMaze.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMaze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaze.ColumnHeadersVisible = false;
            this.dgvMaze.Location = new System.Drawing.Point(58, 68);
            this.dgvMaze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMaze.Name = "dgvMaze";
            this.dgvMaze.ReadOnly = true;
            this.dgvMaze.RowHeadersVisible = false;
            this.dgvMaze.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvMaze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMaze.Size = new System.Drawing.Size(620, 577);
            this.dgvMaze.TabIndex = 0;
            this.dgvMaze.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaze_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekOyunculuToolStripMenuItem,
            this.bilgisayaraOynatToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(753, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tekOyunculuToolStripMenuItem
            // 
            this.tekOyunculuToolStripMenuItem.Name = "tekOyunculuToolStripMenuItem";
            this.tekOyunculuToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.tekOyunculuToolStripMenuItem.Text = "Tek Oyunculu";
            this.tekOyunculuToolStripMenuItem.Click += new System.EventHandler(this.tekOyunculuToolStripMenuItem_Click);
            // 
            // bilgisayaraOynatToolStripMenuItem
            // 
            this.bilgisayaraOynatToolStripMenuItem.Name = "bilgisayaraOynatToolStripMenuItem";
            this.bilgisayaraOynatToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.bilgisayaraOynatToolStripMenuItem.Text = "Bilgisayara Oynat";
            this.bilgisayaraOynatToolStripMenuItem.Click += new System.EventHandler(this.bilgisayaraOynatToolStripMenuItem_Click);
            // 
            // pbCheese
            // 
            this.pbCheese.Image = global::RatGamev0._2.Properties.Resources.Cheese;
            this.pbCheese.InitialImage = global::RatGamev0._2.Properties.Resources.Cheese;
            this.pbCheese.Location = new System.Drawing.Point(425, 55);
            this.pbCheese.Name = "pbCheese";
            this.pbCheese.Size = new System.Drawing.Size(109, 82);
            this.pbCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheese.TabIndex = 6;
            this.pbCheese.TabStop = false;
            this.pbCheese.Click += new System.EventHandler(this.pbCheese_Click);
            // 
            // pbRat
            // 
            this.pbRat.Image = global::RatGamev0._2.Properties.Resources.Rat;
            this.pbRat.InitialImage = global::RatGamev0._2.Properties.Resources.Rat;
            this.pbRat.Location = new System.Drawing.Point(587, 55);
            this.pbRat.Name = "pbRat";
            this.pbRat.Size = new System.Drawing.Size(110, 82);
            this.pbRat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRat.TabIndex = 5;
            this.pbRat.TabStop = false;
            this.pbRat.Click += new System.EventHandler(this.pbRat_Click);
            // 
            // pbWall
            // 
            this.pbWall.Image = global::RatGamev0._2.Properties.Resources.Wall;
            this.pbWall.Location = new System.Drawing.Point(243, 55);
            this.pbWall.Name = "pbWall";
            this.pbWall.Size = new System.Drawing.Size(109, 82);
            this.pbWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWall.TabIndex = 4;
            this.pbWall.TabStop = false;
            this.pbWall.Click += new System.EventHandler(this.pbWall_Click);
            // 
            // pbRoute
            // 
            this.pbRoute.Image = global::RatGamev0._2.Properties.Resources.Floor;
            this.pbRoute.InitialImage = global::RatGamev0._2.Properties.Resources.Floor;
            this.pbRoute.Location = new System.Drawing.Point(77, 55);
            this.pbRoute.Name = "pbRoute";
            this.pbRoute.Size = new System.Drawing.Size(100, 82);
            this.pbRoute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoute.TabIndex = 3;
            this.pbRoute.TabStop = false;
            this.pbRoute.Click += new System.EventHandler(this.pbRoute_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(76, 799);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(620, 38);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "button1";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // zamanlayici
            // 
            this.zamanlayici.Tick += new System.EventHandler(this.zamanlayici_Tick);
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.label1);
            this.grpItems.Controls.Add(this.pbRoute);
            this.grpItems.Controls.Add(this.pbWall);
            this.grpItems.Controls.Add(this.pbCheese);
            this.grpItems.Controls.Add(this.pbRat);
            this.grpItems.Location = new System.Drawing.Point(8, 656);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(730, 143);
            this.grpItems.TabIndex = 8;
            this.grpItems.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Herhangi bir şey eklemek için birini seçip listede eklemek istediğiniz yeri seçin" +
    "";
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(163, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(267, 36);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "Yukarı hareket";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(163, 93);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(267, 36);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "Aşağı hareket";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(289, 52);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(267, 35);
            this.btnRight.TabIndex = 11;
            this.btnRight.Text = "Sağa hareket";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(16, 51);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(267, 36);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Text = "Sola hareket";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // grpMoves
            // 
            this.grpMoves.Controls.Add(this.btnDown);
            this.grpMoves.Controls.Add(this.btnLeft);
            this.grpMoves.Controls.Add(this.btnUp);
            this.grpMoves.Controls.Add(this.btnRight);
            this.grpMoves.Location = new System.Drawing.Point(77, 659);
            this.grpMoves.Name = "grpMoves";
            this.grpMoves.Size = new System.Drawing.Size(563, 135);
            this.grpMoves.TabIndex = 13;
            this.grpMoves.TabStop = false;
            // 
            // lblKarsilama
            // 
            this.lblKarsilama.AutoSize = true;
            this.lblKarsilama.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.91304F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKarsilama.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKarsilama.Location = new System.Drawing.Point(6, 728);
            this.lblKarsilama.Name = "lblKarsilama";
            this.lblKarsilama.Size = new System.Drawing.Size(740, 39);
            this.lblKarsilama.TabIndex = 14;
            this.lblKarsilama.Text = "Yukarıdan oyun modu seçerek başlayabilirsiniz";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(753, 846);
            this.Controls.Add(this.lblKarsilama);
            this.Controls.Add(this.grpMoves);
            this.Controls.Add(this.grpItems);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.dgvMaze);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Peynirci Fare";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaze)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoute)).EndInit();
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            this.grpMoves.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private System.Windows.Forms.DataGridView dgvMaze;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem tekOyunculuToolStripMenuItem;
        private ToolStripMenuItem bilgisayaraOynatToolStripMenuItem;
        private PictureBox pbRoute;
        private PictureBox pbWall;
        private PictureBox pbRat;
        private PictureBox pbCheese;
        private Button btnStartGame;
        private Timer zamanlayici;
        private GroupBox grpItems;
        private Label label1;
        private Button btnUp;
        private Button btnDown;
        private Button btnRight;
        private Button btnLeft;
        private GroupBox grpMoves;
        private Label lblKarsilama;
    }
}


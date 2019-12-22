namespace RatGamev0._2
{
    partial class frmAreaSize
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAreaSize = new System.Windows.Forms.ComboBox();
            this.btnSendSize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Labirent Kare Büyüklüğünü Seçin";
            // 
            // cmbAreaSize
            // 
            this.cmbAreaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.7913F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreaSize.FormattingEnabled = true;
            this.cmbAreaSize.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cmbAreaSize.Location = new System.Drawing.Point(514, 341);
            this.cmbAreaSize.Name = "cmbAreaSize";
            this.cmbAreaSize.Size = new System.Drawing.Size(84, 52);
            this.cmbAreaSize.TabIndex = 2;
            // 
            // btnSendSize
            // 
            this.btnSendSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendSize.Location = new System.Drawing.Point(141, 420);
            this.btnSendSize.Name = "btnSendSize";
            this.btnSendSize.Size = new System.Drawing.Size(387, 56);
            this.btnSendSize.TabIndex = 3;
            this.btnSendSize.Text = "Oyuna Git";
            this.btnSendSize.UseVisualStyleBackColor = true;
            this.btnSendSize.Click += new System.EventHandler(this.btnSendSize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 48.20869F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label2.Location = new System.Drawing.Point(92, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 79);
            this.label2.TabIndex = 5;
            this.label2.Text = "Peynirci Fare";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RatGamev0._2.Properties.Resources.Rat_PNG_Picture;
            this.pictureBox1.InitialImage = global::RatGamev0._2.Properties.Resources.Rat_PNG_Picture;
            this.pictureBox1.Location = new System.Drawing.Point(38, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmAreaSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(666, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSendSize);
            this.Controls.Add(this.cmbAreaSize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAreaSize";
            this.Text = "Büyüklük Seçimi";
            this.Load += new System.EventHandler(this.frmAreaSize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAreaSize;
        private System.Windows.Forms.Button btnSendSize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
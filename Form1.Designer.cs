namespace GameCaro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.chessBox2 = new System.Windows.Forms.PictureBox();
            this.chessBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.txtBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.PlayerCaption = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.chessBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(648, 656);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(657, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Player vs Player";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // chessBox2
            // 
            this.chessBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chessBox2.Location = new System.Drawing.Point(657, 395);
            this.chessBox2.Name = "chessBox2";
            this.chessBox2.Size = new System.Drawing.Size(24, 24);
            this.chessBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chessBox2.TabIndex = 13;
            this.chessBox2.TabStop = false;
            // 
            // chessBox1
            // 
            this.chessBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chessBox1.Location = new System.Drawing.Point(657, 348);
            this.chessBox1.Name = "chessBox1";
            this.chessBox1.Size = new System.Drawing.Size(24, 24);
            this.chessBox1.TabIndex = 12;
            this.chessBox1.TabStop = false;
            // 
            // txtBoxPlayer2
            // 
            this.txtBoxPlayer2.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxPlayer2.Location = new System.Drawing.Point(687, 395);
            this.txtBoxPlayer2.Name = "txtBoxPlayer2";
            this.txtBoxPlayer2.ReadOnly = true;
            this.txtBoxPlayer2.Size = new System.Drawing.Size(237, 27);
            this.txtBoxPlayer2.TabIndex = 11;
            this.txtBoxPlayer2.Text = "Nguyen Van A";
            // 
            // txtBoxPlayer1
            // 
            this.txtBoxPlayer1.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxPlayer1.Location = new System.Drawing.Point(687, 348);
            this.txtBoxPlayer1.Name = "txtBoxPlayer1";
            this.txtBoxPlayer1.ReadOnly = true;
            this.txtBoxPlayer1.Size = new System.Drawing.Size(237, 27);
            this.txtBoxPlayer1.TabIndex = 10;
            this.txtBoxPlayer1.Text = "Nguyen Van A";
            // 
            // PlayerCaption
            // 
            this.PlayerCaption.AutoSize = true;
            this.PlayerCaption.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerCaption.ForeColor = System.Drawing.Color.Red;
            this.PlayerCaption.Location = new System.Drawing.Point(657, 301);
            this.PlayerCaption.Name = "PlayerCaption";
            this.PlayerCaption.Size = new System.Drawing.Size(60, 27);
            this.PlayerCaption.TabIndex = 9;
            this.PlayerCaption.Text = "Turn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(657, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 265);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(657, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = "Player vs COM";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 670);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chessBox2);
            this.Controls.Add(this.chessBox1);
            this.Controls.Add(this.txtBoxPlayer2);
            this.Controls.Add(this.txtBoxPlayer1);
            this.Controls.Add(this.PlayerCaption);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameCaro-Back To Childhood";
            ((System.ComponentModel.ISupportInitialize)(this.chessBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlChessBoard;
        private Button button1;
        private PictureBox chessBox2;
        private PictureBox chessBox1;
        private TextBox txtBoxPlayer2;
        private TextBox txtBoxPlayer1;
        private Label PlayerCaption;
        private PictureBox pictureBox1;
        private Button button2;
        private MenuStrip menuStrip1;
    }
}
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
            this.chessBox2 = new System.Windows.Forms.PictureBox();
            this.chessBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.txtBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.PlayerCaption = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfirmName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chessBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.Location = new System.Drawing.Point(4, 43);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(648, 656);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // chessBox2
            // 
            this.chessBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chessBox2.Location = new System.Drawing.Point(665, 432);
            this.chessBox2.Name = "chessBox2";
            this.chessBox2.Size = new System.Drawing.Size(24, 24);
            this.chessBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chessBox2.TabIndex = 13;
            this.chessBox2.TabStop = false;
            // 
            // chessBox1
            // 
            this.chessBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chessBox1.Location = new System.Drawing.Point(665, 385);
            this.chessBox1.Name = "chessBox1";
            this.chessBox1.Size = new System.Drawing.Size(24, 24);
            this.chessBox1.TabIndex = 12;
            this.chessBox1.TabStop = false;
            // 
            // txtBoxPlayer2
            // 
            this.txtBoxPlayer2.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxPlayer2.Location = new System.Drawing.Point(695, 432);
            this.txtBoxPlayer2.Name = "txtBoxPlayer2";
            this.txtBoxPlayer2.PlaceholderText = "Player2_name";
            this.txtBoxPlayer2.Size = new System.Drawing.Size(237, 27);
            this.txtBoxPlayer2.TabIndex = 11;
            // 
            // txtBoxPlayer1
            // 
            this.txtBoxPlayer1.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxPlayer1.Location = new System.Drawing.Point(695, 385);
            this.txtBoxPlayer1.Name = "txtBoxPlayer1";
            this.txtBoxPlayer1.PlaceholderText = "Player1_name";
            this.txtBoxPlayer1.Size = new System.Drawing.Size(237, 27);
            this.txtBoxPlayer1.TabIndex = 10;
            // 
            // PlayerCaption
            // 
            this.PlayerCaption.AutoSize = true;
            this.PlayerCaption.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerCaption.ForeColor = System.Drawing.Color.Red;
            this.PlayerCaption.Location = new System.Drawing.Point(663, 340);
            this.PlayerCaption.Name = "PlayerCaption";
            this.PlayerCaption.Size = new System.Drawing.Size(60, 27);
            this.PlayerCaption.TabIndex = 9;
            this.PlayerCaption.Text = "Turn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(663, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 265);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ConfirmName
            // 
            this.ConfirmName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConfirmName.Location = new System.Drawing.Point(665, 474);
            this.ConfirmName.Name = "ConfirmName";
            this.ConfirmName.Size = new System.Drawing.Size(267, 29);
            this.ConfirmName.TabIndex = 16;
            this.ConfirmName.Text = "OK";
            this.ConfirmName.UseVisualStyleBackColor = true;
            this.ConfirmName.Click += new System.EventHandler(this.ConfirmName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 706);
            this.Controls.Add(this.ConfirmName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chessBox2);
            this.Controls.Add(this.chessBox1);
            this.Controls.Add(this.txtBoxPlayer2);
            this.Controls.Add(this.txtBoxPlayer1);
            this.Controls.Add(this.PlayerCaption);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameCaro-Back To Childhood";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chessBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlChessBoard;
        private PictureBox chessBox2;
        private PictureBox chessBox1;
        private TextBox txtBoxPlayer2;
        private TextBox txtBoxPlayer1;
        private Label PlayerCaption;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button ConfirmName;
    }
}
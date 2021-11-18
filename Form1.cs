namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Initialize
        GameManager gameManager;
        #endregion

        public Form1()
        {
            InitializeComponent();
            gameManager = new GameManager(pnlChessBoard);
            NewGame();
        }

        #region MenuMethods
        void Quit()
        {
            Application.Exit();
        }

        void NewGame()
        {
            chessBox1.BackgroundImage = null;
            chessBox2.BackgroundImage = null;

            txtBoxPlayer1.Text = String.Empty;
            txtBoxPlayer2.Text = String.Empty;
            txtBoxPlayer1.ReadOnly = false;
            txtBoxPlayer2.ReadOnly = false;
            txtBoxPlayer1.PlaceholderText = "Player1_name";
            txtBoxPlayer2.PlaceholderText = "Player2_name";

            gameManager.ResetGame();
            gameManager.drawChessBoard();
        }
        #endregion

        private void ConfirmName_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtBoxPlayer1.ReadOnly = true;
                txtBoxPlayer2.ReadOnly = true;
                txtBoxPlayer1.PlaceholderText = String.Empty;
                txtBoxPlayer2.PlaceholderText = String.Empty;

                if (!String.IsNullOrEmpty(txtBoxPlayer1.Text) && !String.IsNullOrEmpty(txtBoxPlayer2.Text))
                {
                    gameManager.StartGame(chessBox1, chessBox2, txtBoxPlayer1, txtBoxPlayer2);
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit?", "Warning", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
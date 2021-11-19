namespace GameCaro
{
    public enum ENDGAME
    {
        HoaCo,
        Player1,
        Player2,
        COM
    }

    public class GameManager
    {
        /* ChessBoard info
		 * size: 640x640 ~ 20x20
		 * chess_box: size(32,32)
		 */

        /* Gameplay explain
         * A list contains number of player(current allow 2 players)
         * CurrentPlayer holds the inturn player which has only 0, 1 which is the index of List with lenght of 2
         */

        #region Initialize
        private Panel chessBoard;
        private int currentPlayer;
        private int nextPlayer;
        private List<Player> playerList;
        private PictureBox _imgChessBox1, _imgChessBox2;
        private TextBox _txtBoxPlayer1, _txtBoxPlayer2;
        private int QTY_HORIZONTAL;
        private int QTY_VERTICAL;

        private List<List<Button>> matrix;
        private List<Button> stackCacNuocDi;
        private ENDGAME _endGame;
        private bool isReady;

        public int CurrentPlayer
        {
            get => currentPlayer;
            set => currentPlayer = value;
        }

        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        public List<Player> PlayerList
        {
            get => playerList;
            set => playerList = value;
        }

        public PictureBox ImgChessBox1 { get => _imgChessBox1; set => _imgChessBox1 = value; }
        public PictureBox ImgChessBox2 { get => _imgChessBox2; set => _imgChessBox2 = value; }
        public TextBox TxtBoxPlayer1 { get => _txtBoxPlayer1; set => _txtBoxPlayer1 = value; }
        public TextBox TxtBoxPlayer2 { get => _txtBoxPlayer2; set => _txtBoxPlayer2 = value; }

        public List<List<Button>> Matrix
        {
            get => matrix;
            set => matrix = value;
        }
        public bool IsReady { get => isReady; set => isReady = value; }

        #endregion

        public GameManager(Panel chessBoard)
        {
            IsReady = false;
            this.ChessBoard = chessBoard;
        }

        public void StartGame(PictureBox chessBox1, PictureBox chessBox2, TextBox player1Name, TextBox player2Name)
        {
            #region RandomMark
            this.IsReady = true;

            Random rand = new Random();

            int markChoice = rand.Next(0, 2);
            #endregion

            this.PlayerList = new List<Player>()
            {
                new Player(player1Name.Text, Image.FromFile(Application.StartupPath + $"\\Assets\\{markChoice}.png")),
                new Player(player2Name.Text, Image.FromFile(Application.StartupPath + $"\\Assets\\{1-markChoice}.png"))
            };

            this.CurrentPlayer = 0;
            this.nextPlayer = CurrentPlayer;

            this.stackCacNuocDi = new List<Button>();

            //Set hien turn cua player
            ImgChessBox1 = chessBox1;
            ImgChessBox2 = chessBox2;
            TxtBoxPlayer1 = player1Name;
            TxtBoxPlayer2 = player2Name;

            DetermineTurn();
        }

        public void ResetGame()
        {
            this.IsReady = false;
        }

        public void drawChessBoard()
        {
            ChessBoard.Controls.Clear();

            QTY_HORIZONTAL = Constant.CHESS_BOARD.Width / Constant.CHESS_WIDTH;
            QTY_VERTICAL = Constant.CHESS_BOARD.Height / Constant.CHESS_HEIGHT;

            // Khoi tao 1 mang 2 chieu chua cac button
            Matrix = new List<List<Button>>();

            for (int i = 0; i < QTY_HORIZONTAL; i++)
            {
                // Tao mang 1 chieu_day chinh la hang cua matrix 2d
                Matrix.Add(new List<Button>());

                for (int j = 0; j < QTY_VERTICAL; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constant.CHESS_WIDTH,
                        Height = Constant.CHESS_HEIGHT,
                        Location = new Point(j * Constant.CHESS_WIDTH, i * Constant.CHESS_HEIGHT),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    btn.Click += Btn_Click;

                    Matrix[i].Add(btn);
                    this.ChessBoard.Controls.Add(btn);
                }
            }
        }

        private void DetermineTurn()
        {
            ImgChessBox1.BackgroundImage = null;
            ImgChessBox2.BackgroundImage = null;
            TxtBoxPlayer1.Text = "";
            TxtBoxPlayer2.Text = "";

            if (this.nextPlayer == 0)
            {
                ImgChessBox1.BackgroundImage = PlayerList[0].ChessBoxMark;
                TxtBoxPlayer1.Text = PlayerList[0].Name;
            }
            else if (this.nextPlayer == 1)
            {
                ImgChessBox2.BackgroundImage = PlayerList[1].ChessBoxMark;
                TxtBoxPlayer2.Text = PlayerList[1].Name;
            }

            this.nextPlayer = this.nextPlayer == 0 ? 1 : 0;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            if (IsReady)
            {
                Button? btn = sender as Button;

                if (btn.BackgroundImage != null)
                {
                    return;
                }

                btn.BackgroundImage = PlayerList[CurrentPlayer].ChessBoxMark;

                if (isEndGame(btn))
                {
                    EndGame();
                }

                CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

                DetermineTurn();

                // Cu moi lan nhan button => Them vao stackCacNuocDi; TH nhan lai nut khong xay ra nen ko can xet trung
                stackCacNuocDi.Add(btn);
            }
            else
            {
                MessageBox.Show("Please enter player_name before starting game", "Alert", MessageBoxButtons.OK);
            }
        }

        private void EndGame()
        {
            switch (_endGame)
            {
                case ENDGAME.HoaCo:
                    MessageBox.Show("Game is tie!", "Congratulations", MessageBoxButtons.OK);
                    break;
                case ENDGAME.Player1:
                    MessageBox.Show($"{TxtBoxPlayer1.Text} wins!", "Congratulations", MessageBoxButtons.OK);
                    break;
                case ENDGAME.Player2:
                    MessageBox.Show($"{TxtBoxPlayer2.Text} wins!", "Congratulations", MessageBoxButtons.OK);
                    break;
            }
        }

        private bool isEndGame(Button btn)
        {
            _endGame = CurrentPlayer == 0 ? ENDGAME.Player1 : ENDGAME.Player2;

            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimaryDiagonal(btn) || isEndSecondDiagonal(btn) || isTie(btn);
        }

        private bool isEndHorizontal(Button btn)
        {
            int count = 0;

            int block2way = 0;

            int matrixRow = btn.Location.Y / 32; //Matrix[matrixRow][]

            for (int i = btn.Location.X / 32; i >= 0; i--)
            {
                if (Matrix[matrixRow][i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    if (Matrix[matrixRow][i].BackgroundImage != null)
                    {
                        block2way++;
                    }

                    break;
                }
            }

            for (int i = btn.Location.X / 32 + 1; i < this.QTY_VERTICAL; i++)
            {

                if (Matrix[matrixRow][i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    if (Matrix[matrixRow][i].BackgroundImage != null)
                    {
                        block2way++;
                    }

                    break;
                }
            }

            return count >= 5 && block2way < 2;
        }

        private bool isEndVertical(Button btn)
        {
            int count = 0;

            int block2way = 0;

            int matrixColumn = btn.Location.X / 32; //Matrix[matrixRow][]

            for (int i = btn.Location.Y / 32; i >= 0; i--)
            {
                if (Matrix[i][matrixColumn].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    if (Matrix[i][matrixColumn].BackgroundImage != null)
                    {
                        block2way++;
                    }

                    break;
                }
            }

            for (int i = btn.Location.Y / 32 + 1; i < this.QTY_HORIZONTAL; i++)
            {
                if (Matrix[i][matrixColumn].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    if (Matrix[i][matrixColumn].BackgroundImage != null)
                    {
                        block2way++;
                    }

                    break;
                }
            }

            return count >= 5 && block2way < 2;
        }

        private bool isEndPrimaryDiagonal(Button btn)
        {
            int count = 0;

            int block2way = 0;

            //Matrix[matrixRow][matrixColumn]
            int matrixColumn = btn.Location.X / 32;
            int matrixRow = btn.Location.Y / 32;

            while (matrixColumn >= 0 && matrixRow >= 0)
            {
                if (Matrix[matrixRow][matrixColumn].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    if (Matrix[matrixRow][matrixColumn].BackgroundImage != null)
                    {
                        block2way++;
                    }

                    break;
                }

                matrixColumn--;
                matrixRow--;
            }

            matrixColumn = (btn.Location.X / 32) + 1;
            matrixRow = (btn.Location.Y / 32) + 1;


            while (matrixRow < QTY_VERTICAL && matrixColumn < QTY_VERTICAL)
            {
                if (Matrix[matrixRow][matrixColumn].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    if (Matrix[matrixRow][matrixColumn].BackgroundImage != null)
                    {
                        block2way++;
                    }

                    break;
                }

                matrixColumn++;
                matrixRow++;
            }

            return count >= 5 && block2way < 2;
        }

        private bool isEndSecondDiagonal(Button btn)
        {
            int count = 0;

            int block2way = 0;

            //Matrix[matrixRow][matrixColumn]
            int matrixColumn = btn.Location.X / 32;
            int matrixRow = btn.Location.Y / 32;

            while (matrixRow >= 0 && matrixColumn < QTY_VERTICAL)
            {
                if (Matrix[matrixRow][matrixColumn].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    if (Matrix[matrixRow][matrixColumn].BackgroundImage != null)
                    {
                        block2way++;
                    }

                    break;
                }

                matrixColumn++;
                matrixRow--;
            }

            matrixColumn = (btn.Location.X / 32) - 1;
            matrixRow = (btn.Location.Y / 32) + 1;

            while (matrixColumn >= 0 && matrixRow < QTY_HORIZONTAL)
            {
                if (Matrix[matrixRow][matrixColumn].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                {
                    if (Matrix[matrixRow][matrixColumn].BackgroundImage != null)
                    {
                        block2way++;
                    }

                    break;
                }

                matrixColumn--;
                matrixRow++;
            }

            return count >= 5 && block2way < 2;
        }

        private bool isTie(Button btn)
        {
            _endGame = ENDGAME.HoaCo;
            return stackCacNuocDi.Count == QTY_HORIZONTAL * QTY_VERTICAL;
        }
    }
}

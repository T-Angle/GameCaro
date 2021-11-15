namespace GameCaro
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			drawChessBoard();
		}

		/* chess_board boilerplate
		 * size: 640x480 ~ 20x20
		 * chess_box: size(32,32)
		*/


		void drawChessBoard()
		{
			double Horizontal_Chess_Box = pnlChessBoard.Size.Width / Constant.CHESS_WIDTH;
			double Vertical_Chess_Box = pnlChessBoard.Size.Height / Constant.CHESS_HEIGHT;

			Button old_btn = new Button() { Width = 0, Location = Constant.CHESS_INIT_LOCATION };

			for (int i = 1; i <= Horizontal_Chess_Box; i++)
			{
				for(int j = 0; j <= Vertical_Chess_Box; j++)
				{
					Button btn = new Button() { 
						Width = Constant.CHESS_WIDTH, 
						Height = Constant.CHESS_HEIGHT,
						Location = new Point(old_btn.Location.X + old_btn.Width, old_btn.Location.Y),
						BackgroundImageLayout = ImageLayout.Stretch
					};

                    btn.Click += Btn_Click;

					pnlChessBoard.Controls.Add(btn);

					old_btn = btn;
				}
					
				old_btn.Location = new Point(Constant.CHESS_INIT_LOCATION.X, old_btn.Location.Y + Constant.CHESS_HEIGHT);
				old_btn.Width = 0;
				old_btn.Height = 0;
			}

		}

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button? btn = sender as Button;
			btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Assets\\circle.png");

        }
    }
}
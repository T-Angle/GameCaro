namespace GameCaro
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			GameManager chessBoard = new GameManager(pnlChessBoard, chessBox1, chessBox2, txtBoxPlayer1, txtBoxPlayer2);

			chessBoard.drawChessBoard();
		}
    }
}
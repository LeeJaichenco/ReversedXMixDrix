using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ReversedXMixDrix
{
    public partial class GameForm : Form
    {
        private GameManager m_GameManger;

        internal GameForm(GameSettings i_GameSettings)
        {
            m_GameManger = new GameManager(i_GameSettings);

            InitializeComponent();
            initializeBoardComponents();
            renderScore();
            m_GameManger.MakeMove += game_MoveMade;
            m_GameManger.PlayerWon += game_PlayerWon;
            m_GameManger.GameTie += game_Tie;
        }

        private void initializeBoardComponents()
        {
            GameBoard board = m_GameManger.m_Board;
            int cellSize = 50;
            int spacing = 5;
            int boardSize = board.Size * (cellSize + spacing) + spacing;
            int formHeight = boardSize + 30;
            this.ClientSize = new Size(boardSize, formHeight);

            createBoard(board, cellSize, spacing);
        }

        private void createBoard(GameBoard i_Board, int i_CellSize, int i_Spacing)
        {
            for (int row = 0; row < i_Board.Size; row++)
            {
                for (int col = 0; col < i_Board.Size; col++)
                {
                    Button currentCell = new Button
                    {
                        Size = new Size(i_CellSize, i_CellSize),
                        Top = row * (i_CellSize + i_Spacing) + i_Spacing,
                        Left = col * (i_CellSize + i_Spacing) + i_Spacing,
                        ForeColor = Color.Black,
                        TabStop = false,
                        Tag = new Move
                        {
                            Row = row,
                            Column = col
                        }
                    };

                    currentCell.Click += onCellClick;
                    this.Controls.Add(currentCell);
                }
            }
        }

        private void game_PlayerWon(Player i_Winner)
        {
            DialogResult result = MessageBox.Show($@"The winner is {i_Winner.Name}!
                                    Would you like to play another round?", "A Win!", MessageBoxButtons.YesNo);

            handlePlayAgain(result);
        }

        private void game_Tie()
        {
            DialogResult result = MessageBox.Show(@"Tie!
                                    Would you like to play another round?", "A Tie!", MessageBoxButtons.YesNo);

            handlePlayAgain(result);
        }

        private void handlePlayAgain(DialogResult i_Result)
        {
            this.DialogResult = i_Result;

            this.Close();
        }

        private void onCellClick(object sender, EventArgs e)
        {
            Button buttonCell = (Button)sender;
            Move move = (Move)buttonCell.Tag;

            m_GameManger.AskForMove(move);
            renderScore();
        }

        private void game_MoveMade(Move i_Move)
        {
            string cellContent = m_GameManger.m_Board.GetCell(i_Move.Row, i_Move.Column).ToString();
            Button buttonOfMove = findButtonByMove(i_Move);

            buttonOfMove.Text = cellContent;
            buttonOfMove.Enabled = false;
        }

        private void renderScore()
        {
            labelPlayer1.Text = $"{m_GameManger.m_Player1.Name}: {m_GameManger.m_Player1.Score}";
            labelPlayer2.Text = $"{m_GameManger.m_Player2.Name}: {m_GameManger.m_Player2.Score}";

            FontStyle fontStylePlayer1 = m_GameManger.m_CurrentPlayer == m_GameManger.m_Player1 ? FontStyle.Bold : FontStyle.Regular;
            FontStyle fontStylePlayer2 = m_GameManger.m_CurrentPlayer == m_GameManger.m_Player2 ? FontStyle.Bold : FontStyle.Regular;

            labelPlayer1.Font = new Font(labelPlayer1.Font, fontStylePlayer1);
            labelPlayer2.Font = new Font(labelPlayer2.Font, fontStylePlayer2);
        }

        private Button findButtonByMove(Move i_Move)
        {
            Button buttonOfMove = this.Controls.OfType<Button>().First(button =>
            {
                Move move = (Move)button.Tag;

                return move == i_Move;
            });

            return buttonOfMove;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}

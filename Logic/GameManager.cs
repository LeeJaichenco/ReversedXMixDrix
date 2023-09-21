using System;   

namespace ReversedXMixDrix
{
    internal enum eGameMode
    {
        PlayAgainstPlayer,
        PlayAgainstComputer
    }

    internal enum eGameStatus
    {
        Playing,
        Tie,
        Win
    }

    internal class GameManager
    {
        private eGameMode m_Mode;
        private eGameStatus m_Status = eGameStatus.Playing;
        internal Player m_Player1;
        internal Player m_Player2;
        internal GameBoard m_Board;
        internal Player m_CurrentPlayer;
        internal Player m_OtherPlayer;

        public event Action<Player> PlayerWon;
        public event Action GameTie;
        public event Action<Move> MakeMove;

        internal GameManager(GameSettings i_GameSettings)
        {
            m_Mode = i_GameSettings.GameMode;
            m_Board = new GameBoard(i_GameSettings.BoardSize);
            m_Player1 = i_GameSettings.Player1;
            m_Player2 = i_GameSettings.Player2;
            m_CurrentPlayer = m_Player1;
            m_OtherPlayer = m_Player2;
        }

        internal void AskForMove(Move i_Move)
        {
            if (m_Status != eGameStatus.Playing)
            {
                return;
            }

            eGameStatus status = DoMove(i_Move);

            if (status == eGameStatus.Playing)
            {
                if (m_Mode == eGameMode.PlayAgainstComputer)
                {
                    Move bestMove = (m_Player2 as ComputerPlayer).MakeSmartMove(m_Board);
                    status = DoMove(bestMove);
                }
            }

            m_Status = status;

            if(m_Status != eGameStatus.Playing)
            {
                if(m_Status == eGameStatus.Win)
                {
                    m_OtherPlayer.IncreaseScore();
                    OnPlayerWon(m_OtherPlayer);
                }
                else
                {
                    OnGameTie();
                }
            }
        }

        internal eGameStatus DoMove(Move i_move)
        {
            m_Board.SetCell(i_move.Row, i_move.Column, m_CurrentPlayer.Symbol);
            OnMakeMove(i_move);
            eGameStatus status = checkStatus();

            if (status == eGameStatus.Playing)
            {
                (m_CurrentPlayer, m_OtherPlayer) = (m_OtherPlayer, m_CurrentPlayer);
            }

            return status;
        }

        private eGameStatus checkStatus()
        {
            eGameStatus status = eGameStatus.Playing;

            if (isPlayerLost(m_CurrentPlayer))
            {
                status = eGameStatus.Win;
            }
            else if (m_Board.IsFull())
            {
                status = eGameStatus.Tie;
            }

            return status;
        }

        private bool isPlayerLost(Player i_player)
        {
            eSymbol symbol = i_player.Symbol;

            return m_Board.PlayerHasRowSequence(symbol) || m_Board.PlayerHasColumnSequence(symbol) || m_Board.PlayerHasDiagonalSequence(symbol);
        }

        protected virtual void OnGameTie()
        {
            GameTie?.Invoke();
        }

        protected virtual void OnPlayerWon(Player i_Player)
        {
            PlayerWon?.Invoke(i_Player);
        }

        protected virtual void OnMakeMove(Move i_Move)
        {
            MakeMove?.Invoke(i_Move);
        }
    }
}

using System.Collections.Generic;

namespace ReversedXMixDrix
{
    internal enum eSymbol
    {
        X,
        O,
        Empty
    }

    internal class GameBoard
    {
        internal int Size { get; private set; }
        internal eSymbol[,] m_Board;

        internal GameBoard(int i_SizeOfBoard)
        {
            Size = i_SizeOfBoard;
            m_Board = new eSymbol[Size, Size];

            initializeBoard();
        }

        internal GameBoard(GameBoard i_Board)
        {
            Size = i_Board.Size;
            m_Board = new eSymbol[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    m_Board[i, j] = i_Board.m_Board[i, j];
                }
            }
        }

        private void initializeBoard()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    m_Board[i, j] = eSymbol.Empty;
                }
            }
        }

        internal void SetCell(int i_Row, int i_Column, eSymbol i_Symbol)
        {
            m_Board[i_Row, i_Column] = i_Symbol;
        }

        internal eSymbol GetCell(int i_Row, int i_Column)
        {
            return m_Board[i_Row, i_Column];
        }

        internal bool IsFull()
        {
            bool isFull = true;

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (m_Board[i, j] == eSymbol.Empty)
                    {
                        isFull = false;
                    }
                }
            }

            return isFull;
        }

        internal List<Move> GetPossibleMoves()
        {
            List<Move> possibleMoves = new List<Move>();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (m_Board[i, j] == eSymbol.Empty)
                    {
                        possibleMoves.Add(new Move
                        {
                            Row = i,
                            Column = j,
                        });
                    }
                }
            }

            return possibleMoves;
        }

        internal bool PlayerHasRowSequence(eSymbol i_Symbol)
        {
            bool didPlayerLose = false;
            int sequenceCounter;

            for (int i = 0; i < Size; i++)
            {
                sequenceCounter = 0;

                for (int j = 0; j < Size; j++)
                {
                    if (GetCell(i, j).Equals(i_Symbol))
                    {
                        sequenceCounter++;
                    }
                }

                if (sequenceCounter == Size)
                {
                    didPlayerLose = true;

                    break;
                }
            }

            return didPlayerLose;
        }

        internal bool PlayerHasColumnSequence(eSymbol i_Symbol)
        {
            bool didPlayerLose = false;
            int sequenceCounter;

            for (int i = 0; i < Size; i++)
            {
                sequenceCounter = 0;

                for (int j = 0; j < Size; j++)
                {
                    if (GetCell(j, i).Equals(i_Symbol))
                    {
                        sequenceCounter++;
                    }
                }

                if (sequenceCounter == Size)
                {
                    didPlayerLose = true;

                    break;
                }
            }

            return didPlayerLose;
        }

        internal bool PlayerHasDiagonalSequence(eSymbol i_Symbol)
        {
            int mainCounter = 0;
            int secondaryCounter = 0;

            for (int i = 0; i < Size; i++)
            {
                if (GetCell(i, i).Equals(i_Symbol))
                {
                    mainCounter++;
                }

                if (GetCell(i, Size - i - 1).Equals(i_Symbol))
                {
                    secondaryCounter++;
                }
            }

            return (mainCounter == Size) || (secondaryCounter == Size);
        }
    }
}

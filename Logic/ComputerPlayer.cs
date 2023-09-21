using System;
using System.Collections.Generic;

namespace ReversedXMixDrix
{
    internal enum eDifficulty
    {
        Easy = 1,
        Medium = 3,
        Hard = 5
    }

    internal class ComputerPlayer : Player
    {
        internal ComputerPlayer() : base(eSymbol.O, "Computer")
        {
        }

        internal Move MakeSmartMove(GameBoard i_Board)
        {
            eDifficulty dificultLevel = eDifficulty.Hard;

            if (i_Board.Size > 7)
            {
                dificultLevel = eDifficulty.Easy;
            }
            else if (i_Board.Size > 4)
            {
                dificultLevel = eDifficulty.Medium;
            }

            Move bestMove = getBestMove(i_Board, base.Symbol, (int)dificultLevel).Move;

            if(bestMove == null)
            {
                bestMove = makeRandomMove(i_Board);
            }

            return bestMove;
        }

        private MoveWithScore getBestMove(GameBoard i_Board, eSymbol i_Symbol, int i_Depth)
        {
            eSymbol otherSymbol = getOtherSymbol(i_Symbol);
            List<Move> possibleMoves = i_Board.GetPossibleMoves();
            int score = calculatePosition(i_Board, i_Symbol);
            int otherScore = calculatePosition(i_Board, otherSymbol);
            MoveWithScore bestMove = new MoveWithScore
            {
                Score = score - otherScore,
                Move = null,
            };

            if (bestMove.Score < i_Board.Size && bestMove.Score > -i_Board.Size && possibleMoves.Count != 0 && i_Depth != 0)
            {
                int minOtherScore = int.MaxValue;

                foreach (Move move in possibleMoves)
                {
                    GameBoard boardToTry = new GameBoard(i_Board);
                    boardToTry.SetCell(move.Row, move.Column, i_Symbol);
                    MoveWithScore otherBestMove = getBestMove(boardToTry, otherSymbol, i_Depth - 1);

                    if (otherBestMove.Score < minOtherScore)
                    {
                        minOtherScore = otherBestMove.Score;
                        bestMove = new MoveWithScore
                        {
                            Move = move,
                            Score = -otherBestMove.Score,
                        };
                    }
                }
            }

            return bestMove;
        }

        private int calculatePosition(GameBoard i_Board, eSymbol i_Symbol)
        {
            int maxSymbolsInRow = 0;
            int maxSymbolsInColumn = 0;
            int symbolsInPrimaryDiagonal = 0;
            int symbolsInSecondaryDiagonal = 0;

            for (int i = 0; i < i_Board.Size; i++)
            {
                int symbolsInRow = 0;
                int symbolsInColumn = 0;

                for (int j = 0; j < i_Board.Size; j++)
                {
                    if (i_Board.GetCell(i, j) == i_Symbol)
                    {
                        symbolsInRow++;
                    }

                    if (i_Board.GetCell(j, i) == i_Symbol)
                    {
                        symbolsInColumn++;
                    }
                }

                if (i_Board.GetCell(i, i) == i_Symbol)
                {
                    symbolsInPrimaryDiagonal++;
                }

                if (i_Board.GetCell(i, i_Board.Size - i - 1) == i_Symbol)
                {
                    symbolsInSecondaryDiagonal++;
                }

                if (symbolsInRow > maxSymbolsInRow)
                {
                    maxSymbolsInRow = symbolsInRow;
                }

                if (symbolsInColumn > maxSymbolsInColumn)
                {
                    maxSymbolsInColumn = symbolsInColumn;
                }
            }

            int howMuchBad = Math.Max(Math.Max(maxSymbolsInRow, maxSymbolsInColumn), Math.Max(symbolsInPrimaryDiagonal, symbolsInSecondaryDiagonal));
            int howMuchGood = i_Board.Size - howMuchBad;

            if (howMuchGood == 0)
            {
                howMuchGood = -100;
            }

            return howMuchGood;
        }

        private eSymbol getOtherSymbol(eSymbol i_Symbol)
        {
            eSymbol otherSymbol = eSymbol.X;

            if (i_Symbol == eSymbol.X)
            {
                otherSymbol = eSymbol.O;
            }

            return otherSymbol;
        }

        private Move makeRandomMove(GameBoard i_Board)
        {
            Random random = new Random();
            List<Move> possibleMoves = i_Board.GetPossibleMoves();
            int moveIndex = random.Next(0, possibleMoves.Count);
            Move move = possibleMoves[moveIndex];

            return move;
        }
    }
}

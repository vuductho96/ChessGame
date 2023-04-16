// See https://aka.ms/new-console-template for more information
using System;
namespace ChessGame
{
   public class Chess {
       public int X, Y;
        public string Name;
        public bool isWhite;
        public int order;
    };
    class Game : Chess
    {
        public static void SetPosition(Chess[] chessPieces)
{
            int whiteRow = 0;
            int blackRow = 7;

            // Set position for white pieces
            for (int i = 0; i < 16; i++)
            {
                if (chessPieces[i] is Pawn)
                {
                    chessPieces[i].X = i % 8;
                    chessPieces[i].Y = whiteRow + 1;
                }
                else
                {
                    chessPieces[i].X = i % 8;
                    chessPieces[i].Y = whiteRow;
                }
            }

            // Set position for black pieces
            for (int i = 16; i < 32; i++)
            {
                if (chessPieces[i] is Pawn)
                {
                    chessPieces[i].X = i % 8;
                    chessPieces[i].Y = blackRow - 1;
                }
                else
                {
                    chessPieces[i].X = i % 8;
                    chessPieces[i].Y = blackRow;
                }
            }
        

    }

    }

class Rook : Chess {
        public Rook(bool isWhite, int order)
        {
           
            this.isWhite = isWhite;
            this.order = order;
            if (isWhite==true)
            {
                this.Name = "R";
            }
            else
            {
                this.Name = "Black";
            }
        }
    }
    class King : Chess {
        public King(bool isWhite, int order)
        {
            
            this.isWhite = isWhite;
            this.order = order;
            if (isWhite == true)
            {
                this.Name = "K";
            }
            else
            {
                this.Name = "Black King";
            }
        }
    
    }
    class Knight : Chess {
        public Knight(bool isWhite, int order)
        {
            if (isWhite == true)
            {
                this.Name = "K";
            }
            else
            {
                this.Name = "Black Knight";
            }
            this.isWhite = isWhite;
            this.order = order;
        }
    }
    class Queen : Chess {
        public Queen(bool isWhite, int order)
        {
            if (isWhite == true)
            {
                this.Name = "Q";
            }
            else
            {
                this.Name = "Black Queen";
            }
            this.isWhite = isWhite;
            this.order = order;
        }
    }

    class Pawn : Chess {
        public Pawn(bool isWhite, int order)
        {
            if (isWhite == true)
            {
                this.Name = "P";
            }
            else
            {
                this.Name = "Black Pawn";
            }
            this.isWhite = isWhite;
            this.order = order;
        }
    }

    class Bishop : Chess {
        public Bishop(bool isWhite, int order)
        {
            if (isWhite == true)
            {
                this.Name = "B";
            }
            else
            {
                this.Name = "Black Bishop";
            }
            this.isWhite = isWhite;
            this.order = order;
        }
    }


    class program { 
        public static void Main( string [] args)
        {
           
            Chess[] chessPieces = new Chess[32];
            chessPieces[0] = new Rook(true,1);
            chessPieces[1] = new Knight(true,2);
            chessPieces[2] = new Bishop(true,3);
            chessPieces[3] = new Queen(true,4);
            chessPieces[4] = new King(true,5);
            chessPieces[5] = new Bishop(true,6);
            chessPieces[6] = new Knight(true,7);
            chessPieces[7] = new Rook(true,8);
            for (int i = 8; i < 16; i++)
            {
                chessPieces[i] = new Pawn(true,i-7);
            }
            for (int i = 16; i < 24; i++)
            {
                chessPieces[i] = new Pawn(false,i-15);
            }
            chessPieces[24] = new Rook(false,1);
            chessPieces[25] = new Knight(false, 2);
            chessPieces[26] = new Bishop(false, 3);
            chessPieces[27] = new Queen(false, 4);
            chessPieces[28] = new King(false, 5);
            chessPieces[29] = new Bishop(false, 6);
            chessPieces[30] = new Knight(false, 7);
            chessPieces[31] = new Rook(false, 8);
            Game.SetPosition(chessPieces);
            Chess[,] chessBoard = new Chess[8, 8];

            // Populate the chessboard with the chess pieces
            for (int i = 0; i < chessPieces.Length; i++)
            {
                int x = chessPieces[i].X;
                int y = chessPieces[i].Y;
                chessBoard[x, y] = chessPieces[i];
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (chessBoard[i, j] == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(chessBoard[i, j].Name[0] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }


    }









using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        public static char getChar()
        {
            //gets and returns a char
            char c1 = 'n';
            String input = "";
            input = Console.ReadLine();
            c1 = Convert.ToChar(input);
            return c1;
        }

        public static int getInt()
        {
            //gets and returns an integer 
            int n1 = 0;
            String input = "";
            Console.WriteLine("Please enter an integer: ");
            input = Console.ReadLine();
            n1 = Convert.ToInt32(input);
            return n1;
        }

        public static void printDirections()
        {
            //prints the directions
            Console.WriteLine("                                    ");
            Console.WriteLine(" -------Let's Play Checkers!------- ");
            Console.WriteLine("    This program allows the user    ");
            Console.WriteLine("    to play checkers against the    ");
            Console.WriteLine("    computer by imputing a set of   ");
            Console.WriteLine("Letters and numbers to move whatever");
            Console.WriteLine("      piece they wish to move.      ");
            Console.WriteLine("  Pieces can only move diagonally   ");
            Console.WriteLine("     and can only move 1 square.    ");
            Console.WriteLine("       Squares marked with a -      ");
            Console.WriteLine("         Can be moved into.         ");
            Console.WriteLine("     The game is over whenever      ");
            Console.WriteLine("    either the computer or player   ");
            Console.WriteLine("         runs out of pieces.        ");
            Console.WriteLine("     You are the white pieces.      ");
            Console.WriteLine("  Standard pieces are denoted by a  ");
            Console.WriteLine("    w for white and b for black.    ");
            Console.WriteLine("         Kings are W and B.         ");
            Console.WriteLine("          You will go fist.         ");
            Console.WriteLine("            Let's Begin!            ");
            Console.WriteLine("                                    ");
        }

        public static void initBoardBoarders(char[,] board)
        {
            //letters tell collumn, num tell row
            board[0, 0] = '_';
            board[0, 1] = 'a';
            board[0, 2] = 'b';
            board[0, 3] = 'c';
            board[0, 4] = 'd';
            board[0, 5] = 'e';
            board[0, 6] = 'f';
            board[0, 7] = 'g';
            board[0, 8] = 'h';
            board[1, 0] = '1';
            board[2, 0] = '2';
            board[3, 0] = '3';
            board[4, 0] = '4';
            board[5, 0] = '5';
            board[6, 0] = '6';
            board[7, 0] = '7';
            board[8, 0] = '8';
        }

        public static void initBoardPieces(char[,] board)
        {
            //assigns board start....W for white pieces, B for black pieces, - for moveable squares,
            //_ for unmovable squares
            board[1, 1] = '_';
            board[1, 2] = 'b';
            board[1, 3] = '_';
            board[1, 4] = 'b';
            board[1, 5] = '_';
            board[1, 6] = 'b';
            board[1, 7] = '_';
            board[1, 8] = 'b';
            board[2, 1] = 'b';
            board[2, 2] = '_';
            board[2, 3] = 'b';
            board[2, 4] = '_';
            board[2, 5] = 'b';
            board[2, 6] = '_';
            board[2, 7] = 'b';
            board[2, 8] = '_';
            board[3, 1] = '_';
            board[3, 2] = 'b';
            board[3, 3] = '_';
            board[3, 4] = 'b';
            board[3, 5] = '_';
            board[3, 6] = 'b';
            board[3, 7] = '_';
            board[3, 8] = 'b';
            board[4, 1] = '-';
            board[4, 2] = '_';
            board[4, 3] = '-';
            board[4, 4] = '_';
            board[4, 5] = '-';
            board[4, 6] = '_';
            board[4, 7] = '-';
            board[4, 8] = '_';
            board[5, 1] = '_';
            board[5, 2] = '-';
            board[5, 3] = '_';
            board[5, 4] = '-';
            board[5, 5] = '_';
            board[5, 6] = '-';
            board[5, 7] = '_';
            board[5, 8] = '-';
            board[6, 1] = 'w';
            board[6, 2] = '_';
            board[6, 3] = 'w';
            board[6, 4] = '_';
            board[6, 5] = 'w';
            board[6, 6] = '_';
            board[6, 7] = 'w';
            board[6, 8] = '_';
            board[7, 1] = '_';
            board[7, 2] = 'w';
            board[7, 3] = '_';
            board[7, 4] = 'w';
            board[7, 5] = '_';
            board[7, 6] = 'w';
            board[7, 7] = '_';
            board[7, 8] = 'w';
            board[8, 1] = 'w';
            board[8, 2] = '_';
            board[8, 3] = 'w';
            board[8, 4] = '_';
            board[8, 5] = 'w';
            board[8, 6] = '_';
            board[8, 7] = 'w';
            board[8, 8] = '_';
        }

        public static void printBoard(char[,] board)
        {
            //prints the board
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("| ");
                    Console.Write(board[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
        }

        public static bool checkMove(char playerMoveLetter, char playerPieceLetter, int playerPieceNum,
             int playerMoveNum)
        {
            //checks for valid letters and numbers
            if ((playerMoveLetter == 'a') || (playerMoveLetter == 'b') || (playerMoveLetter == 'c') ||
               (playerMoveLetter == 'c') || (playerMoveLetter == 'e') || (playerMoveLetter == 'f') ||
               (playerMoveLetter == 'g') || (playerMoveLetter == 'h'))
            {
                if ((playerPieceLetter == 'a') || (playerPieceLetter == 'b') || (playerPieceLetter == 'c') ||
                    (playerPieceLetter == 'c') || (playerPieceLetter == 'e') || (playerPieceLetter == 'f') ||
                    (playerPieceLetter == 'g') || (playerPieceLetter == 'h'))
                {
                    if ((playerPieceNum == 1) || (playerPieceNum == 2) || (playerPieceNum == 3) ||
                        (playerPieceNum == 4) || (playerPieceNum == 5) || (playerPieceNum == 6) ||
                        (playerPieceNum == 7) || (playerPieceNum == 8))
                    {
                        if ((playerMoveNum == 1) || (playerPieceNum == 2) || (playerPieceNum == 3) ||
                            (playerPieceNum == 4) || (playerPieceNum == 5) || (playerPieceNum == 6) ||
                            (playerPieceNum == 7) || (playerPieceNum == 8))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static bool checkDiagonal(char playerMoveLetter, int playerMoveNum, char[,] board)
        {
            //checks to see if placement is valid square and moved 1 diagonal square
            int letterToNumMove = 0;

            if (playerMoveLetter == 'a')
            {
                letterToNumMove = 1;
            }
            else if (playerMoveLetter == 'b')
            {
                letterToNumMove = 2;
            }
            else if (playerMoveLetter == 'c')
            {
                letterToNumMove = 3;
            }
            else if (playerMoveLetter == 'd')
            {
                letterToNumMove = 4;
            }
            else if (playerMoveLetter == 'e')
            {
                letterToNumMove = 5;
            }
            else if (playerMoveLetter == 'f')
            {
                letterToNumMove = 6;
            }
            else if (playerMoveLetter == 'g')
            {
                letterToNumMove = 7;
            }
            else if (playerMoveLetter == 'h')
            {
                letterToNumMove = 8;
            }
            else
            {
                Console.WriteLine("Error");
            }

            if ((letterToNumMove != letterToNumMove - 1) && (playerMoveNum != playerMoveNum - 1) &&
                (letterToNumMove != letterToNumMove + 1) && (board[letterToNumMove, playerMoveNum] != 'b') && 
                (board[letterToNumMove, playerMoveNum] != 'B'))
            {
                return false;
            }
            else if ((letterToNumMove != letterToNumMove - 1) && (playerMoveNum != playerMoveNum - 1) &&
                (board[letterToNumMove, playerMoveNum] == 'b') || (board[letterToNumMove, playerMoveNum] == 'B'))
            {
                return true;
            }

            if (board[letterToNumMove, playerMoveNum] == '_')
            {
                return false;
            }

            return true;
        }

        public static int placePiece(char playerPieceLetter, int playerPieceNum,
            char playerMoveLetter, int playerMoveNum, char[,] board, int compPieces)
        {
            //converts collumn letter to int to play in board
            int letterToNumPiece = 0;
            int letterToNumMove = 0;

            if (playerPieceLetter == 'a')
            {
                letterToNumPiece = 1;
            }
            else if (playerPieceLetter == 'b')
            {
                letterToNumPiece = 2;
            }
            else if (playerPieceLetter == 'c')
            {
                letterToNumPiece = 3;
            }
            else if (playerPieceLetter == 'd')
            {
                letterToNumPiece = 4;
            }
            else if (playerPieceLetter == 'e')
            {
                letterToNumPiece = 5;
            }
            else if (playerPieceLetter == 'f')
            {
                letterToNumPiece = 6;
            }
            else if (playerPieceLetter == 'g')
            {
                letterToNumPiece = 7;
            }
            else if (playerPieceLetter == 'h')
            {
                letterToNumPiece = 8;
            }
            else
            {
                Console.WriteLine("Player piece to num error");
            }

            if (playerMoveLetter == 'a')
            {
                letterToNumMove = 1;
            }
            else if (playerMoveLetter == 'b')
            {
                letterToNumMove = 2;
            }
            else if (playerMoveLetter == 'c')
            {
                letterToNumMove = 3;
            }
            else if (playerMoveLetter == 'd')
            {
                letterToNumMove = 4;
            }
            else if (playerMoveLetter == 'e')
            {
                letterToNumMove = 5;
            }
            else if (playerMoveLetter == 'f')
            {
                letterToNumMove = 6;
            }
            else if (playerMoveLetter == 'g')
            {
                letterToNumMove = 7;
            }
            else if (playerMoveLetter == 'h')
            {
                letterToNumMove = 8;
            }
            else
            {
                Console.WriteLine("Player move to num error");
            }
            //checks for King to be made
            if ((board[letterToNumPiece, letterToNumMove] == board[1, 2]) ||
                (board[letterToNumPiece, letterToNumMove] == board[1, 4]) ||
                (board[letterToNumPiece, letterToNumMove] == board[1, 6]) ||
                (board[letterToNumPiece, letterToNumMove] == board[1, 8]))
            {
                board[letterToNumPiece, playerPieceNum] = '-';
                board[letterToNumMove, playerMoveNum] = 'W';
                Console.WriteLine("You got a King!");
            }
            //checks for jump of comp piece
            else if ((letterToNumMove != letterToNumMove - 1) && (playerMoveNum != playerMoveNum - 1) &&
                (board[letterToNumMove, playerMoveNum] == 'b') || (board[letterToNumMove, playerMoveNum] == 'B'))
            {
                compPieces -= 1;
                board[letterToNumPiece, playerPieceNum] = '-';
                board[letterToNumMove, playerMoveNum] = 'w';
            }
            //places standard piece
            else
            {
                board[letterToNumPiece, playerPieceNum] = '-';
                board[letterToNumMove, playerMoveNum] = 'w';
            }
            return compPieces;
        }

        public static bool checkKing(char playerPieceLetter, int playerMoveNum, char[,] board)
        {
            int letterToNumPiece = 0;

            if (playerPieceLetter == 'a')
            {
                letterToNumPiece = 1;
            }
            else if (playerPieceLetter == 'b')
            {
                letterToNumPiece = 2;
            }
            else if (playerPieceLetter == 'c')
            {
                letterToNumPiece = 3;
            }
            else if (playerPieceLetter == 'd')
            {
                letterToNumPiece = 4;
            }
            else if (playerPieceLetter == 'e')
            {
                letterToNumPiece = 5;
            }
            else if (playerPieceLetter == 'f')
            {
                letterToNumPiece = 6;
            }
            else if (playerPieceLetter == 'g')
            {
                letterToNumPiece = 7;
            }
            else if (playerPieceLetter == 'h')
            {
                letterToNumPiece = 8;
            }
            else
            {
                Console.WriteLine("Player piece to num error");
            }

            if (board[letterToNumPiece, playerMoveNum] == 'W')
            {
                return true;
            }
            return false;
        }

        public static int placeKing(char playerPieceLetter, int playerPieceNum,
            char playerMoveLetter, int playerMoveNum, char[,] board, int compPieces)
        {
            int letterToNumPiece = 0;
            int letterToNumMove = 0;

            if (playerPieceLetter == 'a')
            {
                letterToNumPiece = 1;
            }
            else if (playerPieceLetter == 'b')
            {
                letterToNumPiece = 2;
            }
            else if (playerPieceLetter == 'c')
            {
                letterToNumPiece = 3;
            }
            else if (playerPieceLetter == 'd')
            {
                letterToNumPiece = 4;
            }
            else if (playerPieceLetter == 'e')
            {
                letterToNumPiece = 5;
            }
            else if (playerPieceLetter == 'f')
            {
                letterToNumPiece = 6;
            }
            else if (playerPieceLetter == 'g')
            {
                letterToNumPiece = 7;
            }
            else if (playerPieceLetter == 'h')
            {
                letterToNumPiece = 8;
            }
            else
            {
                Console.WriteLine("Player piece to num error");
            }

            if (playerMoveLetter == 'a')
            {
                letterToNumMove = 1;
            }
            else if (playerMoveLetter == 'b')
            {
                letterToNumMove = 2;
            }
            else if (playerMoveLetter == 'c')
            {
                letterToNumMove = 3;
            }
            else if (playerMoveLetter == 'd')
            {
                letterToNumMove = 4;
            }
            else if (playerMoveLetter == 'e')
            {
                letterToNumMove = 5;
            }
            else if (playerMoveLetter == 'f')
            {
                letterToNumMove = 6;
            }
            else if (playerMoveLetter == 'g')
            {
                letterToNumMove = 7;
            }
            else if (playerMoveLetter == 'h')
            {
                letterToNumMove = 8;
            }
            else
            {
                Console.WriteLine("Player move to num error");
            }

            while ((letterToNumMove != letterToNumMove + 1) && (playerMoveNum != playerMoveNum + 1) &&
                    (playerMoveNum != playerMoveNum - 1) && (letterToNumMove != letterToNumMove - 1) &&
                    (board[letterToNumMove - 1, playerMoveNum - 1] != 'b') && (board[letterToNumMove - 1, playerMoveNum - 1] != 'B') &&
                    (board[letterToNumMove + 1, playerMoveNum + 1] != 'b') && (board[letterToNumMove + 1, playerMoveNum + 1] != 'b'))
            {
                Console.WriteLine("Please enter the letter of the spot you want to move to.");
                playerMoveLetter = getChar();
                Console.WriteLine("Please enter the number of the spot you want to move to.");
                playerMoveNum = getInt();
            }
            if ((letterToNumMove != letterToNumMove + 1) && (playerMoveNum != playerMoveNum + 1) &&
                    (playerMoveNum != playerMoveNum - 1) && (letterToNumMove != letterToNumMove - 1))
            {
                if ((board[letterToNumMove - 1, playerMoveNum - 1] == 'b') || (board[letterToNumMove - 1, playerMoveNum - 1] == 'B') ||
                (board[letterToNumMove + 1, playerMoveNum + 1] == 'b') || (board[letterToNumMove + 1, playerMoveNum + 1] == 'b'))
                {
                    compPieces -= 1;
                }
            }
            board[letterToNumMove, playerMoveNum] = 'W';
            board[letterToNumPiece, playerPieceNum] = '-';
            return compPieces;
        }

        public static int playerMove(bool validMove, bool validDiagonal, char playerPieceLetter, int playerPieceNum,
            char playerMoveLetter, int playerMoveNum, char[,] board, bool isKing, int compPieces, int playerPieces)
        {
            //gets player move by entering 4 options to pick piece and movement 
            while ((validMove == false) && (validDiagonal == false))
            {
                Console.WriteLine("Pick which White piece you wish to move.");
                Console.WriteLine("Please enter the letter of the piece you want to move.");
                playerPieceLetter = getChar();
                Console.WriteLine("Please enter the number of the piece you want to move");
                playerPieceNum = getInt();
                Console.WriteLine("Now pick where you want to move it.");
                Console.WriteLine("Remeber, you can only move diagonally");
                Console.WriteLine("and cannot jump over your own pieces.");
                Console.WriteLine("Please enter the letter of the spot you want to move to.");
                playerMoveLetter = getChar();
                Console.WriteLine("Please enter the number of the spot you want to move to.");
                playerMoveNum = getInt();
                validMove = checkMove(playerMoveLetter, playerPieceLetter, playerPieceNum, playerMoveNum);
                isKing = checkKing(playerPieceLetter, playerPieceNum, board);
                if (isKing == true)
                {
                    compPieces = placeKing(playerPieceLetter, playerPieceNum, playerMoveLetter, playerMoveNum, board, compPieces);
                }
                else
                {
                    validDiagonal = checkDiagonal(playerMoveLetter, playerMoveNum, board);
                    compPieces = placePiece(playerPieceLetter, playerPieceNum, playerMoveLetter, playerMoveNum, board, compPieces);
                }
            }
            return compPieces;
        }

        public static int compMove(char[,] board, int playerPieces)
        {
            int compMoveNum = 0;
            int compMoveLetter = 0;
            int compPieceNum = 0;
            int compPieceLetter = 0;

            Random r1 = new Random();

            for (int i = 0; i < 3; i++)
            {
                if ((board[2, i] == 'w') || (board[2, i] == 'W'))
                {
                    if (board[1, i - 1] == 'b')
                    {
                        board[3, i + 1] = 'b';
                    }
                    else if (board[1, i + 1] == 'b')
                    {
                        board[3, i - 1] = 'b';
                    }
                    else
                    {
                        Console.WriteLine("The computer is unable to jump your piece.");
                    }
                }
            }
            compMoveLetter = r1.Next(1, 9);
            compMoveNum = r1.Next(1, 9);
            compPieceLetter = r1.Next(1, 9);
            compPieceNum = r1.Next(1, 9);
            if ((board[compPieceLetter, compMoveLetter] != 'B'))
            {
                while ((board[compPieceLetter, compMoveLetter] != 'b') ||
                        (board[compMoveLetter, compMoveNum] == '_') || (compPieceLetter + 1 != compMoveLetter) ||
                        (compPieceLetter - 1 != compMoveLetter) || (compPieceNum + 1 != compMoveNum) ||
                        (compPieceNum - 1 != compMoveNum))
                {
                    if ((board[compPieceLetter, compMoveLetter] != 'b') && (board[compMoveLetter, compMoveNum] == '-') &&
                        (board[compPieceLetter, compMoveLetter] != 'B'))
                    {
                        compPieceLetter = r1.Next(1, 9);
                    }
                    else if (board[compMoveLetter, compMoveNum] != '_')
                    {
                        compMoveLetter = r1.Next(1, 9);
                    }
                    else
                    {
                        compPieceLetter = r1.Next(1, 9);
                        compPieceNum = r1.Next(1, 9);
                        compMoveLetter = r1.Next(1, 9);
                        compMoveNum = r1.Next(1, 9);
                    }
                }
            }
            else if (board[compPieceLetter, compPieceNum] == 'B')
            {
                while ((board[compMoveLetter, compMoveNum] == '_') || (compPieceLetter + 1 != compMoveLetter) || 
                    (compPieceLetter - 1 != compMoveLetter) || (compPieceNum + 1 != compMoveNum) || 
                    (compPieceNum - 1 != compMoveNum))
                {
                    if ((board[compPieceLetter, compMoveLetter] != 'B') && (board[compMoveLetter, compMoveNum] == '-'))
                    {
                        compPieceLetter = r1.Next(1, 9);
                    }
                    else if (board[compMoveLetter, compMoveNum] != '_')
                    {
                        compMoveLetter = r1.Next(1, 9);
                    }
                    else
                    {
                        compPieceLetter = r1.Next(1, 9);
                        compPieceNum = r1.Next(1, 9);
                        compMoveLetter = r1.Next(1, 9);
                        compMoveNum = r1.Next(1, 9);
                    }
                }
            }

            if((board[compMoveLetter, compMoveNum]=='w')||(board[compMoveLetter, compMoveNum] == 'W'))
            {
                if(board[compMoveLetter+1, compMoveNum+1]=='-')
                {
                    if(board[compPieceLetter, compPieceNum]=='B')
                    {
                        board[compMoveLetter + 1, compMoveNum + 1] = 'B';
                        board[compPieceLetter, compPieceNum] = '-';
                    }
                    else
                    {
                        board[compMoveLetter + 1, compMoveNum + 1] = 'b';
                        board[compPieceLetter, compPieceNum] = '-';
                    }
                    playerPieces -= 1;
                }
                else if (board[compMoveLetter - 1, compMoveNum + 1] == '-')
                {
                    if (board[compPieceLetter, compPieceNum] == 'B')
                    {
                        board[compMoveLetter - 1, compMoveNum + 1] = 'B';
                        board[compPieceLetter, compPieceNum] = '-';
                    }
                    else
                    {
                        board[compMoveLetter - 1, compMoveNum + 1] = 'b';
                        board[compPieceLetter, compPieceNum] = '-';
                    }
                }
                else
                {
                    if (board[compPieceLetter, compPieceNum] == 'B')
                    {
                        board[compMoveLetter, compMoveNum] = 'B';
                        board[compPieceLetter, compPieceNum] = '-';
                    }
                    else
                    {
                        board[compMoveLetter, compMoveNum] = 'b';
                        board[compPieceLetter, compPieceNum] = '-';
                    }
                }
            }
            else if((board[compMoveLetter, compMoveNum] ==board[8,1])|| (board[compMoveLetter, compMoveNum] == board[8, 3])||
                    (board[compMoveLetter, compMoveNum] == board[8, 5])|| (board[compMoveLetter, compMoveNum] == board[8, 7]))
            {
                board[compMoveLetter, compMoveNum] = 'B';
                board[compPieceLetter, compPieceNum] = '-';
                Console.WriteLine("The Computer got a King!");
            }

            else
            {
                if (board[compPieceLetter, compPieceNum] == 'B')
                {
                    board[compMoveLetter, compMoveNum] = 'B';
                    board[compPieceLetter, compPieceNum] = '-';
                }
                else
                {
                    board[compMoveLetter, compMoveNum] = 'b';
                    board[compPieceLetter, compPieceNum] = '-';
                }
            }
            return playerPieces;
        }

        public static int playCheckers(int win, char[,] board)
        {
            //Player is white; comp is black
            //2 = player loss 1= player twin

            int playerPieces = 12;
            int compPieces = 12;
            char playerPieceLetter = 'n';
            int playerPieceNum = 0;
            char playerMoveLetter = 'n';
            int playerMoveNum = 0;
            bool validMove = false;
            bool validDiagonal = false;
            bool isKing = false;

            while (win == 0)
            {
                printBoard(board);
                if (playerPieces == 0)
                {
                    win = 2;
                }
                compPieces = playerMove(validMove, validDiagonal, playerPieceLetter, playerPieceNum, playerMoveLetter, playerMoveNum, board, isKing, compPieces, playerPieces);
                if (compPieces == 0)
                {
                    win = 1;
                }
                playerPieces = compMove(board, playerPieces);
            }
            return win;
        }

        public static void printWinner(int winner)
        {
            //2 = player loss 1= player twin

            if (winner == 2)
            {
                Console.WriteLine("The computer won.");
                Console.WriteLine("Better luck next time.");
            }
            else if (winner == 1)
            {
                Console.WriteLine("You won!");
                Console.WriteLine("Congratulations!");
            }
            else
            {
                Console.WriteLine("Win condition error");
            }
        }

        public static void checkers()
        {
            int playWin = 0;

            char[,] board = new char[9, 9];

            printDirections();
            initBoardBoarders(board);
            initBoardPieces(board);
            playCheckers(playWin, board);
            printWinner(playWin);
        }

        static void Main(string[] args)
        {
            checkers();
        }
    }
}
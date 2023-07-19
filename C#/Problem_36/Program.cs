using System.Collections.Generic;

namespace Problem_36
{
    // 36. Valid Sudoku
    // https://leetcode.com/problems/valid-sudoku/
    internal class Program
    {
        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<char> s = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    if (char.IsDigit(board[i][j]))
                    {
                        if (s.Contains(board[i][j]))
                            return false;
                        else
                            s.Add(board[i][j]);
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                HashSet<char> s = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    if (char.IsDigit(board[j][i]))
                    {
                        if (s.Contains(board[j][i]))
                            return false;
                        else
                            s.Add(board[j][i]);
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                HashSet<char> s = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    int r = 3 * (i / 3) + j / 3;
                    int c = 3 * (i % 3) + j % 3;
                    if (char.IsDigit(board[r][c]))
                    {
                        if (s.Contains(board[r][c]))
                            return false;
                        else
                            s.Add(board[r][c]);
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            char[][] board1 = new char[][] {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            bool isValidBoard1 = IsValidSudoku(board1);

            char[][] board2 = new char[][] {
                new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            bool isValidBoard2 = IsValidSudoku(board2);
        }
    }
}

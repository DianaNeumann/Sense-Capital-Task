namespace Domain.Boards.Tools;

public static class BoardStateChecker
{
    private static readonly int[][] WinLines = new int[][]
    {
        new int[] {0, 1, 2},  
        new int[] {3, 4, 5},
        new int[] {6, 7, 8},
        new int[] {0, 3, 6},
        new int[] {1, 4, 7},
        new int[] {2, 5, 8},
        new int[] {0, 4, 8},
        new int[] {2, 4, 6}
    };

    public static bool CheckWin(char[] board)
    {
        return WinLines
            .Any(winLine => 
                board[winLine[0]] == board[winLine[1]] &&
                board[winLine[1]] == board[winLine[2]] &&
                board[winLine[0]] != '0'); // not default value (0)
    }

    public static bool IsFull(char[] board)
    {
        return board.All(c => c != '0');
    }
}
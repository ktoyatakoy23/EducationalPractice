class Program
{
    const int N = 9;
    static int[,] board = new int[N, N];
    static bool IsSafe(int row, int col, int num)
    {
        for (int i = 0; i < N; i++)
        {
            if (board[row, i] == num || board[i, col] == num)
            {
                return false;
            }
        }
        int startRow = row - row % 3;
        int startCol = col - col % 3;
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (board[i, j] == num)
                {
                    return false;
                }
            }
        }
        return true;
    }
    static bool SolveSudoku()
    {
        int row = -1;
        int col = -1;
        bool isEmpty = true;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (board[i, j] == 0)
                {
                    row = i;
                    col = j;
                    isEmpty = false;
                    break;
                }
            }
            if (!isEmpty)
            {
                break;
            }
        }
        if (isEmpty)
        {
            return true;
        }
        for (int num = 1; num <= N; num++)
        {
            if (IsSafe(row, col, num))
            {
                board[row, col] = num;
                if (SolveSudoku())
                {
                    return true;
                }
                board[row, col] = 0;
            }
        }
        return false;
    }
    static void PrintBoard()
    {
        for (int i = 0; i < 9; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("                           ");
            }
            for (int j = 0; j < 9; j++)
            {
                if (j == 0)
                {
                }
                if (j % 3 == 0)
                {
                    Console.Write("  ");
                }
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine("                           ");
    }
    static void GenerateBoard()
    {
        List<int> numbers = Enumerable.Range(1, N).ToList();
        Random random = new Random();
        numbers = numbers.OrderBy(x => random.Next()).ToList();
        for (int i = 0; i < N; i++)
        {
            board[0, i] = numbers[i];
        }
        SolveSudoku();
        int blanks = 45;
        while (blanks > 0)
        {
            int row = random.Next(N);
            int col = random.Next(N);
            if (board[row, col] != 0)
            {
                board[row, col] = 0;
                blanks--;
            }
        }
    }
    static (int, int, int) GetInput()
    {
        int row, col, num;
        while (true)
        {
            Console.WriteLine("Введите номер строки, столбца и число через пробел (или 0 0 0 для выхода):");
            string input = Console.ReadLine();
            string[] parts = input.Split();
            if (parts.Length == 3 && int.TryParse(parts[0], out row) && int.TryParse(parts[1], out col) && int.TryParse(parts[2], out num))
            {
                if (row >= 0 && row <= N && col >= 0 && col <= N && num >= 0 && num <= N)
                {
                    return (row, col, num);
                }
            }
            Console.WriteLine("Неверный ввод. Повторите попытку.");
        }
    }
    static bool IsGameOver()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (board[i, j] == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
    static void PlayGame()
    {
        GenerateBoard();
        PrintBoard();
        while (!IsGameOver())
        {
            var (row, col, num) = GetInput();
            if (row == 0 && col == 0 && num == 0)
            {
                Console.WriteLine("Выход из игры.");
                break;
            }
            if (IsSafe(row - 1, col - 1, num))
            {
                board[row - 1, col - 1] = num;
                Console.WriteLine("Число размещено.");
            }
            else
            {
                Console.WriteLine("Число не может быть размещено.");
            }
            PrintBoard();
        }
        if (IsGameOver())
        {
            Console.WriteLine("Поздравляем! Вы решили судоку!");
        }
    }

    static void Main(string[] args)
    {
        PlayGame();
    }
}

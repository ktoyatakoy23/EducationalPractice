using System;


Random rand1 = new Random();
Random rand2 = new Random();
int firstLetter = rand1.Next(2,7);
int secondLetter = rand2.Next(2,7);

int[,] gamefield = new int[firstLetter, secondLetter];


for (int i = 0; i < gamefield.GetLength(0); i++) 
{
    for (int j = 0; j < gamefield.GetLength(1); j++)
    {
        Console.WriteLine("массив создается....");
        var dot = 0;
        gamefield[i, j] = dot;

    }
}


Console.WriteLine("массив: ");

for (int i = 0; i < gamefield.GetLength(0); i++)
{
    for (int j = 0; j < gamefield.GetLength(1); j++)
    {
        Console.Write(gamefield[i, j] + " ");
    }
    Console.WriteLine("");
}

Console.WriteLine("");

int startX = 0;
int startY = 0;
int endX = firstLetter - 1;
int endY = secondLetter - 1;
int numberOfPaths = 0;
void FindPaths(int currentX, int currentY)
{
   
    if (currentX == endX && currentY == endY)
    {
        numberOfPaths++;
        return;
    }
    
    if (currentX < endX && gamefield[currentX + 1, currentY] == 0)
    {
        FindPaths(currentX + 1, currentY);
    }
    
    if (currentY < endY && gamefield[currentX, currentY + 1] == 0)
    {
        FindPaths(currentX, currentY + 1);
    }
}

FindPaths(startX, startY);
Console.WriteLine("Количество путей: " + numberOfPaths);

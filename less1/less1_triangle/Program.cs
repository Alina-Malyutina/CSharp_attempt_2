Console.Clear();
//Console.SetCursorPosition(5, 5);
//Console.WriteLine("+");

int xa = 17, ya = 0,
    xb = 5, yb = 8,
    xc = 30, yc = 8;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0;

while (count < 1000)
{
     int a = new Random().Next(0, 3);
    if (a == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }

    if (a == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }

    if (a == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition (x,y);
    Console.WriteLine("+");
    count+=1;
    
}
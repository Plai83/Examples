

Console.Clear();
int xa = 25;
int ya = 1;
int xb = 1;
int yb = 14;
int xc = 50;
int yc = 14;


Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = ya;
int count = 0;

while (count < 1000)
{
    int rand = new Random().Next(0, 3);
    if (rand == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (rand == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (rand == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
    
}



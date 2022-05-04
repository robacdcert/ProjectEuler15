//Project euler 15
//Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
//How many such routes are there through a 20×20 grid?

long grid = 1099510579200;
long index = 1;
string path;
long count = 0;

while (index < grid)
{
    path = Convert.ToString(index, 2);
    if (path.Count(f => (f == '1')) == 20)
    {
        count++;
        Console.WriteLine("Path: " + path + "  Length: " + path.Length + "  Count: " + count);
    }
    index++;
}

Console.WriteLine("Answer: " + count);
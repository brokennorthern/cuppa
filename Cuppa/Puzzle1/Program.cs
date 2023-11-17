using System.IO;
using System;


//var path = Path.Combine(Directory.GetCurrentDirectory(), "inputtext.txt");

string[] lines = File.ReadAllLines("C:/Users/markc/source/repos/CuppaFirst/Cuppa/Puzzle1/inputtext.txt");

int max = 0;
int cur = 0;

foreach (string line in lines)
{
    if (line != "")
    {
        int x = int.Parse(line);
        cur += x;
    }
    else
    {
        if (cur > max)
        {
            max = cur;

        }
        cur = 0;
    }
}

Console.WriteLine(max);
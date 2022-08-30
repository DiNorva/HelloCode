﻿/*

using System.Linq;

// Console.WriteLine(a.GetType());

var data = new int[] { 1, 2, 3, 4 }
           .Where(e => e > 0)
           .Select(e => new { q = e, w = e + 1 });
Console.WriteLine(data.GetType());

*/

using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
              .Replace("(", "")
              .Replace("(", "")
              ;
Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)
                .Select(point => (point.x * 10, point.y))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
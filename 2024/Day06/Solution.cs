namespace AdventOfCode.Y2024.Day06;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

[ProblemName("Guard Gallivant")]
class Solution : Solver {

    public object PartOne(string input) {
        var coords = Coords(input);
        var start = coords.FirstOrDefault(guard => guard.Value == '^').Key;

        while (true) {
            var next = Obstacle(start, coords.GetValueOrDefault(start), coords);
            if (next == (-1,-1)) break;
            
            switch (coords.GetValueOrDefault(start))
            {
                case '^': 
                    coords[next] = '>';
                    break;
                case '>': 
                    coords[next] = 'v';
                    break;
                case 'v': 
                    coords[next] = '<';
                    break;
                case '<': 
                    coords[next] = '^';
                    break;
                default: 
                    throw new Exception("Invalid direction");
            }
            coords[start] = 'X';
            start = next;
        }
        return coords.Values.Count(c => c == 'X') + 1;
    }

    public object PartTwo(string input) {
        return 0;
    }

    Dictionary<(int, int), char> Coords(string input) {
        var coords = new Dictionary<(int, int), char>();
        var lines = input.Split("\n");
        for (int y = 0; y < lines.Length; y++) {
            for (int x = 0; x < lines[y].Length; x++) {
                coords[(x, y)] = lines[y][x];
            }
        }
        return coords;
    }

    private (int, int) Obstacle((int, int) pos, char dir, Dictionary<(int, int), char> coords) {
        bool IsObstacle = false;
        while (!IsObstacle) {
            var next = Move(pos, dir);
            if (coords.GetValueOrDefault(next) == '#') return pos;
            if (coords.GetValueOrDefault(next) == '\0') return (-1,-1);
            pos = next;
            coords[next] = 'X';
        }
        return (-1,-1);
    }
    (int, int) Move((int, int) pos, char dir) {
        switch (dir) {
            case '^': return (pos.Item1, pos.Item2 - 1);
            case 'v': return (pos.Item1, pos.Item2 + 1);
            case '<': return (pos.Item1 - 1, pos.Item2);
            case '>': return (pos.Item1 + 1, pos.Item2);
            default: throw new Exception("Invalid direction");
        }
    }
}
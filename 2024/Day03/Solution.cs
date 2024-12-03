namespace AdventOfCode.Y2024.Day03;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using AngleSharp.Text;

[ProblemName("Mull It Over")]
class Solution : Solver {

    public object PartOne(string input) {
        string pattern = @"(?:mul\((?<x>[0-9]{1,3}),(?<y>[0-9]{1,3})\))";
        var matches = Regex.Matches(input, pattern);
        var total = 0;
        foreach (Match mul in matches) {
            var x = int.Parse(mul.Groups["x"].Value);
            var y = int.Parse(mul.Groups["y"].Value);
            //Console.WriteLine($"{x} * {y} = {x * y}");
            total += x * y;
        }
        return total;
    }

    public object PartTwo(string input) {
        return 0;
    }
}
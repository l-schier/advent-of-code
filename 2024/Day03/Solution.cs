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
        string pattern = @"(?:mul\((?<x>\d{1,3}),(?<y>\d{1,3})\))";
        var matches = Regex.Matches(input, pattern);
        var total = 0;
        foreach (Match mul in matches) {
            var x = int.Parse(mul.Groups["x"].Value);
            var y = int.Parse(mul.Groups["y"].Value);
            total += x * y;
        }
        return total;
    }

    public object PartTwo(string input) {
        string pattern = @"(?<do>do\(\))|(?<mul>mul\((?<x>\d{1,3}),(?<y>\d{1,3})\))|(?<dont>don't\(\))";
        var matches = Regex.Matches(input, pattern);
        bool doFlag = true;
        long total = 0;
        foreach (Match match in matches) {

            if (match.Groups["do"].Success) {
                doFlag = true;
            }
            else if (match.Groups["dont"].Success) {
                doFlag = false;
            }
            else if (match.Groups["mul"].Success) {
                if (doFlag) {
                    var x = int.Parse(match.Groups["x"].Value);
                    var y = int.Parse(match.Groups["y"].Value);
                    total += x * y;
                }
            }
        }
        return total;
    }
}
namespace AdventOfCode.Y2024.Day02;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

[ProblemName("Red-Nosed Reports")]
class Solution : Solver {

    public object PartOne(string input) {
        return ParseSamples(input).Count(Valid);
    }

    public object PartTwo(string input) {
        return ParseSamples(input).Count(levels => Dampener(levels).Any(Valid));
    }

    IEnumerable<int[]> ParseSamples(string input) =>
        from line in input.Split("\n")
        let levels = line.Split(" ").Select(int.Parse)
        select levels.ToArray();
    
    bool Valid(int[] levels) {
        var pairs = Enumerable.Zip(levels, levels.Skip(1));
        return 
            pairs.All(p => 1 <= p.Second - p.First && p.Second - p.First <= 3) ||
            pairs.All(p => 1 <= p.First - p.Second && p.First - p.Second <= 3);
    }

    IEnumerable<int[]> Dampener(int[] levels) =>
        from i in Enumerable.Range(0, levels.Length+1)
        let before = levels.Take(i - 1)
        let after = levels.Skip(i)
        select Enumerable.Concat(before, after).ToArray();
}
namespace AdventOfCode.Y2024.Day01;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

[ProblemName("Historian Hysteria")]
class Solution : Solver {

    public object PartOne(string input) {
        return Enumerable.Zip(Column(input, 0), Column(input, 1))
            .Select(pair => Math.Abs(pair.First - pair.Second))
            .Sum();
    }

    public object PartTwo(string input) {
        var weights = Column(input, 1).CountBy(x => x).ToDictionary();
        return Column(input, 0)
            .Select(num => weights.GetValueOrDefault(num) * num).Sum();
    }

    IEnumerable<int> Column(string input, int index) =>
    from line in input.Split("\n")
    let nums = line.Split("   ").Select(int.Parse).ToArray()
    orderby nums[index]
    select nums[index];
}
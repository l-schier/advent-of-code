namespace AdventOfCode.Y2024.Day04;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

[ProblemName("Ceres Search")]
class Solution : Solver {

    public object PartOne(string input) {
        string[] lines = input.Split('\n');
        int count = 0;
        string target = "XMAS";
        int rows = lines.Length;
        int cols = lines[0].Length;

        // Check all directions
        int[][] directions = [
            [0,  1],  // right
            [0, -1],  // left
            [1,  0],  // down
            [1,  1],  // down-right
            [1, -1],  // down-left
            [-1,  0], // up
            [-1, -1], // up-left
            [-1,  1]  // up-right
        ];

        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; col++) {
            foreach (var dir in directions) {
                bool found = true;
                
                for (int i = 0; i < target.Length; i++) {
                    int newRow = row + i * dir[0];
                    int newCol = col + i * dir[1];
                    
                    if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= cols || lines[newRow][newCol] != target[i]) {
                        found = false;
                        break;
                    }
                }
                if (found) count++;
            }
            }
        }
        //count += Regex.Matches(input, @"XMAS|SAMX").Count;
        return count;
    }

    public object PartTwo(string input) {
        return 0;
    }
}
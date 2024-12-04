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
        return count;
    }

    public object PartTwo(string input) {
        string[] lines = input.Split('\n');
        int count = 0;
        int rows = lines.Length;
        int cols = lines[0].Length;

        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; col++) {
                bool found = false;

                if (lines[row][col] == 'A') {
                    int[] top_left = [row - 1, col - 1];
                    int[] top_right = [row - 1, col + 1];
                    int[] bottom_left = [row + 1, col - 1];
                    int[] bottom_right = [row + 1, col + 1];

                    if (top_left[0] >= 0 && top_left[1] >= 0 && bottom_right[0] < rows && bottom_right[1] < cols && top_right[0] >= 0 && top_right[1] < cols && bottom_left[0] < rows && bottom_left[1] >= 0) {
                        char[] corners = [
                            lines[top_left[0]][top_left[1]],
                            lines[bottom_right[0]][bottom_right[1]],
                            lines[top_right[0]][top_right[1]],
                            lines[bottom_left[0]][bottom_left[1]]
                        ];
                        if (
                            ((corners[0] == 'M' && corners[1] == 'S') ||
                            (corners[0] == 'S' && corners[1] == 'M')) &&
                            ((corners[2] == 'M' && corners[3] == 'S') ||
                            (corners[2] == 'S' && corners[3] == 'M'))
                        ) {
                            found = true;
                        }
                    }

                }
                if (found) count++;
            }
        }
        return count;
    }
}
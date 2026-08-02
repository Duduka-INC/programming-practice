using LeetCode.BinarySearch;
using LeetCode.HashTables;
using LeetCode.Pointers;
using LeetCode.SlidingWindows;

// var num1 = new int[] { 1, 2, 3, 0, 0, 0 };
// var num2 = new int[] { 2, 5, 6 };
// var m = 3;
// var n = 3;
//
// var solution = new MergeSortedArray();
//
// var result = solution.SolveMyOwn(num1, m, num2, n);


// var nums = new int[] { 7, 7 };
// var target = 1;
//
// var solution = new TopKFrequentElements();
// var result = solution.Solve(nums, target);

var s = "pwwkew";

var solution = new LongestSubstringWithoutRepeatingCharacters();

var result = solution.SolveMyOwn(s);

Console.WriteLine(result);
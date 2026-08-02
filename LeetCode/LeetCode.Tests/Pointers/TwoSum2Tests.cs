using LeetCode.Pointers;

namespace Tests.Pointers;

public class TwoSum2Tests
{
    public static IEnumerable<object[]> TestCases => new List<object[]>
    {
        // базовые
        new object[] { new[] {2,7}, 9, new[] {1,2} },
        new object[] { new[] {2,7,11,15}, 9, new[] {1,2} },
        new object[] { new[] {2,3,4}, 6, new[] {1,3} },
        new object[] { new[] {-1,0}, -1, new[] {1,2} },

        // отрицательные
        new object[] { new[] {-10,-5,-2,-1}, -7, new[] {2,3} },
        new object[] { new[] {-10,-3,0,1,2}, -2, new[] {2,4} },
        new object[] { new[] {-8,-4,-1,3,10}, 2, new[] {1,5} },

        // смешанные
        new object[] { new[] {-5,-3,0,3,5}, 0, new[] {1,5} },
        new object[] { new[] {-2,-1,1,2,3}, 1, new[] {1,5} },
        new object[] { new[] {-4,-1,0,2,4}, 3, new[] {2,5} },

        // дубликаты
        new object[] { new[] {1,1,3,4}, 2, new[] {1,2} },
        new object[] { new[] {2,2,2,3}, 4, new[] {1,2} },
        new object[] { new[] {1,2,3,4,4}, 8, new[] {4,5} },
        new object[] { new[] {1,1,1,2,3}, 4, new[] {3,5} },

        // края массива
        new object[] { new[] {1,2,3,4,5,6}, 7, new[] {1,6} },
        new object[] { new[] {1,2,3,9,10}, 19, new[] {4,5} },
        new object[] { new[] {0,1,2,3,4}, 1, new[] {1,2} },

        // границы значений
        new object[] { new[] {-1000,0,1000}, 0, new[] {1,3} },
        new object[] { new[] {-1000,-500,500,1000}, 0, new[] {1,4} },
        new object[] { new[] {-1000,1000}, 0, new[] {1,2} },

        // плотные значения
        new object[] { new[] {1,2,3,4,5}, 9, new[] {4,5} },
        new object[] { new[] {1,2,3,4,5}, 3, new[] {1,2} },
        new object[] { new[] {1,2,3,4,5}, 6, new[] {2,4} },

        // длинный массив
        new object[] { new[] {1,2,3,4,5,6,7,8,9,10}, 19, new[] {9,10} },
        new object[] { new[] {1,2,3,4,5,6,7,8,9,10}, 3, new[] {1,2} },
        new object[] { new[] {1,2,3,4,5,6,7,8,9,10}, 11, new[] {1,10} },

        // сложные сдвиги указателей
        new object[] { new[] {1,3,4,6,8,10}, 13, new[] {2,6} },
        new object[] { new[] {1,2,5,6,7,9}, 11, new[] {3,4} }, // 5+6
        new object[] { new[] {2,3,4,8,11,15}, 19, new[] {3,6} },

        // edge
        new object[] { new[] {0,0,3,4}, 0, new[] {1,2} },
        new object[] { new[] {5,25,75}, 100, new[] {2,3} },
        new object[] { new[] {1,2}, 3, new[] {1,2} }
    };

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Should_Work_Correctly(int[] nums, int target, int[] expected)
    {
        var solution = new TwoSum2();
        var actual = solution.Solve(nums, target);
        
        Assert.Equal(expected, actual);
    }
}
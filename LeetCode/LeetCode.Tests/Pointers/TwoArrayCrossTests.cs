using LeetCode.Pointers;
using Xunit;

namespace Tests.Pointers;

public class TwoArrayCrossTests
{
    public static IEnumerable<object[]> TestCases =>
        new List<object[]>
        {
            // Базовый кейс
            new object[] { new[] { 1, 2, 2, 3 }, new[] { 2, 2, 4 }, new[] { 2, 2 } },

            // Полное совпадение
            new object[] { new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3 } },

            // Нет общих элементов
            new object[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, Array.Empty<int>() },

            // Один общий элемент
            new object[] { new[] { 1, 3, 5 }, new[] { 2, 3, 4 }, new[] { 3 } },

            // Дубликаты в обоих, кратность сохраняется по минимуму
            new object[] { new[] { 1, 2, 2, 2, 3 }, new[] { 2, 2, 4 }, new[] { 2, 2 } },

            // Все элементы одинаковые
            new object[] { new[] { 2, 2, 2 }, new[] { 2, 2 }, new[] { 2, 2 } },

            // Один массив пустой
            new object[] { Array.Empty<int>(), new[] { 1, 2, 3 }, Array.Empty<int>() },

            // Оба массива пустые
            new object[] { Array.Empty<int>(), Array.Empty<int>(), Array.Empty<int>() },

            // Один элемент и совпадает
            new object[] { new[] { 5 }, new[] { 5 }, new[] { 5 } },

            // Один элемент и не совпадает
            new object[] { new[] { 5 }, new[] { 6 }, Array.Empty<int>() },

            // Отрицательные числа
            new object[] { new[] { -5, -3, -1, 0 }, new[] { -4, -3, 0, 2 }, new[] { -3, 0 } },

            // Пересечение только в конце
            new object[] { new[] { 1, 2, 3, 10 }, new[] { 4, 5, 10 }, new[] { 10 } },

            // Пересечение только в начале
            new object[] { new[] { 1, 2, 3 }, new[] { 1, 4, 5 }, new[] { 1 } },

            // Один массив полностью содержится в другом
            new object[] { new[] { 1, 2, 2, 3, 4 }, new[] { 2, 2, 3 }, new[] { 2, 2, 3 } },

            // Разная длина массивов
            new object[] { new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 2, 6 }, new[] { 2, 6 } },

            // Большая серия дублей, но в одном массиве меньше
            new object[] { new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } },

            // Совпадают только повторяющиеся хвосты
            new object[] { new[] { 1, 2, 9, 9, 9 }, new[] { 3, 9, 9 }, new[] { 9, 9 } },

            // Минимальные/максимальные int
            new object[]
            {
                new[] { int.MinValue, -1, 0, int.MaxValue },
                new[] { int.MinValue, 1, int.MaxValue },
                new[] { int.MinValue, int.MaxValue }
            }
        };

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Should_Work_CorrectlyIf(int[] arr1, int[] arr2, int[] expected)
    {
        var solution = new TwoArrayCross();
        var result = solution.SolveIf(arr1, arr2);

        Assert.Equal(expected, result);
    }
    
    [Theory]
    [MemberData(nameof(TestCases))]
    public void Should_Work_CorrectlyMin(int[] arr1, int[] arr2, int[] expected)
    {
        var solution = new TwoArrayCross();
        var result = solution.SolveMin(arr1, arr2);

        Assert.Equal(expected, result);
    }
}
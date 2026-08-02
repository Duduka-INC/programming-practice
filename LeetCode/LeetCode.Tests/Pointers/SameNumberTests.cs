using LeetCode.Pointers;

namespace Tests.Pointers;

public class SameNumberTests
{
    public static IEnumerable<object[]> TestCases() =>
        new List<object[]>
        {
            // Базовый кейс из условия
            new object[]
            {
                new[] { 1, 2, 4, 5 },
                new[] { 3, 3, 4 },
                new[] { 2, 3, 4, 5, 6 },
                4
            },

            // Общее число в самом начале
            new object[]
            {
                new[] { 1, 2, 3 },
                new[] { 1, 4, 5 },
                new[] { 1, 6, 7 },
                1
            },

            // Общее число в самом конце
            new object[]
            {
                new[] { 1, 2, 10 },
                new[] { 3, 4, 10 },
                new[] { 5, 6, 10 },
                10
            },

            // Несколько общих элементов, должен вернуться первый найденный
            new object[]
            {
                new[] { 1, 2, 4, 6, 8 },
                new[] { 0, 2, 4, 9 },
                new[] { 2, 4, 10 },
                2
            },

            // Общего элемента нет
            new object[]
            {
                new[] { 1, 2, 3 },
                new[] { 4, 5, 6 },
                new[] { 7, 8, 9 },
                -1
            },

            // Один массив пустой
            new object[]
            {
                Array.Empty<int>(),
                new[] { 1, 2, 3 },
                new[] { 1, 2, 3 },
                -1
            },

            // Два массива пустые
            new object[]
            {
                Array.Empty<int>(),
                Array.Empty<int>(),
                new[] { 1, 2, 3 },
                -1
            },

            // Все массивы пустые
            new object[]
            {
                Array.Empty<int>(),
                Array.Empty<int>(),
                Array.Empty<int>(),
                -1
            },

            // Все из одного элемента, совпадают
            new object[]
            {
                new[] { 5 },
                new[] { 5 },
                new[] { 5 },
                5
            },

            // Все из одного элемента, не совпадают
            new object[]
            {
                new[] { 1 },
                new[] { 2 },
                new[] { 3 },
                -1
            },

            // Дубликаты, общий элемент есть
            new object[]
            {
                new[] { 1, 2, 2, 2, 5 },
                new[] { 2, 2, 3 },
                new[] { 0, 2, 4 },
                2
            },

            // Дубликаты, но общего элемента нет
            new object[]
            {
                new[] { 1, 1, 1 },
                new[] { 2, 2, 2 },
                new[] { 3, 3, 3 },
                -1
            },

            // Отрицательные числа
            new object[]
            {
                new[] { -10, -5, -1, 0 },
                new[] { -7, -5, 2 },
                new[] { -9, -5, 10 },
                -5
            },

            // Отрицательные и положительные, общего нет
            new object[]
            {
                new[] { -3, -2, -1 },
                new[] { 0, 1, 2 },
                new[] { -1, 3, 4 },
                -1
            },

            // Один массив сильно короче других
            new object[]
            {
                new[] { 4 },
                new[] { 1, 2, 3, 4, 5, 6 },
                new[] { 0, 4, 7, 8, 9 },
                4
            },

            // Общий элемент встречается после длинного префикса
            new object[]
            {
                new[] { 1, 2, 3, 4, 100 },
                new[] { 5, 6, 7, 100 },
                new[] { 8, 9, 10, 11, 100 },
                100
            },

            // Один и тот же минимум в двух массивах — важно для логики сдвига нескольких указателей
            new object[]
            {
                new[] { 2, 4, 6 },
                new[] { 2, 5, 7 },
                new[] { 3, 4, 5, 6 },
                -1
            },

            // Все элементы одинаковые
            new object[]
            {
                new[] { 2, 2, 2 },
                new[] { 2, 2 },
                new[] { 2, 2, 2, 2 },
                2
            },

            // Пересечение по int.MinValue
            new object[]
            {
                new[] { int.MinValue, -1, 0 },
                new[] { int.MinValue, 5, 6 },
                new[] { int.MinValue, 7, 8 },
                int.MinValue
            },

            // Пересечение по int.MaxValue
            new object[]
            {
                new[] { 1, 2, int.MaxValue },
                new[] { 3, int.MaxValue },
                new[] { 0, 5, int.MaxValue },
                int.MaxValue
            },

            // Массивы разной длины, общий есть, но неочевидный
            new object[]
            {
                new[] { 1, 3, 5, 7, 9, 11, 13 },
                new[] { 0, 2, 4, 6, 8, 9 },
                new[] { 9 },
                9
            },

            // Общий элемент только один, среди повторов
            new object[]
            {
                new[] { 1, 1, 1, 4, 4, 4 },
                new[] { 2, 3, 4, 4, 4 },
                new[] { 0, 4, 5, 6 },
                4
            }
        };

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Should_Work_Correctly(int[] arr1, int[] arr2, int[] arr3, int expected)
    {
        var solution = new SameNumber();
        var result = solution.Solve(arr1, arr2, arr3);
        
        Assert.Equal(expected, result);
    }
}
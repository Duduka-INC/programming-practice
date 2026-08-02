using LeetCode.SlidingWindows;

namespace Tests.SlidingWindows;

public class LongestSubstringWithoutRepeatingCharactersTests
{
    public static IEnumerable<object[]> TestCases =>
        new List<object[]>
        {
            // Пустая строка
            new object[] { "", 0 },

            // Один символ
            new object[] { "a", 1 },

            // Все символы разные
            new object[] { "abcde", 5 },

            // Все символы одинаковые
            new object[] { "bbbbb", 1 },

            // Пример из условия
            new object[] { "abcabcbb", 3 },

            // Пример из условия
            new object[] { "pwwkew", 3 },

            // Повтор сразу
            new object[] { "abba", 2 },

            // Повтор в конце
            new object[] { "abcddef", 4 },

            // Повтор в начале после длинного окна
            new object[] { "abcda", 4 },

            // Окно должно правильно сдвигаться, а не сбрасываться
            new object[] { "dvdf", 3 },

            // Частый tricky-case
            new object[] { "tmmzuxt", 5 },

            // Повторы через один
            new object[] { "aab", 2 },

            // Повтор с откатом окна
            new object[] { "abcaefgh", 7 },

            // Несколько одинаковых блоков
            new object[] { "abcabcabc", 3 },

            // Символы и цифры
            new object[] { "a1b2c3a4", 7 },

            // Пробелы тоже символы
            new object[] { "a b c a", 3 },

            // Только пробелы
            new object[] { "     ", 1 },

            // Символы пунктуации
            new object[] { "!@#$%^&*()", 10 },

            // Повтор спецсимвола
            new object[] { "!@#!", 3 },

            // Чувствительность к регистру
            new object[] { "aA", 2 },

            // Длинное уникальное окно в середине
            new object[] { "zzabcdefghiz", 10 },

            // Повтор в середине, который не должен ломать левую границу назад
            new object[] { "abbaefg", 5 },

            // Unicode BMP-символы (char в C# это поддержит)
            new object[] { "приветмир", 7 },

            // Повтор кириллицы
            new object[] { "абвгда", 5 },

            // Один и тот же символ после длинного окна
            new object[] { "abcdefghijklmnopa", 16 },
        };

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Should_Work_Correctly(string input, int expected)
    {
        var solution = new LongestSubstringWithoutRepeatingCharacters();
        var result = solution.Solve(input);
        
        Assert.Equal(expected, result);
    }
}
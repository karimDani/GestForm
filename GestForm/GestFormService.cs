namespace GestForm;

/// <summary>
/// Gest Form Service
/// </summary>
public static class GestFormService
{
    /// <summary>
    /// Generate  Random List
    /// </summary>
    /// <returns>IEnumerable<int></returns>
    public static IEnumerable<int> GenerateRandomList()
    {
        List<int> numbers = new();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(new Random().Next(-1000, 1000));
        }
        return numbers;
    }


    /// <summary>
    /// Writes the label.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <returns>string</returns>
    public static string WriteLabel(int number)
    {
        string result = string.Empty;

        if (number % 3 == 0)
        {
            result += Constant.GestLabel;
        }

        if (number % 5 == 0)
        {
            result += Constant.FormLabel;
        }

        return string.IsNullOrWhiteSpace(result) ? number.ToString() : result;
    }

    /// <summary>
    /// Runs this instance.
    /// </summary>
    public static void Run()
    {
        IEnumerable<int> numbers = GenerateRandomList();
        if (numbers is not null && numbers.Any())
        {
            numbers.ToList().ForEach(number => Console.WriteLine(WriteLabel(number)));
        }
    }
}

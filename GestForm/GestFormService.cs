namespace GestForm;

/// <summary>
/// Gest Form Service
/// </summary>
public static class GestFormService
{
    /// <summary>
    /// Generates the random number.
    /// </summary>
    /// <returns>IEnumerable<int></returns>
    public static IEnumerable<int> GenerateRandomNumber()
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
    public static string WriteLabel(int number) => (number % 3) switch
    {
        0 => number % 5 == 0 ? string.Concat(Constant.GestLabel, "\n", Constant.GesteFormLabel) : Constant.GestLabel,
        _ => number % 5 == 0 ? Constant.FormLabel : number.ToString(),
    };

    /// <summary>
    /// Runs this instance.
    /// </summary>
    public static void Run()
    {
        IEnumerable<int> numbers = GenerateRandomNumber();
        if (numbers is not null && numbers.Any())
        {
            numbers.ToList().ForEach(number => Console.WriteLine(WriteLabel(number)));
        }
    }
}

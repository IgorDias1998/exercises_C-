/* 
Exemplo de entrada:
input =  [[18, 20], [45, 2], [61, 12], [37, 6], [21, 21], [78, 9]]
output = ["Open", "Open", "Senior", "Open", "Open", "Senior"]
*/

public static IEnumerable<string> OpenOrSenior(int[][] data)
{

    List<string> result = new List<string>();

    foreach (int[] open in data)
    {
        int age = open[0];

        int points = open[1];

        if (age >= 55 && points > 7)
        {
            result.Add("Senior");
        }
        else
        {
            result.Add("Open");
        }
    }
    return result.ToArray();
}

//Casos para teste

public void SampleTest()
{
    Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
    Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
    Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
}

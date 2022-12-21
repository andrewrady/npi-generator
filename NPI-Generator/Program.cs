using NPI_Generator;
const string initialQuestion = "How many NPI do you want?";

Console.WriteLine(initialQuestion);
var amount = Console.ReadLine();
var result = Helpers.ValidateInput(amount);

if (result.IsValid)
{
    var npiList = Helpers.GenerateNpi(result.ParsedAmount);
    Console.WriteLine(string.Join("\n", npiList));
    return;
}
Console.WriteLine(result.Message);
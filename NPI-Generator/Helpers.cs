namespace NPI_Generator;

public abstract class Helpers
{
    public static InputValidation ValidateInput(string? input)
    {
        if (string.IsNullOrEmpty(input)) return new InputValidation { IsValid = false };
        var isValid = int.TryParse(input, out int result);
        if (isValid == false)
        {
            return new InputValidation
            {
                IsValid = isValid,
                Message = $"{input} is not a valid input",
                ParsedAmount = result
            };
        }

        return new InputValidation
        {
            IsValid = isValid,
            Message = "Valid",
            ParsedAmount = result
        };
    }

    public static IList<string> GenerateNpi(int amount)
    {
        IList<string> npiList = new List<string>();
        for(var i = 0; i < amount; i++)
        {
            var randomNpi = GenerateNpi();
            npiList.Add(randomNpi);
        }

        return npiList;
    }
    
    private static string GenerateNpi()
    {
        var ran = new Random(10);
        return ran.Next().ToString();
    }

    public class InputValidation
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public int ParsedAmount { get; set; }
    }
}
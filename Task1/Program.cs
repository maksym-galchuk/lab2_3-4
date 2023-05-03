using Strings;

while (true) {
    Console.WriteLine("Enter string or 'exit' to exit:");
    string? str = Console.ReadLine();
    if (str == null || str == "exit") break;
    
    StringsBase upper = new UppercaseLetters(str);
    StringsBase lower = new LowercaseLetters(str);
    
    Console.WriteLine("Before:");
    Console.WriteLine($"    Length of capital string: {upper.Length()}; String: {upper.Str}");
    Console.WriteLine($"    Length of lower string: {lower.Length()}; String: {lower.Str}\n");
    
    string editedUpper = upper.Insert("/");
    string editedLower = lower.Insert("\\");
    
    Console.WriteLine("After:");
    Console.WriteLine($"    Length of capital string: {upper.Length()}; String: {editedUpper}");
    Console.WriteLine($"    Length of lower string: {lower.Length()}; String: {editedLower}\n\n");
}




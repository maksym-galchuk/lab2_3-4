using Task2; 

while (true) {
    Console.WriteLine("What type of string do you want to create?");
    Console.WriteLine("1. Digital string");
    Console.WriteLine("2. Letters string");
    Console.WriteLine("3. Exit");
    Console.Write("Your choice: ");
    char choice = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (choice) {
        case '1':
            IDeletingSymbol deletingDigitalString;
            while (true) {
                try {
                    Console.Write("Enter the string: ");
                    string digitalString = Console.ReadLine();
                    deletingDigitalString = new DigitalString(digitalString);
                    Console.WriteLine($"Your string is {deletingDigitalString}, length is {deletingDigitalString.StringLength}");
                    break;
                } catch (ArgumentException e) {
                    Console.WriteLine(e.Message);
                }
            }

            while (true) {
                Console.Write("Enter the symbol to delete or press Enter to exit: ");
                char symbol = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();
                if (symbol == '\r') break;
                deletingDigitalString.DeleteSymbol(symbol);
                Console.WriteLine($"Your string is {deletingDigitalString}, length is {deletingDigitalString.StringLength}");
            }
            break;
        case '2':
            IDeletingSymbol deletingLettersString;
            while (true) {
                try {
                    Console.Write("Enter the string: ");
                    string lettersString = Console.ReadLine();
                    deletingLettersString = new LettersString(lettersString);
                    Console.WriteLine($"Your string is {deletingLettersString}, length is {deletingLettersString.StringLength}");
                    break;
                } catch (ArgumentException e) {
                    Console.WriteLine(e.Message);
                }
            }

            while (true) {
                Console.Write("Enter the symbol to delete or press Enter to exit: ");
                char symbol = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();
                if (symbol == '\r') break;
                deletingLettersString.DeleteSymbol(symbol);
                Console.WriteLine($"Your string is {deletingLettersString}, length is {deletingLettersString.StringLength}");
            }
            break;
        case '3':
            return;
        default:
            Console.WriteLine("Invalid option\n");
            break;
    }
}

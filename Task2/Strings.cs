namespace Task2; 

public class DigitalString : IDeletingSymbol {
    private string value;
    
    public DigitalString(string value) {
        if (value.Any(c => !char.IsDigit(c)))
            throw new ArgumentException("The string contains non-digit symbols");
        this.value = value;
    }
    
    public int StringLength {
        get => value.Length; 
    }
    
    public void DeleteSymbol(char symbol) {
        value = value.Replace(symbol.ToString(), "");
    }
    
    public override string ToString() => value;
}

public class LettersString : IDeletingSymbol {
    private string value;
    
    public LettersString(string value) {
        if (value.Any(c => !char.IsLetter(c)))
            throw new ArgumentException("The string contains non-letter symbols");
        this.value = value;
    }
    
    public int StringLength {
        get => value.Length;
    }
    
    public void DeleteSymbol(char symbol) {
        value = value.Replace(symbol.ToString(), "");
    }
    
    public override string ToString() => value;
}
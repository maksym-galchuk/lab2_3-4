namespace Task2; 

public interface IDeletingSymbol {
    int StringLength { get; }
    void DeleteSymbol(char symbol);
}
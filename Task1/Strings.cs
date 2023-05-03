namespace Strings; 

public class StringsBase {
    public virtual string Str {
        get;
        set;
    }
    
    public virtual int Length() => 0;
    public virtual string Insert(string s) => "";
}

public class UppercaseLetters : StringsBase {
    
    private string _str;
    
    public UppercaseLetters(string str) {
        Str = str;
    }
    
    public override string Str {
        get => _str;
        set => _str = value.ToUpper();
    }

    public override int Length() => _str.Length;

    public override string Insert(string s) {
        string result = _str;
        for (int i = 1; i < result.Length; i += 2)
            result = result.Insert(i, s);
        
        return result;
    }
}

public class LowercaseLetters : StringsBase {
    private string _str;

    public LowercaseLetters(string str) {
        Str = str;
    }
    
    public override string Str {
        get => _str;
        set => _str = value.ToLower();
    }
    
    public override int Length() => _str.Length;

    public override string Insert(string s) {
        string result = _str;
        for (int i = 1; i < result.Length; i += 2)
            result = result.Insert(i, s);
        
        return result;
    }
}


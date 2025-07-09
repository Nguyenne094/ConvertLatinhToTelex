class HelloWorld {
  static void Main()
  {
    Dictionary<string, string> telexRule = new()
    {
      { "aw", "ă" },
      { "aa", "â" },
      { "dd", "đ" },
      { "ee", "ê" },
      { "oo", "ô" },
      { "ow", "ơ" },
      { "w", "ư" }
    };
    List<string> matchedTelexKeys = new();
    Console.Write("Enter character string: ");
    string? input = Console.ReadLine();
    var lowerInput = input.ToLower();
    int i = 0;
    while (i < lowerInput.Length)
    {
      bool matched = false;
      
      if (i + 1 < lowerInput.Length)
      {
        string twoChar = lowerInput.Substring(i, 2);
        if (telexRule.ContainsKey(twoChar))
        {
          matchedTelexKeys.Add(twoChar);
          i += 2;
          matched = true;
        }
      }

      if (!matched)
      {
        string oneChar = lowerInput.Substring(i, 1);
        if (telexRule.ContainsKey(oneChar))
        {
          matchedTelexKeys.Add(oneChar);
        }
      }
      i += 1;
    }

    Console.WriteLine(matchedTelexKeys.Count + ": (" + string.Join(", ", matchedTelexKeys) + ")");
  }
}
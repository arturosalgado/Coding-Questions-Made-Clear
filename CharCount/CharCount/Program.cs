using System.Text;
Console.WriteLine("Count Chars");


Console.WriteLine(countChars("aaa"));



 
static string countChars(string s)
{
    string output = "";
    Dictionary<char, int> dict = new Dictionary<char, int>();
    if (s.Length == 0 || s == null) return "";


    foreach (char c in s)
    {

        if (dict.ContainsKey(c))
        {
            dict[c] = dict[c] + 1;
        }
        else
            dict.Add(c, 1);

    }
    // at this point the dictionary is ready.
    // We just need to format the output
    
    StringBuilder sb = new StringBuilder("");
    foreach (var pair in dict)
    {
        var key = pair.Key;
        var value = pair.Value;
        //Console.WriteLine("{0}{1}",key,value);
        sb.Append(key + "" + value);
    }



    output = sb.ToString();

    return output;
}



void GetShortArray (string[] values, int limit)
{
    for(int i = 0; i < values.Length; i++)
    {
        char[] characters = values[i].ToCharArray();
        if(characters.Length <= limit)
        {
             Console.Write("'" + values[i] + "'");
             if(i < values.Length - 2)
             {
                 Console.Write("," + " ");
             } 
        }
    }
}
string[] CurrentCharacters = {"123", "object", "New1", "@12", "examples", "0-0", "preview%", "no", ")", "master32"};
Console.WriteLine("Новый массив из строк с длиной символов <= 3:");
GetShortArray (CurrentCharacters, 3);
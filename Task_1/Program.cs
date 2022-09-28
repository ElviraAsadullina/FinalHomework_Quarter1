void GetShortArray (string[] StartValues, string[] EndValues, int limit)
{
    for(int i = 0, j = 0; i < StartValues.Length && j < EndValues.Length; i++, j++)
    {
        char[] characters = StartValues[i].ToCharArray();
        if(characters.Length <= limit)
        {
            EndValues[j] = StartValues[i];
        }
    }
}
void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == null) continue;
        Console.Write("'" + array[i] + "'");
        if(i < array.Length - 2)
        {
            Console.Write(", ");
        }
    }
}
string[] CurrentCharacters = {"123", "object", "New1", "@12", "examples", "0-0", "preview%", "no", ")", "master32"};
string[] NewCharacters = new string[CurrentCharacters.Length];
Console.WriteLine("Новый массив из строк с длиной символов <= 3:");
GetShortArray (CurrentCharacters, NewCharacters, 3);
PrintArray(NewCharacters);
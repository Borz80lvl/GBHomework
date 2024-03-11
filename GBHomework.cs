string[] array = new string[5] {"lan", "van", "ban", "pampam", "dadam"};
string[] words = new string[3];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length == 3 || array[i].Length < 3)
    {
        words[i] = array[i];
    }
}
Console.Write("[ \"" + String.Join("\",\"", array) + "\" ] -> ");
Console.Write("[ \"" + String.Join("\",\"", words) + "\" ]");



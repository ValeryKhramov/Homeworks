// Напишите программу. которая проверяет, можно ли из первой строки собрать вторую.
//Tom Marvolo Riddle => I am Lord Voldemort
using static System.Console;
Clear();

Write("Enter first text: ");
string textOne = ReadLine()!.ToLower().Replace(" ", "");
char[] firstTextToArray = textOne.ToCharArray();

Write("Enter second text: ");
string textTwo = ReadLine()!.ToLower().Replace(" ", "");
char[] secondTextToArray = textTwo.ToCharArray();
WriteLine($"{ComparisonString(firstTextToArray, secondTextToArray)}");

bool ComparisonString(char[] firstText, char[] secondText)
{
    Array.Sort(firstText);
    Array.Sort(secondText);
    for (int i = 0; i < firstText.Length; i++)
    {
        
       if(firstText[i] != secondText[i]) return false;
       
    }
    return true;
}

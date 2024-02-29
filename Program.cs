bool IsPalindrome(int number)
{
    string numberStr = number.ToString();
    int length = numberStr.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (numberStr[i] != numberStr[length - i - 1])
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine(IsPalindrome(838));
Console.WriteLine(IsPalindrome(511115));
Console.WriteLine(IsPalindrome(443344));
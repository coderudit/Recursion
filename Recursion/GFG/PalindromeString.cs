namespace Recursion.GFG
{
    class PalindromeString
    {
        bool IsPalindrome(string str, int low, int high)
        {
            if (low >= high)
                return true;
            if (str[low] != str[high])
                return false;
            return IsPalindrome(str, low + 1, high - 1);
        }
    }
}

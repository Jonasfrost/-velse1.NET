using System;

internal class Class
{
    public static int Count(string Input, string Text)
    {
        if (string.IsNullOrEmpty(Input) || string.IsNullOrEmpty(Text))
            return 0;

        int count = 0;
        Text = Text.ToLower();
        Input = Input.ToLower();

        for (int i = 0; i + Input.Length <= Text.Length; i++)
        {
            int j = 0;
            while (j < Input.Length && Text[i + j] == Input[j])
            {
                j++;
            }
            if (j == Input.Length)
            {
                count++;
            }
        }

        return count;
    }

    public static bool? EvaluateCount(int count)
    {
        if (count == 0) return null;
        if (count >= 1 && count < 10) return false;
        return true;
    }
}
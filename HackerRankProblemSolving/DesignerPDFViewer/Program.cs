using System.Collections.Generic;

namespace DesignerPDFViewer;
class Program
{
    /*
     * Complete the 'designerPdfViewer' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h
     *  2. STRING word
     */

    public static int designerPdfViewer(List<int> h, string word)
    {
        const int WIDE = 1;
        int maxHeightOfWord = h[word.IndexOf(word[0])];

        List<string> letters = new List<string>();
        for (int i = 65; i < (65 + 26); i++)
        {
            letters.Add(((char)i).ToString().ToLower());
        }

        for (int i = 0; i < word.Length; i++)
        {
            int index = letters.FindIndex(l => l == word[i].ToString());
            if (maxHeightOfWord < h[index])
            {
                maxHeightOfWord = h[index];
            }
        }

        return maxHeightOfWord * WIDE * word.Length;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


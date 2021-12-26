using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Helper
{
    public class StringHelper
    {
        public static int GetCharecterLength(string words)
        {
            return words.Length;
        }

        public static string ShortenedStringWords(string words)
        {
            string lastWords = words;
            if (words.Length > 20)
            {
                //Shortened
                lastWords = words.Substring(0, 20);

            }
            return lastWords;
        }

        public static string ShortenedStringWords(string words,int maxCharecter = 20)
        {
            string lastWords = words;
            if (words.Length>maxCharecter)
            {
                //Shortened
                lastWords = words.Substring(0, maxCharecter);

            }
            return lastWords;
        }

        public static string ShortenedStringWordsAndThreeDot(string words, int maxCharecter = 20)
        {
            string lastWords = words;
            if (words.Length > maxCharecter)
            {
                //Shortened
                lastWords = words.Substring(0, maxCharecter);
                lastWords += "...";
            }
            return lastWords;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Spammeri.Spamming
{
    internal static class StringOperations
    {
        internal static string HexEscape(string str)
        {
            if (!str.Contains("\\x")) return str;

            int index, pos = 0;
            int strlen = str.Length;
            var builder = new StringBuilder(strlen);

            while (
                (index = str.IndexOf("\\x", pos)) != -1 &&
                index + 4 <= strlen
            )
            {
                builder.Append(str, pos, index - pos);
                builder.Append((char)Convert.ToInt32(str.Substring(index + 2, 2), 16));
                pos = index + 4;
            }

            builder.Append(str, pos, strlen - pos);
            return builder.ToString();
        }

        internal static List<char[]> GetWords(string str)
        {
            var list = new List<char[]>();
            int index, pos = 0;

            while ((index = str.IndexOf(' ', pos)) != -1)
            {
                list.Add(str.ToCharArray(pos, index - pos));
                pos = index + 1;
            }

            if (pos != str.Length)
            {
                list.Add(str.ToCharArray(pos, str.Length - pos));
            }

            return list;
        }

        internal static void ApplyMocking(char[] word, Random random)
        {
            for (var i = 0; i < word.Length; i++)
            {
                var chr = word[i];

                // Skip emojis
                if (chr == ':')
                {
                    var end = Array.IndexOf(word, ':', i + 1);
                    bool emoji = (
                        end != -1 &&
                        end - i <= 32 &&
                        Array.IndexOf(word, ' ', i, end - i) == -1 &&
                        Array.IndexOf(word, '\r', i, end - i) == -1 &&
                        Array.IndexOf(word, '\n', i, end - i) == -1 &&
                        Array.IndexOf(word, '\t', i, end - i) == -1
                    ); // Check that there is no space/lines after : and length does not exeed 32

                    if (emoji)
                    {
                        i = end; // Jump to end of emoji
                        continue;
                    }
                }

                word[i] = random.Next(0, 2) != 0
                    ? char.ToUpper(chr)
                    : char.ToLower(chr);
            }
        }
    }
}

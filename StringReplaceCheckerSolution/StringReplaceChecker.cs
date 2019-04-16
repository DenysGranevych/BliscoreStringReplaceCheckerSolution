using System;
using System.Linq;

namespace StringReplaceCheckerSolution
{
    public class StringReplaceChecker
    {
        public string Solution(string S, string T)
        {
            if (S == T)
            {
                return "EQUAL";
            }

            if (S.Length + 1 == T.Length)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i] == T[i])
                    {
                        continue;
                    }
                    else
                    {
                        var insertLetter = T[i];
                        if (String.Compare(S.Substring(i), T.Substring(i + 1)) == 0)
                        {
                            return $"INSERT {insertLetter}";
                        }
                    }
                }
            }

            if (S.Length == T.Length)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i] == T[i])
                    {
                        continue;
                    }

                    var replacedLetters = (s: S[i], t: T[i]);
                    if (S.Replace(replacedLetters.s, replacedLetters.t) == T)
                    {
                        return $"REPLACE {replacedLetters.s} {replacedLetters.t}";
                    }

                    var swapLetters = (s1: S[i], s2: S[i + 1]);
                    var swapedString = S.Substring(0, i) + swapLetters.s2 + swapLetters.s1 + new string(S.Skip(i + 2).ToArray());

                    if (swapedString == T)
                    {
                        return $"SWAP {swapLetters.s1} {swapLetters.s2}";
                    }
                }
            }

            return "IMPOSSIBLE";
        }
    }
}

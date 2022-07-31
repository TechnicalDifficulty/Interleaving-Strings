using System;

namespace Interleaving_Strings
{
    public class InterleavingStrings 
    {
        public bool CheckInterLeave(string A, string B,string C)
        {

            int M = A.Length, N = B.Length;
            bool[,] DP = new bool[M + 1, N + 1];

            for (int i = 0; i <= M; i++)
            {
                for (int j = 0; j <= N; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        DP[i, j] = true;
                    }
                    else if (i == 0)
                    {
                        if (B[j - 1] == C[j - 1])
                        {
                            DP[i, j] = DP[i, j - 1];
                        }
                    }

                    else if (j == 0)
                    {
                        if (A[i - 1] == C[i - 1])
                        {
                            DP[i, j] = DP[i - 1, j];
                        }
                    }

                    else if (A[i - 1] == C[i + j - 1] &&
                             B[j - 1] != C[i + j - 1])
                    {
                        DP[i, j] = DP[i - 1, j];
                    }

                    else if (A[i - 1] != C[i + j - 1] &&
                             B[j - 1] == C[i + j - 1])
                    {
                        DP[i, j] = DP[i, j - 1];
                    }

                    else if (A[i - 1] == C[i + j - 1] &&
                             B[j - 1] == C[i + j - 1])
                    {
                        DP[i, j] = (DP[i - 1, j] ||
                                 DP[i, j - 1]);
                    }
                }
            }
            return DP[M, N];
        }

        public bool IsPossibleInterleave(string a, string b, string c)
        {
            int M = a.Length, N = b.Length, L=c.Length;
            return (M + N) == L ? true : false;

        }

        public bool IsLengthConstraingsMatch(string a, string b, string c)
        {
            int M = a.Length, N = b.Length, L = c.Length;
            return (M>=0 && M<= 100) && (N >= 0 && N <= 100) && (L >= 0 && L <= 200) ? true : false;

        }

        public bool IsLowerCaseStrings(string a, string b, string c)
        {
            return a == a.ToLower() && b == b.ToLower() && c == c.ToLower() ? true : false;
        }

        static void Main(string[] args)
        {
            String A = "xxy", B = "xxz", C = "xxxxzy";
            InterleavingStrings interleavingObject = new InterleavingStrings();
           //"XXY", "XXZ", "XXZXXXY"
            //"XY", "WZ", "WZXY"
            //"XY", "X", "XXY"
            //"YX", "X", "XXY"
            if (interleavingObject.IsPossibleInterleave(A, B, C) && interleavingObject.IsLowerCaseStrings(A, B, C) && interleavingObject.IsLengthConstraingsMatch(A, B, C))
            {
                Console.WriteLine(interleavingObject.CheckInterLeave(A, B, C));
            }else
            {
                Console.WriteLine("C is not interleaving with A and B");
            }

        }
    }
}

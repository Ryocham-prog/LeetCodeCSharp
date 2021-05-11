using System;
using System.Collections.Generic;

namespace _0013_RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var rotoin = new Program();
            var s = "MCMXCIV";
            rotoin.RomanToInt(s);
        }

        public int RomanToInt(string s)
        {
            var wordCount = s.Length;
            if (wordCount < 1 || 15 < wordCount) return 0;

            var splitDataList = new List<string>();
            for (int i = 0; i < wordCount; i++)
            {
                var splitData = s.Substring(i, 1);
                if (splitData != "I" && splitData != "V" && splitData != "X" && splitData != "L" && splitData != "C" && splitData != "D" && splitData != "M")
                {
                    return 0;
                }
                splitDataList.Add(splitData);
            }

            var rtn = 0;
            for (int j = 0; j < wordCount; j++)
            {
                switch (splitDataList[j])
                {
                    case "V":
                        rtn += 5;
                        break;

                    case "L":
                        rtn += 50;
                        break;

                    case "D":
                        rtn += 500;
                        break;

                    case "M":
                        rtn += 1000;
                        break;

                    case "I":
                        if (j == wordCount - 1)
                        {
                            rtn += 1;
                        }
                        else
                        {
                            switch (splitDataList[j + 1])
                            {
                                case "V":
                                    rtn += 4;
                                    j++;
                                    break;
                                case "X":
                                    rtn += 9;
                                    j++;
                                    break;
                                default:
                                    rtn += 1;
                                    break;
                            }
                        }
                        break;

                    case "X":
                        if (j == wordCount - 1)
                        {
                            rtn += 10;
                        }
                        else
                        {
                            switch (splitDataList[j + 1])
                            {
                                case "L":
                                    rtn += 40;
                                    j++;
                                    break;
                                case "C":
                                    rtn += 90;
                                    j++;
                                    break;
                                default:
                                    rtn += 10;
                                    break;
                            }
                        }
                        break;

                    case "C":
                        if (j == wordCount - 1)
                        {
                            rtn += 100;
                        }
                        else
                        {
                            switch (splitDataList[j + 1])
                            {
                                case "D":
                                    rtn += 400;
                                    j++;
                                    break;
                                case "M":
                                    rtn += 900;
                                    j++;
                                    break;
                                default:
                                    rtn += 100;
                                    break;
                            }
                        }
                        break;
                }
            }
            if (rtn < 1 || 3999 < rtn) return 0;

            return rtn;
        }
    }
}

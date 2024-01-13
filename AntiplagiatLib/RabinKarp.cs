﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AntiplagiatLib
{
    /*
    internal class RabinKarp: TFIDF, IAntiplagiatMethod
    {
        private static Regex clear = new Regex(
                  "(?:[^а-яА-ЯёЁa-zA-Z0-9 ]|(?<=['\"])s)",
                  RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
        static public Dictionary<string, double> Calculate(string pathToFile, string pathToStandartFiles)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(pathToStandartFiles);
            if (!directoryInfo.Exists) { Console.WriteLine("Неверно указан путь!: " + pathToStandartFiles); throw new DirectoryNotFoundException(); }

            var similarityList = new Dictionary<string, double>();

            string[] dirs = Directory.GetFiles(@"C:\Users\maxgu\OneDrive\Документы\RefDocs", "*.txt", SearchOption.AllDirectories);

            const int SentencesCount = 10;

            Dictionary<string, double> SentencesTFIDF = new Dictionary<string, double>;
            Dictionary<string, HashArray> AddToRefDocs = new Dictionary<string, HashArray>();
            for (int i = 0; i < dirs.Length; ++i)
            {
                HashArray[,] SentencesHashArr = new HashArray[1, SentencesCount];

                SentencesTFIDF = TFIDF.FindKeySentences(dirs[i], SentencesCount);
                //Console.WriteLine(dirs[i]);
                int j = 0;
                foreach (var line in SentencesTFIDF[i].Keys)
                {
                    SentencesHashArr[i, j] = new HashArray(line);

                    Console.WriteLine($"{line}... -> {SentencesTFIDF[i][line]}");
                    j++;
                }
                Console.WriteLine();
            }

            var text = File.ReadAllText(pathToFile);
            clear.Replace(text, "").ToLower();

            HashArray s_h = new HashArray(text);
            for (int i = 0; i < SentencesHashArr.GetLength(0); ++i)
            {
                double plagiatPr = 0.0;
                for (int j = 0; j < SentencesCount; ++j)
                {
                    if (SentencesHashArr[i, j] is null) continue;

                    List<int> pos = SentencesHashArr[i, j].Positions(s_h);
                    //Console.WriteLine($"{SentencesHashArr[i, j].s}:");
                    if (pos.Count > 0) {
                        plagiatPr += 100/10;
                    }
                    similarityList.Add(SentencesHashArr[i])
                }
            }
        }
    }
    */
}

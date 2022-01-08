using Concordance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concordance.Services
{
    public class ConcordanceService
    {
        public IDictionary<string, List<int>> Generate(MyFile file)
        {            
            if (file?.Contents is null) throw new Exception
                    ($"File is invalid or empty");
            
            var concordance = new SortedDictionary<string, List<int>>();

            for (int line = 0; line < file.Contents.Count; line++)
            {
                int lineNumber = line + 1;
                var words = file.Contents[line].Trim().Split(' ');
                foreach (var word in words.Where(x => !string.IsNullOrWhiteSpace(x)))
                {
                    if (!concordance.ContainsKey(word))
                        concordance.Add(word, new List<int> { lineNumber });
                    else
                        concordance[word].Add(lineNumber);
                }
            }

            return concordance;
        }

        public string FormatConcordance(IDictionary<string, List<int>> concordance)
        {
            var sb = new StringBuilder();
            if (concordance is null) throw new Exception("Concordance is invalid or empty");

            foreach (var item in concordance)
            {
                int wordCount = item.Value.Count;
                var word = item.Key.PadRight(40);
                var lines = string.Join(",", item.Value.ToArray());
                string plural = wordCount > 1 ? "s" : "";

                sb.AppendLine($"{word} occurs { wordCount,-2} time{plural,-2} in line{plural,-1}: {lines}");
            }

            var res = sb.ToString();
            return sb.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Concordance.Models
{
    public class MyFile
    {
        public string Name { get; set; }
        public DirectoryInfo DefaultDirectory => new DirectoryInfo(@"./Data");
        public List<string> Contents { get; set; }

        public MyFile(string name)
        {
            Name = name;
            _ = ValidName();
            _ = ValidFileContents();
        }

        public bool ValidName()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException("File name cannot be empty");

            var file = new FileInfo(File.Exists(Path.Combine(DefaultDirectory.Name, Name)) ? Path.Combine(DefaultDirectory.Name, Name) :
                File.Exists(Name) ? Name : throw new FileNotFoundException($"File {Name} was not found")
                );

            Name = file.FullName;
            return true;
        }

        public bool ValidFileContents()
        {
            var contents = File.ReadAllLines(Name).ToList();
            var result = new List<string>();
            if (contents is null) throw new Exception("File contents cannot be empty");

            foreach (var line in contents)
            {
                // Remove special chars
                var cleanString = Regex.Replace(line, @"[^0-9a-zA-Z ]+", "").Trim().ToLower();

                if (!string.IsNullOrWhiteSpace(cleanString))
                    result.Add(cleanString);
            }

            Contents = result;
            return true;
        }

    }
}

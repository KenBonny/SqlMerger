using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SqlMerger
{
    public class SqlMerger
    {
        private readonly bool _removeUse;
        private readonly bool _addGo;

        /// <summary>
        /// Initializes the SqlMerger.
        /// </summary>
        /// <param name="removeUse">Removes the "USE[database]" from sql script. Default = true</param>
        /// <param name="addGo">Adds "GO" to the end of each sql script. Default = true</param>
        public SqlMerger(bool removeUse = true, bool addGo = true)
        {
            _removeUse = removeUse;
            _addGo = addGo;
        }

        public string Merge(DirectoryInfo sourceDirectory, string ignore = null)
        {
            if (!sourceDirectory.Exists)
                return string.Empty;

            var merged = new StringBuilder();
            var filesToMerge = sourceDirectory.GetFiles("*.sql")
                .OrderBy(f => f.Name).ToList();

            if (!string.IsNullOrWhiteSpace(ignore))
                filesToMerge = filesToMerge.Where(f => !f.Name.Contains(ignore)).ToList();

            foreach (var file in filesToMerge)
            {
                using (var reader = file.OpenText())
                {
                    var sql = reader.ReadToEnd();
                    merged.AppendLine(new string('-', file.Name.Count() + 3));
                    merged.AppendLine(string.Format("-- {0}", file.Name));
                    merged.Append(sql);
                }
                if (_addGo)
                    merged.AppendLine("GO");
                merged.AppendLine();
                merged.AppendLine();
            }
            var result = merged.ToString();

            if (_removeUse)
            {
                var regex = new Regex(@"USE \[\w+\]");
                result = regex.Replace(result, string.Empty);
            }

            return result;
        }
    }
}
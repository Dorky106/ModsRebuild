using System.IO;
using System.Text;

namespace PhentrixGames.NewColonyAPI.Helpers
{
    public static class Utilities
    {
        public static string MultiCombine(params string[] pathparts)
        {
            if (pathparts.Length >= 2)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string part in pathparts)
                {
                    stringBuilder.Append(part.TrimEnd('/', '\\')).Append(Path.DirectorySeparatorChar);
                }
                return stringBuilder.ToString().TrimEnd(Path.DirectorySeparatorChar).Replace("\\", "/");
            }
            return pathparts[0];
        }

        public static void MakeDirectoryIfNeeded(string path)
        {
            string[] parts = path.Split('/');
            string newPath = parts[0];
            for (int i = 1; i < parts.Length; i++)
            {
                newPath = MultiCombine(newPath, parts[i]);
                if (Path.GetExtension(newPath) == string.Empty)
                {
                    if (Directory.Exists(newPath) == false)
                    {
                        Directory.CreateDirectory(newPath);
                    }
                }
            }
        }

        /// <summary>
        /// Returns wether icon exists or not
        /// </summary>
        /// <param name="icon">Full path to the icon</param>
        /// <returns></returns>
        public static bool ValidateIcon(string icon)
        {
            return File.Exists(icon);
        }
    }
}
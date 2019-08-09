﻿using System.IO;
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
                if (Directory.Exists(newPath) == false)
                {
                    Directory.CreateDirectory(newPath);
                }
            }
        }
    }
}
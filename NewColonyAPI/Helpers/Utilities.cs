using Pipliz;
using Pipliz.JSON;
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

        public static JSONNode Vector3IntToNode(Vector3Int vector)
        {
            JSONNode ret = new JSONNode(NodeType.Object);
            ret.SetAs("x", vector.x);
            ret.SetAs("y", vector.y);
            ret.SetAs("z", vector.z);

            return ret;
        }

        public static Vector3Int NodeToVector3Int(JSONNode node)
        {
            int x = node["x"].GetAs<int>();
            int y = node["y"].GetAs<int>();
            int z = node["z"].GetAs<int>();

            Pipliz.Vector3Int ret = new Pipliz.Vector3Int(x, y, z);
            return ret;
        }
    }
}
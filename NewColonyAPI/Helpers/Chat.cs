using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Helpers
{
    public static class Chat
    {
        public enum ChatColour
        {
            black,
            blue,
            brown,
            cyan,
            darkblue,
            green,
            grey,
            lightblue,
            lime,
            magenta,
            maroon,
            navy,
            olive,
            orange,
            purple,
            red,
            silver,
            teal,
            white,
            yellow
        }
        public enum ChatStyle
        {
            normal,
            bold,
            italic,
            bolditalic
        }

        public static string BuildMessage(string message, ChatColour colour = ChatColour.white, ChatStyle chatStyle = ChatStyle.normal)
        {
            string colourPrefix = "<color=" + colour.ToString() + ">";
            string colourSuffix = "</color>";
            string stylePrefix, styleSuffix;
            switch (chatStyle)
            {
                case ChatStyle.bold:
                    stylePrefix = "<b>";
                    styleSuffix = "</b>";
                    break;
                case ChatStyle.bolditalic:
                    stylePrefix = "<b><i>";
                    styleSuffix = "</i></b>";
                    break;
                case ChatStyle.italic:
                    stylePrefix = "<i>";
                    styleSuffix = "</i>";
                    break;
                default:
                    stylePrefix = "";
                    styleSuffix = "";
                    break;
            }
            return colourPrefix + message + colourSuffix;
        }
    }
}

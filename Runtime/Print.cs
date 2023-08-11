using UnityEngine;
using System.Collections.Generic;
using System.Text.RegularExpressions;

#if UNITY_EDITOR
namespace ZxLog
{
    public static class Print
    {
        private static Dictionary<LogColor, string> colorMappings = new()
        {
            {LogColor.Black, "#0C0C0C"},
            {LogColor.Blue, "#0037DA"},
            {LogColor.Cyan, "#3A96DD"},
            {LogColor.Green, "#13A10E"},
            {LogColor.Purple, "#881798"},
            {LogColor.Red, "#C50F1F"},
            {LogColor.White, "#CCCCCC"},
            {LogColor.Yellow, "#C19C00"},
            {LogColor.BrightBlack, "#767676"},
            {LogColor.BrightBlue, "#3B78FF"},
            {LogColor.BrightCyan, "#61D6D6"},
            {LogColor.BrightGreen, "#16C60C"},
            {LogColor.BrightPurple, "#B4009E"},
            {LogColor.BrightRed, "#E74856"},
            {LogColor.BrightWhite, "#F2F2F2"},
            {LogColor.BrightYellow, "#F9F1A5"}
        };


        public static void BigWhiteLog(string message)
        {
            Debug.Log("<b><size=15>" + message + "</size></b>");
        }

        public static void Separator()
        {
            Debug.Log("<b> ================================ </b>");
        }

        public static void Separator(LogColor color = LogColor.White)
        {
            colorMappings.TryGetValue(color, out var c);
            Debug.Log(
                $"<b><color={c}> ================================ </color></b>");
        }

        public static void CustomLog(string message, LogColor color = LogColor.White)
        {
            colorMappings.TryGetValue(color, out var c);
            Debug.Log($"<color={c}>{message}</color>");
        }

        public static void CustomLog(string message, int fontSize, LogColor color = LogColor.White)
        {
            colorMappings.TryGetValue(color, out var c);
            Debug.Log($"<size={fontSize}><color={c}>{message}</color></size>");
        }

        public static void CustomLog(string message, string hexCode)
        {
            if (IsValidHexCode(hexCode))
            {
                Debug.Log($"<color={hexCode}>{message}</color>");
            }
            else
            {
                Debug.LogError($"Invalid hex code: {hexCode}");
            }
        }

        public static void CustomLog(string message, int fontSize, string hexCode)
        {
            if (IsValidHexCode(hexCode))
            {
                Debug.Log($"<b><size={fontSize}><color={hexCode}>{message}</color></size></b>");
            }
            else
            {
                Debug.LogError($"Invalid hex code: {hexCode}");
            }
        }

        private static bool IsValidHexCode(string hexCode)
        {
            return Regex.IsMatch(hexCode, "^#(?:[0-9a-fA-F]{3}){1,2}$");
        }
    }

    public enum LogColor
    {
        Black,
        Blue,
        Cyan,
        Green,
        Purple,
        Red,
        White,
        Yellow,
        BrightBlack,
        BrightBlue,
        BrightCyan,
        BrightGreen,
        BrightPurple,
        BrightRed,
        BrightWhite,
        BrightYellow
    }
}
#endif
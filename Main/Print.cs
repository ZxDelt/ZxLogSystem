using Unity.VisualScripting;
using UnityEngine;

#if UNITY_EDITOR
namespace ZxLog
{
    public static class Print
    {
        public static void RedLog(string message)
        {
            Debug.Log("<b><color=Red>" + message + "</color></b>");
        }

        public static void YellowLog(string message)
        {
            Debug.Log("<color=Yellow>" + message + "</color>");
        }

        public static void BigWhiteLog(string message)
        {
            Debug.Log("<b><size=15>" + message + "</size></b>");
        }

        public static void Seprator()
        {
            Debug.Log($"<b> ================================ </b>");
        }
        
        public static void Seprator(Color color)
        {
            var c = new Color(color.r, color.g, color.b, 1);
            Debug.Log($"<b><color=#{c.ToHexString()}> ================================ </color></b>");
        }

        public static void CustomLog(string message, Color color)
        {
            var c = new Color(color.r, color.g, color.b, 1);
            Debug.Log($"<color=#{c.ToHexString()}>" + message + "</color>");
        }

        public static void CustomLog(string message, (float r, float g, float b) color)
        {
            var c = new Color(color.r, color.g, color.b, 1);
            Debug.Log($"<color=#{c.ToHexString()}>" + message + "</color>");
        }

        public static void CustomLog(string message, int size, Color color)
        {
            var c = new Color(color.r, color.g, color.b, 1);
            Debug.Log($"<b><size={size}><color=#{c.ToHexString()}>" + message + "</color></size></b>");
        }

        public static void CustomLog(string message, string hexCode)
        {
            if (UnityEngine.ColorUtility.TryParseHtmlString(hexCode, out var color))
            {
                var c = new Color(color.r, color.g, color.b, 1);
                Debug.Log($"<color=#{c.ToHexString()}>" + message + "</color>");
            }
            else
            {
                Debug.LogError("<b><size=10><color = #F5B041>Invalid color code</color></size></b>");
            }
        }
        
        public static void CustomLog(string message, int size, string hexCode)
        {
            if (UnityEngine.ColorUtility.TryParseHtmlString(hexCode, out var color))
            {
                var c = new Color(color.r, color.g, color.b, 1);
                Debug.Log($"<b><size={size}><color=#{c.ToHexString()}>" + message + "</color></size></b>");
            }
            else
            {
                Debug.LogError("<b><size=10><color = #F5B041>Invalid color code</color></size></b>");
            }
        }
    }
}
#endif
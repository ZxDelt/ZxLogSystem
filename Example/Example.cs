using UnityEngine;
using ZxLog;

public class Example : MonoBehaviour
{
    [ContextMenu("Use Logs")]
    private void UseLogs()
    {
        Print.Seprator();
        Print.BigWhiteLog("Unity Custom Debug Demo");
        Print.RedLog("red log");
        Print.YellowLog("yellow log");
        Print.CustomLog("message 1", Color.blue);
        Print.CustomLog("message 2",(0.1f,0.2f,0.3f));
        Print.CustomLog("message 3", 10, Color.black);
        Print.CustomLog("message 4","#16A085");
        Print.CustomLog("message 5",25,"#16A085");
        Print.Seprator(Color.green);
    }
}
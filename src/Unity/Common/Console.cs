namespace KasenCS
{
    using UnityEngine;

    /// <summary>
    /// __
    /// </summary>
    public partial class __
    {
        public static void Log(string message)
        {
            Debug.Log(message);
        }

        public static void LogError(string message)
        {
            Debug.LogError(StyledText(message).Red.Value);
        }

        public static void LogInfo(string message)
        {
            Debug.Log(StyledText(message).Blue.Value);
        }

        public static void LogWarning(string message)
        {
            Debug.LogWarning(StyledText(message).Yellow.Value);
        }
    }
}

namespace KasenCS
{
    using UnityEngine;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public sealed class LabelAttribute : PropertyAttribute
        {
            public LabelAttribute(string text)
            {
                this.Text = text;
            }

            public string Text { get; private set; }
        }
    }
}

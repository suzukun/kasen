namespace KasenCS
{
#if UNITY_EDITOR
    using UnityEditor;
    using UnityEngine;

    /// <summary>
    /// __
    /// </summary>
    [CustomPropertyDrawer(typeof(__.LabelAttribute))]
    public sealed class LabelEditor : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            __.LabelAttribute labelAttribute = this.attribute as __.LabelAttribute;

            EditorGUI.PropertyField(position, property, new GUIContent(labelAttribute.Text), true);
        }
    }
#endif
}

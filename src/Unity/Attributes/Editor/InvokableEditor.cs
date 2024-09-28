namespace KasenCS
{
#if UNITY_EDITOR
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using UnityEditor;
    using UnityEngine;
    using Object = UnityEngine.Object;

    /// <summary>
    /// __
    /// </summary>
    [CustomEditor(typeof(Object), true)]
    public class InvokableEditor : Editor
    {
        private List<(__.InvokableAttribute, MethodInfo)> invokableMethods = new();

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (this.invokableMethods.Count == 0)
            {
                return;
            }

            GUILayout.Space(8);
            GUILayout.Label("=== Methods ===", EditorStyles.centeredGreyMiniLabel);
            GUILayout.Space(8);

            this.invokableMethods.ForEach((item) =>
            {
                (__.InvokableAttribute attribute, MethodInfo method) = item;
                bool isAllowPlay = attribute.Mode is __.InvokableMode.All or __.InvokableMode.PlayOnly;
                bool isAllowEdit = attribute.Mode is __.InvokableMode.All or __.InvokableMode.EditOnly;
                bool hasParameters = attribute.Parameters.Length > 0;
                string label = method.Name;

                if (hasParameters)
                {
                    label += $"({string.Join(", ", attribute.Parameters)})";
                }

                GUI.enabled = Application.isPlaying ? isAllowPlay : isAllowEdit;

                if (GUILayout.Button(label))
                {
                    method.Invoke(this.target, attribute.Parameters);
                }

                GUI.enabled = true;
            });
        }

        private static void EachByMethods(Object target, Action<__.InvokableAttribute, MethodInfo> action)
        {
            Type type = target.GetType();

            foreach (MethodInfo method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                IEnumerable<__.InvokableAttribute> attributes = method.GetCustomAttributes<__.InvokableAttribute>();

                foreach (__.InvokableAttribute attribute in attributes)
                {
                    action(attribute, method);
                }
            }
        }

        private void OnDestroy()
        {
            this.invokableMethods.Clear();
        }

        private void OnDisable()
        {
            this.invokableMethods.Clear();
        }

        private void OnEnable()
        {
            this.invokableMethods.Clear();

            EachByMethods(this.target, (attribute, method) =>
            {
                this.invokableMethods.Add((attribute, method));
            });
        }
    }
#endif
}

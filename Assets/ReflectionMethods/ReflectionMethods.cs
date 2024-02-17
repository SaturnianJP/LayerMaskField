#if UNITY_EDITOR
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public class ReflectionMethods
{
    public static void LayerMaskField(Rect position, SerializedProperty property, GUIContent label)
    {
        var methods = typeof(EditorGUI).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
        var _LayerMaskField = methods.FirstOrDefault(c =>
        {
            return
                c.Name == "LayerMaskField" &&
                c.GetParameters()[0].ParameterType == typeof(Rect) &&
                c.GetParameters()[1].ParameterType == typeof(SerializedProperty) &&
                c.GetParameters()[2].ParameterType == typeof(GUIContent);
        });

        //ここでエラーが出る場合はUnity標準のライブラリが変更された可能性？
        if (_LayerMaskField == null)
            throw new System.NullReferenceException("LayerMaskField was not found.");

        _LayerMaskField.Invoke(null, new object[] { position, property, label });
    }

    public static LayerMask LayerMaskField(Rect position, LayerMask layers, GUIContent label)
    {
        var methods = typeof(EditorGUI).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
        var _LayerMaskField = methods.FirstOrDefault(c =>
        {
            return
                c.Name == "LayerMaskField" &&
                c.GetParameters()[0].ParameterType == typeof(Rect) &&
                c.GetParameters()[1].ParameterType == typeof(LayerMask) &&
                c.GetParameters()[2].ParameterType == typeof(GUIContent);
        });

        //ここでエラーが出る場合はUnity標準のライブラリが変更された可能性？
        if (_LayerMaskField == null)
            throw new System.NullReferenceException("LayerMaskField was not found.");

        return (LayerMask)_LayerMaskField.Invoke(null, new object[] { position, layers, label });
    }

    public static uint LayerMaskField(Rect position, uint layers, GUIContent label)
    {
        var methods = typeof(EditorGUI).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
        var _LayerMaskField = methods.FirstOrDefault(c =>
        {
            return
                c.Name == "LayerMaskField" &&
                c.GetParameters()[0].ParameterType == typeof(Rect) &&
                c.GetParameters()[1].ParameterType == typeof(uint) &&
                c.GetParameters()[2].ParameterType == typeof(GUIContent);
        });

        //ここでエラーが出る場合はUnity標準のライブラリが変更された可能性？
        if (_LayerMaskField == null)
            throw new System.NullReferenceException("LayerMaskField was not found.");

        return (uint)_LayerMaskField.Invoke(null, new object[] { position, layers, label });
    }
}
#endif
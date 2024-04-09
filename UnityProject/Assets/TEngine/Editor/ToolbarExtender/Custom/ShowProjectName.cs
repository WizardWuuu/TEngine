using UnityEditor;
using UnityEngine;
using UnityToolbarExtender;

namespace TEngine
{
    /// <summary>
    /// 在Toolbar中显示工程名称
    /// </summary>
    [InitializeOnLoad]
    public class ShowProjectName : MonoBehaviour
    {
        private static string m_projectName;
    
        static ShowProjectName()
        {
            ToolbarExtender.LeftToolbarGUI.Add(OnToolbarGUI);
        }

        private static void OnToolbarGUI()
        {
            if (null == m_projectName)
            {
                var names = Application.dataPath.Split("/");
                m_projectName = names.Length > 2 ? $"\tProjectName:【{names[^3]}】" : Application.dataPath;
            }

            GUILayout.Label(m_projectName);
        }
    }    
}


using UnityEditor;
using UnityEngine;

public class MenuItems : MonoBehaviour
{

    [MenuItem("Tools/Clear PlayerPrefs")]
    private static void NewMenuOption()
    {
        PlayerPrefs.DeleteAll();
    }
}

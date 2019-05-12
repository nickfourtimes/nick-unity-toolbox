using System.Reflection;
using UnityEditor;
using UnityEngine;


public class EditorMeta {

    /********************************************************************************************** CONSTANTS */

    const string MENU_PREFIX = "Nick/";


    /********************************************************************************************** DATA MEMBERS */


    /********************************************************************************************** MENU ITEMS */

    [MenuItem(MENU_PREFIX + "Windows/Open Player Settings %#l", false, 0)]
    static void OpenPlayerSettings() {
#if UNITY_2018_3_OR_NEWER
        SettingsService.OpenProjectSettings("Project/Player").Focus();
#else
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Player");
#endif
        return;
    }
	

    [MenuItem(MENU_PREFIX + "Clear PlayerPrefs...", false, 1000)]
    private static void DeletePlayerPrefs() {
        if (EditorUtility.DisplayDialog(
                    "Erase everything?",
                    "Erase all of PlayerPrefs (save data)?",
                    "Yes",
                    "No")) {
            PlayerPrefs.DeleteAll();
            Debug.LogWarning("All PlayerPrefs data erased!");
        } else {
            // no op
        }

        return;
    }


    [MenuItem(MENU_PREFIX + "Clear EditorPrefs...", false, 1001)]
    private static void DeleteEditorPrefs() {
        if (EditorUtility.DisplayDialog(
                    "Erase everything?",
                    "Erase all of EditorPrefs?",
                    "Yes",
                    "No")) {
            EditorPrefs.DeleteAll();
            Debug.LogWarning("All EditorPrefs data erased!");
        } else {
            // no op
        }

        return;
    }
}

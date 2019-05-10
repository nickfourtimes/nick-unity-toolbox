using UnityEditor;
using UnityEngine;


public class EditorMeta {

    /********************************************************************************************** DATA MEMBERS */


    /********************************************************************************************** MENU ITEMS */

    [MenuItem("Nick/Windows/Open Player Settings %#l", false, 0)]
    static void Foo() {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Player");
        return;
    }
	

    [MenuItem("Nick/Clear PlayerPrefs...", false, 1000)]
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


    [MenuItem("Nick/Clear EditorPrefs...", false, 1001)]
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

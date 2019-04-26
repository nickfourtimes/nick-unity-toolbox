using UnityEditor;

/**
 * Keyboard shortcut to open the Player Settings window with Ctrl-Shift-L
 */
public class OpenPlayerSettings {

    [MenuItem("Nick/Windows/Open Player Settings %#l", false, 0)]
    static void Foo() {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Player");
        return;
    }
}

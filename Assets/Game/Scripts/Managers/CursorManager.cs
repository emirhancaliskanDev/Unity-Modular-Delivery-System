using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorManager : MonoBehaviour
{
    Scene currentScene;


    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        int sceneIndex = currentScene.buildIndex;

        switch (sceneIndex)
        {
            case 0:
                SetCursorLockMode(false);
                SetCursorVisibility(true);
                break;
            case 1:
                SetCursorLockMode(true);
                SetCursorVisibility(false);
                break;

        }
    }

    public void SetCursorVisibility(bool state)
    {
        Cursor.visible = state;
    }

    public void SetCursorLockMode(bool state )
    {
        switch (state)
        {
            case true:
                Cursor.lockState = CursorLockMode.Locked;
                break;
            case false:
                Cursor.lockState = CursorLockMode.None;
                break;
        }
        
    }
}

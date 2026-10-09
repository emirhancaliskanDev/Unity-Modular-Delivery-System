using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
    void Start()
    {
        Scene currentSceneIndex = SceneManager.GetActiveScene();

        int sceneIndex = currentSceneIndex.buildIndex;

        if (sceneIndex == 0)
        {
            print("Menü");
        }
        else if(sceneIndex == 1)
        {
            print("Oyun");
        }
    }
}

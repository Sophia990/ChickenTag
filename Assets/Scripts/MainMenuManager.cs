#if UNITY_EDITOR
    using UnityEditor;
#endif
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    SceneTransition sceneTransition;

    private void Start()
    {
        sceneTransition = FindObjectOfType<SceneTransition>();
    }


    public void StartGame() => sceneTransition.LoadScene("Game");

    public void Credits() => sceneTransition.LoadScene("Credits");

    public void ReturnToMenu() => sceneTransition.LoadScene("Main Menu");

    public void QuitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #endif
    }
}

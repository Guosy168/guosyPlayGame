using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPanel : MonoBehaviour
{
    [SerializeField] private string gameSceneName = "Scene_Main"; // 在 Inspector 里填目标场景名

    public void OnStartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void OnExitGame()
    {
        Application.Quit();
    }
}
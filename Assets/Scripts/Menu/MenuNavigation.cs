using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public void QuitGame() {
        Application.Quit();
    }

    public void OpenSettings() {
        SceneManager.LoadScene("SettingsScene");
    }

    public void StartGame() {
        SceneManager.LoadScene("GameScene");
    }
}
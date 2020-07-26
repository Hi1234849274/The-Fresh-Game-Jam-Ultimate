using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
bool isPaused = false;
public KeyCode pauseKey = KeyCode.Escape;
public GameObject pauseObject;

    void Update() {
        if (Input.GetKeyDown(pauseKey)) {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }
    public void Resume() {
        Time.timeScale = 1f;
        pauseObject.SetActive(false);
        isPaused = false;
    }
    void Pause() {
        Time.timeScale = 0f;
        pauseObject.SetActive(true);
        isPaused = true;
    }
    public void MainMenu() {
        SceneManager.LoadScene(0);
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void NewGame() {
        PlayerPrefs.SetInt("GamesPlayed", PlayerPrefs.GetInt("GamesPlayed", 0) + 1);
    }
    public void QuitGame() {
        PlayerPrefs.Save();
        Application.Quit(0);
    }
    







}
using UnityEngine;

[RequireComponent(typeof(UIManager))]
public class GameManager : MonoBehaviour
{
public GameObject Player;
[HideInInspector]
public UIManager uiManager;



    void Start() {
        Player = GameObject.Find("Player");
        uiManager = GetComponent<UIManager>();
    }


    public void GameOver() {
        Debug.Log("Game is Over!");
    }

}
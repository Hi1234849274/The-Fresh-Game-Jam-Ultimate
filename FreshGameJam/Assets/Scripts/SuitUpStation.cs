using UnityEngine;

public class SuitUpStation : MonoBehaviour
{
public bool canSuitUp = false;


    void Start() {
       
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            canSuitUp = true;
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            canSuitUp = false;
        }
    }
}
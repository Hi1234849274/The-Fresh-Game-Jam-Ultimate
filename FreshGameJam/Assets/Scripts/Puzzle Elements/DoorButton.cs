using UnityEngine;
using UnityEngine.Events;

public class DoorButton : MonoBehaviour {
    
    bool isPressed = false;

    public UnityEvent onPress;
    public UnityEvent onUnPress;
    public float distanceToPressMax = 5f;
    private GameManager gM;


    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            if (isPressed) {
                UnPress();
            } else {
                Press();
            }
        }
    }
    void OnMouseDown() {
        if (Vector2.Distance(transform.position, gM.Player.transform.position) < distanceToPressMax) {
            if (isPressed) {
                UnPress();
            } else {
                Press();
            }
        }
    }
    void Press() {
        if (Vector2.Distance(transform.position, gM.Player.transform.position) < distanceToPressMax) {
            Debug.Log("Button was Pressed! Game Object: " + gameObject);
            isPressed = true;
            onPress.Invoke();
        }
    }
    void UnPress() {
        if (Vector2.Distance(transform.position, gM.Player.transform.position) < distanceToPressMax) {
            Debug.Log("Button was Unpressed! Game Object: " + gameObject);
            isPressed = false;
            onUnPress.Invoke();
        }
    } 
}
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(Battery))]
public class PlayerSuit : MonoBehaviour {

public bool canSuitUp = false;
public bool isInSuit = false; 
public KeyCode suitUpButton = KeyCode.Q;
PlayerMovement moveScript;
Battery batteryScript;

    void Start() {
        moveScript = GetComponent<PlayerMovement>();
        batteryScript = GetComponent<Battery>();
    }

    void Update() {
        if (Input.GetKeyDown(suitUpButton)) {
            if (canSuitUp) {
                switch (isInSuit) {
                    case false:
                    //  Put him in suit
                    SuitUp();
                    break;
                    case true:
                    SuitOff();
                    break;
                }
            }

        }
    }
    void SuitUp() {
        isInSuit = true;
        moveScript.speed = moveScript.suitMoveSpeed;
        batteryScript.isPowered = true;
    }
    void SuitOff() {
        isInSuit = false;
        moveScript.speed = moveScript.moveSpeed;
        batteryScript.isPowered = false;
    }




}
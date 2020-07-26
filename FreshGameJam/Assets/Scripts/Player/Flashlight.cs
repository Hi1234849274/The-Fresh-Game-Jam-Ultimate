using UnityEngine;

public class Flashlight : MonoBehaviour
{
public new GameObject light;
public bool isOn = false;
public KeyCode flashKey = KeyCode.F;




    void Update() {
        if (Input.GetKeyDown(flashKey)) {
            switch (isOn) {
                case true:

                break;
                case false:

                break;
            }
        }
    }




}

using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    Battery batteryScript;
    public Slider batBar;

    void Update() {
        batBar.maxValue = batteryScript.maxBattery;
        batBar.value = batteryScript.currentBattery;
    }
}
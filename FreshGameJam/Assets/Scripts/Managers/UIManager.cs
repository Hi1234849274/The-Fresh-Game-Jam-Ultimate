using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public Battery batteryScript;
    public Slider batBar;

    void Update() {
        batBar.maxValue = batteryScript.maxBattery;
        batBar.value = batteryScript.currentBattery;
    }
}
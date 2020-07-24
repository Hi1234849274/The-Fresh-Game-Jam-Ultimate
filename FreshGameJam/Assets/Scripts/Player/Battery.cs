using UnityEngine;
using UnityEngine.Events;

public class Battery : MonoBehaviour
{
    public float maxBattery = 10f;
    public float startBattery = 10f;
    [HideInInspector]
    public float currentBattery;
    public UnityEvent onBatteryOut;
    public bool isPowered = false;


    void Start() {
        currentBattery = startBattery;
    }
    void Update() {
        currentBattery = Mathf.Clamp(currentBattery, 0f, maxBattery);

        if (currentBattery <= 0) {
            if (!isPowered)
                onBatteryOut.Invoke();
        } else {
            if (!isPowered)
                currentBattery -= Time.deltaTime;
            else
                currentBattery += Time.deltaTime;
        }
    }
    public void RefillBattery() {
        if (currentBattery != startBattery)
            currentBattery = startBattery;
    }
}
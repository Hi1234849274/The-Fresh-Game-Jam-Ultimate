using UnityEngine;
using UnityEngine.Events;

public class Oxygen : MonoBehaviour
{
public float maxOxygen = 10f;
public float startOxygen = 10f;
[HideInInspector]
public float currentOxygen;

public UnityEvent onOxygenOut;
    

public bool isBreathing = false;


    void Start() {
        currentOxygen = startOxygen;
    }
    void Update() {
        currentOxygen = Mathf.Clamp(currentOxygen, 0f, maxOxygen);

        if (isBreathing)
            currentOxygen = startOxygen;




        if (currentOxygen <= 0)
            onOxygenOut.Invoke();
        else
            currentOxygen -= Time.deltaTime;
    }
    public void ResetOxygen() {
        if (currentOxygen != startOxygen)
            currentOxygen = startOxygen;
    }











}

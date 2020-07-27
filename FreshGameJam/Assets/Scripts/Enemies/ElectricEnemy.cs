using UnityEngine;

public class ElectricEnemy : MonoBehaviour {
    
    public bool isSleeping = true;
    [Header("Detection")]
    public float minDetectRadius = 0f;
    public float maxDetectRadius = 10f;
    private float detectRadius;
    public LayerMask electricLayer;

    void Start() {
        detectRadius = Random.Range(minDetectRadius, maxDetectRadius);
    }
    void Update() {
        if (Physics2D.OverlapCircle(transform.position, detectRadius, electricLayer)) {
            isSleeping = false;
        } else {
            isSleeping = true;
        }
    }






}
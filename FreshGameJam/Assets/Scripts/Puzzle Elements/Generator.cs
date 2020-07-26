using UnityEngine;

public class Generator : MonoBehaviour {
    
    public GameManager gM;

    public int toolsToRepair = 3;
    public float distanceToPressMax = 3f;
    int toolsUsed;

    bool isPowered;

    void Update() {
        if (toolsUsed == toolsToRepair)
            isPowered = true;
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            toolsUsed++;
        }
    }
    void OnMouseDown() {
        if (Vector2.Distance(transform.position, gM.Player.transform.position) < distanceToPressMax) {
            toolsUsed++;
        }
    }
}

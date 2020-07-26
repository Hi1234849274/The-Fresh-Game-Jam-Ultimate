using UnityEngine;

public class LockedDoor : MonoBehaviour {
    
    bool isLocked = true;
    Inventory inventory;
    
    public GameManager gM;
    
    void Start() {
        gM = FindObjectOfType<GameManager>();
        inventory = gM.Player.GetComponent<Inventory>();
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            if (isLocked) {
                if (inventory.Has(ItemContainer.key)) {
                    inventory.RemoveItem(ItemContainer.key);
                    isLocked = false;
                }
            } else {
                OpenDoor();
            }
        }
    }
    void OpenDoor() {
        gameObject.SetActive(false);
    }
    void Reset() {
        gM = FindObjectOfType<GameManager>();
        inventory = gM.Player.GetComponent<Inventory>();
    }
}
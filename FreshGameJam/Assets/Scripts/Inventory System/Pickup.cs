using UnityEngine;

public enum PickupType {
Key,
KeyFragment
}
public class Pickup : MonoBehaviour {

    public PickupType itemToAddType;   
    private Item itemToAdd;
    public GameManager gM;

    void Start() {
        if (itemToAddType == PickupType.Key)
            itemToAdd = ItemContainer.key;
        else if (itemToAddType == PickupType.KeyFragment)
            itemToAdd = ItemContainer.keyFragment;
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            PickupItem();
        }
    }
    
    void PickupItem() {
        gM.Player.GetComponent<Inventory>().AddItem(itemToAdd);
        Destroy(gameObject);
    }
}
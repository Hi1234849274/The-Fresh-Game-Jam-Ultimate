using UnityEngine;

public class FragmentSystem : MonoBehaviour {

Inventory inventory;
public int fragmentsToFill = 3;
public int fragmentsFound;

    void Start() => inventory = GameObject.Find("Player").GetComponent<Inventory>();


    void Update() {
        if (fragmentsFound == fragmentsToFill) {
            inventory.RemoveAll(ItemContainer.keyFragment);
            inventory.AddItem(ItemContainer.key);
        }
    }






}
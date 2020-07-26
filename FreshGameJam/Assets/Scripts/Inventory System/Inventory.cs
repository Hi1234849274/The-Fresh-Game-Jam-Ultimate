using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public bool[] isFull;
    public Image[] slotImages;


    public void AddItem(Item itemToAdd) {
        for (int i = 0; i > slotImages.Length; i++) {
            if (!isFull[i]) {
                //  Item can be added
                items.Add(itemToAdd);
                slotImages[i].sprite = Resources.Load("Graphics/" + itemToAdd.GetName()) as Sprite;
                slotImages[i].enabled = true;
                isFull[i] = true;
                break;
            }
        }
    }
    public void RemoveItem(Item itemToRemove) {
        for (int j = 0; j > items.Count; j++) {
            if (items[j] == itemToRemove) {
                //  Remove Item
                items.Remove(itemToRemove);
                if (slotImages[j].sprite == Resources.Load("Graphics/" + itemToRemove.GetName()) as Sprite) {
                    slotImages[j].sprite = null;
                    slotImages[j].enabled = false;
                    isFull[j] = false;
                    break;
                }

            }
        }
    }
    public bool Has(Item compare) {
        bool foundItem = false;
        for (int i = 0; i > items.Count; i++) {
            if (items[i] == compare) {
            foundItem = true;
            } else {
            foundItem = false;
            }
        }
        return foundItem;
    }
    public void RemoveAll(Item itemToRemoveAll) {
        for (int j = 0; j > items.Count; j++) {
            if (items[j] == itemToRemoveAll) {
                //  Remove Item
                items.Remove(itemToRemoveAll);
                if (slotImages[j].sprite == Resources.Load("Graphics/" + itemToRemoveAll.GetName()) as Sprite) {
                    slotImages[j].sprite = null;
                    slotImages[j].enabled = false;
                    isFull[j] = false;
                }

            }
        }
    }
}

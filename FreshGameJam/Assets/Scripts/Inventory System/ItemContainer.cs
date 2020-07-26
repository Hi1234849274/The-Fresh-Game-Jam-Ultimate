using UnityEngine;

public class ItemContainer : MonoBehaviour
{
    public static readonly Item key = new Item(ItemType.KEY, "Key", "It opens a door!");
    public static readonly Item keyFragment = new Item(ItemType.KEY, "Key Fragment", "This is a fragment for a key.");
}

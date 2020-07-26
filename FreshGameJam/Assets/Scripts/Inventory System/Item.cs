using UnityEngine;

public enum ItemType {
KEY,
WEAPON,
UTILITY
}



[System.Serializable]
public class Item {

    public ItemType type;
    public string name;
    public string description;

    public Item (ItemType type, string name, string description) {
        this.type = type;
        this.name = name;
        this.description = description;
    }



    public ItemType GetItemType() {
        return type;
    }
    public string GetName() {
        return name;
    }
    public string GetDescription() {
        return description;
    }
}

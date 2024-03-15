using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]
public class ScriptableItem : ScriptableObject
{
    public enum ItemType
    {
        Wearpon,
        Armor,
        Shield
    }
    public ItemType itemType;

    public string itemName;

    public string itemDescription;

    public int itemprice;

    public Sprite itemSprite;
}

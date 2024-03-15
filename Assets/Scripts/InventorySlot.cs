using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public ScriptableItem slotItem;

    public int slotNumber;
    
    public GameObject inspectionWindow;
    public Image inspectionImage;

    public Text inspectionName;
    public Text inspectionPrice;
    public Text inspectionDescription;

    public Button deleteButton;

    public void InspectItem()
    {
        if(slotItem =! null)
        {
            inspectionImage.sprite = slotItem.itemSprite;
            inspectionName.text = slotItem.itemName;
            inspectionPriece.text = slotItem.itemPrice.ToString();
            inspectionDescription.text = slotItem.itemDescription;

            inspectionWindow.SetActive(true);
        }
    }
}

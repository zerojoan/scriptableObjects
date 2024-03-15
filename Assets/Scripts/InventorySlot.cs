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
        if(slotItem != null)
        {
            inspectionImage.sprite = slotItem.itemSprite;
            inspectionName.text = slotItem.itemName;
            inspectionPrice.text = slotItem.itemprice.ToString();
            inspectionDescription.text = slotItem.itemDescription;

            inspectionWindow.SetActive(true);
        }

        deleteButton.onClick.AddListener(RemoveItem);
    }

    public void RemoveItem()
    {
        if(InventoryManager.instance.weapons[slotNumber] != null)
        {
            InventoryManager.instance.weapons [slotNumber] = null;
            InventoryManager.instance.weaponsName[slotNumber].text = "Empty";
            InventoryManager.instance.weaponsSprites[slotNumber].sprite = null;
        }

        slotItem = null; 
        
        deleteButton.onClick.RemoveListener(RemoveItem);
        inspectionWindow.SetActive(false);
    }
    
   
}

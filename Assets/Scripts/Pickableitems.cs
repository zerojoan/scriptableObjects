using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickableitems : MonoBehaviour
{

    public ScriptableItem item;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer =GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;
    }
     void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.instance.AddItem(item);
        Destroy(this.gameObject);
    }
}

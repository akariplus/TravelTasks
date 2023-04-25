using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackpackScript : MonoBehaviour, IDropHandler
{

    public Minigamehandler Handler;
    public GameObject itemHolder;
    public DragDropItem[] Items;

    private void Start()
    {
        Handler = GameObject.Find("Game").GetComponent<Minigamehandler>();
        itemHolder = GameObject.Find("ItemHolder");
        Items = itemHolder.GetComponentsInChildren<DragDropItem>();
}

    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<DragDropItem>().Packed = true;
        }
        int count = 0;
        foreach (DragDropItem item in Items)
        {
            if (item.Packed == true)
            {
                count++;
            }
        }
        Handler.Packed = count;
    }
}

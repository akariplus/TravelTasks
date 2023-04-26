using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackpackScript : MonoBehaviour, IDropHandler
{

    public Minigamehandler minigameHandler;
    public CutsceneHandler cutsceneHandler;
    public GameObject itemHolder;
    public DragDropItem[] Items;
    public GameObject BackpackBase, BackpackInside, BackpackFlap;

    private void Start()
    {
        minigameHandler = GameObject.Find("Game").GetComponent<Minigamehandler>();
        cutsceneHandler = GameObject.Find("Canvas").GetComponent<CutsceneHandler>();
        itemHolder = GameObject.Find("ItemHolder");
        Items = itemHolder.GetComponentsInChildren<DragDropItem>();
}

    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<DragDropItem>().Packed = true;
            eventData.pointerDrag.SetActive(false);
        }
        int count = 0;
        foreach (DragDropItem item in Items)
        {
            if (item.Packed == true)
            {
                count++;
            }
        }
        minigameHandler.Packed = count;
    }
    public void Finish()
    {
        BackpackBase.SetActive(false);
        BackpackInside.SetActive(false);
        BackpackFlap.SetActive(false);
        itemHolder.SetActive(false);
    }
}

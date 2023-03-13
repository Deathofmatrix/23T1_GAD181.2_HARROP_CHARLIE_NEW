using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DragnDrop.CharlieHarrop
{
    public class CellSlot : MonoBehaviour, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            if (transform.childCount == 0)
            {
                GameObject dropped = eventData.pointerDrag;
                DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
                draggableItem.parentAfterDrag = transform;

                MoneyManager.moneyPerSecond += draggableItem.GetMoneyGeneration();

                ShopCell.itemNotSlotted = false;

                MoneyManager.currentMoney -= draggableItem.GetPrice();
            }
        }
    }
}


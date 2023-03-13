using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DragnDrop.CharlieHarrop
{
    public class DestroyItem : MonoBehaviour, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            GameObject dropped = eventData.pointerDrag;
            Destroy(dropped);

            


            ShopCell.itemNotSlotted = false;
        }
    }
}


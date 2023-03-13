using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;


namespace DragnDrop.CharlieHarrop
{
    public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        [HideInInspector] public Transform parentAfterDrag;

        public Image item;

        //[SerializeField] private Image image;
        [SerializeField] private int sellValue;
        [SerializeField] private string itemType;
        [SerializeField] private Color itemColour;

        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("begin drag");
            parentAfterDrag = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            item.raycastTarget = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            Debug.Log("dragging");
            transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("end drag");
            transform.SetParent(parentAfterDrag);
            item.raycastTarget = true;
        }

        public void SetStats(string newItemType, int newSellValue, Color newItemColour)
        {
            itemType = newItemType;
            //image = newImage;
            sellValue = newSellValue;
            itemColour = newItemColour;
        }
    }
}


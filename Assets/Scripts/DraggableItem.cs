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
        [SerializeField] private float moneyGeneration;
        [SerializeField] private string itemType;
        [SerializeField] private int price;

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

        public void SetStats(string newItemType, float newMoneyGeneration, Color newItemColour, int newPrice)
        {
            itemType = newItemType;
            //image = newImage;
            moneyGeneration = newMoneyGeneration;
            price = newPrice;
            item.color = newItemColour;
        }

        public float GetMoneyGeneration()
        {
            return moneyGeneration;
        }

        public int GetPrice()
        {
            return price;
        }
    }
}


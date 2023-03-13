using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DragnDrop.CharlieHarrop
{
    public class ShopCell : MonoBehaviour, IPointerDownHandler
    {
        public static bool itemNotSlotted;

        [SerializeField] private GameObject itemPrefab;
        [SerializeField] private Canvas canvas;
        [SerializeField] private string plantName;
        [SerializeField] private float moneyGenerationAmount;
        [SerializeField] private int itemPrice;
        [SerializeField] private Color itemColour;
        

        private void Start()
        {
            canvas = transform.root.GetComponent<Canvas>();
            gameObject.name = plantName + " Shop";
        }

        private void Update()
        {
            if (itemPrice > MoneyManager.currentMoney)
            {
                GetComponent<Button>().interactable = false;
                Debug.Log("no interact");
            }
            else
            {
                GetComponent<Button>().interactable = true;
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (GetComponent<Button>().interactable && !itemNotSlotted)
            {
                GameObject newPlant = Instantiate(itemPrefab, Input.mousePosition, Quaternion.identity);
                newPlant.transform.SetParent(canvas.transform, false);

                DraggableItem itemScriptStats = newPlant.GetComponent<DraggableItem>();
                itemScriptStats.SetStats(plantName, moneyGenerationAmount, itemColour, itemPrice);

                Debug.Log(newPlant.name);

                itemNotSlotted = true;
            }
        }
    }
}
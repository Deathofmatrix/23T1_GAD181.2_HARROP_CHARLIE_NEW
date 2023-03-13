using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DragnDrop.CharlieHarrop
{
    public class ShopCell : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private string plantName;
        [SerializeField] private GameObject itemPrefab;
        [SerializeField] private Canvas canvas;


        private void Start()
        {
            canvas = transform.root.GetComponent<Canvas>();
            gameObject.name = plantName + " Shop";
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            GameObject newPlant = Instantiate(itemPrefab, Input.mousePosition, Quaternion.identity);
            newPlant.transform.SetParent(canvas.transform, false);
        }
    }
}


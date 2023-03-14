using DragnDrop.CharlieHarrop;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragnDrop.CharlieHarrop
{
    public class GridManager : MonoBehaviour
    {
        [Header("Collections")]
        [SerializeField] public static List<DraggableItem> currentItems;

        private void Start()
        {
            currentItems.Clear();
        }
    }
}


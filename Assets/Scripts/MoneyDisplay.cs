using DragnDrop.CharlieHarrop;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DragnDrop.CharlieHarrop
{
    public class MoneyDisplay : MonoBehaviour
    {
        public TextMeshProUGUI moneyText;

        // Update is called once per frame
        void Update()
        {
            moneyText.text = "$" + (int)MoneyManager.currentMoney;
        }
    }
}


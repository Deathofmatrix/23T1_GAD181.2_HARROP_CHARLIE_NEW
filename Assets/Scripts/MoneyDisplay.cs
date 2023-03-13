using DragnDrop.CharlieHarrop;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DragnDrop.CharlieHarrop
{
    public class MoneyDisplay : MonoBehaviour
    {
        public Text moneyText;

        // Update is called once per frame
        void Update()
        {
            moneyText.text = "$" + (int)MoneyManager.currentMoney;
        }
    }
}


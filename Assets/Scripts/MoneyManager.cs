using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragnDrop.CharlieHarrop
{
    public class MoneyManager : MonoBehaviour
    {
        public static float currentMoney;
        public static float moneyPerSecond;

        private void Start()
        {
            currentMoney = 0;
            moneyPerSecond = 0;
        }

        private void Update()
        {
            currentMoney += moneyPerSecond * Time.deltaTime;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragnDrop.CharlieHarrop
{
    public class MoneyManager : MonoBehaviour
    {
        public static float currentMoney;
        public float showCurrentMoney;
        public static float moneyPerSecond;
        public float showMoneyPerSecond;

        private void Start()
        {
            currentMoney = 1f;
            moneyPerSecond = 0f;
        }

        private void Update()
        {
            currentMoney += moneyPerSecond * Time.deltaTime;
            showCurrentMoney = currentMoney;
            showMoneyPerSecond = moneyPerSecond;
        }
    }
}
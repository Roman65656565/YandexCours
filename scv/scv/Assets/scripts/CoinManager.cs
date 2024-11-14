using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] int _numberCoinInLivel1;
    [SerializeField] TextMeshProUGUI _text;
    

    public void AddOne()
    {
        _numberCoinInLivel1 += 1;
        _text.text = _numberCoinInLivel1.ToString();
    }
}

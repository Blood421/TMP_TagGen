using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextMeshProTagGen;
using TMPro;

public class TextTagDebug : MonoBehaviour
{
    private TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text += TagGen.Alpha("#0F", "OK");
        text.text += TagGen.ColorCode("#FF00FF", "OK");
        text.text += TagGen.LineHeight(100, "OK\nOOO");
    }
    
}

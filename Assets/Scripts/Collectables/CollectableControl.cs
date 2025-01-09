using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableControl : MonoBehaviour
{

    public static int coinCount;
    public TextMeshProUGUI coinCountDisplay;
    public TextMeshProUGUI coinEndDisplay;




    void Update()
    {
        coinCountDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + coinCount;
        coinEndDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + coinCount;

    }
}

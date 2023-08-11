using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private void Update()
    {
        txt.text = "Noughts points: " + GameManager.gameManager.NoughtPoints + "\nCrosses points: " + GameManager.gameManager.CrossesPoints; 
    }
}

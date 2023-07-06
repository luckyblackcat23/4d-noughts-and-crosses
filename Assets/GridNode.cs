using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNode : MonoBehaviour
{
    public Vector4 pos;
    public GameObject nought, cross;
    //false = noughts
    //true = crosses
    public bool turn;

    private void OnMouseUp()
    {
        if(GameManager.Noughts.Contains(pos) || GameManager.Crosses.Contains(pos))
        {
            if (turn)
            {
                nought.SetActive(true);
                GameManager.Noughts.Add(pos);
            }
            else
            {
                cross.SetActive(true);
                GameManager.Crosses.Add(pos);
            }
        }
    }

    private void OnMouseEnter()
    {
        
    }

    private void OnMouseExit()
    {
        
    }
}
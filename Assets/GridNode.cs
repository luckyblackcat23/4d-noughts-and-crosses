using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNode : MonoBehaviour
{
    public Vector4 pos;
    public GameObject nought, cross;
    //false = noughts
    //true = crosses
    public static bool turn;
    public bool occupied;

    private void OnMouseEnter()
    {
        if (!turn)
        {
            nought.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 10);
            nought.SetActive(true);
        }
        else
        {
            cross.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 10);
            cross.SetActive(true);
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!turn)
            {
                if (!GameManager.gameManager.Noughts.Contains(pos) || !GameManager.gameManager.Crosses.Contains(pos))
                {
                    nought.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                    nought.SetActive(true);
                    GameManager.gameManager.Noughts.Add(pos);
                    occupied = true;
                    turn = true;
                }
            }
            /*else
            {
                if (!GameManager.gameManager.Noughts.Contains(pos) || !GameManager.gameManager.Crosses.Contains(pos))
                {
                    cross.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                    cross.SetActive(true);
                    GameManager.gameManager.Crosses.Add(pos);
                    occupied = true;
                }
            }*/
        }
    }

    private void OnMouseExit()
    {
        if (!occupied)
        {
            nought.SetActive(false);
            cross.SetActive(false);
        }
    }
}
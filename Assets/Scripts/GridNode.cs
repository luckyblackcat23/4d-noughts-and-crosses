using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNode : MonoBehaviour
{
    public Vector4 pos;
    public GameObject nought, cross;
    public static bool turn;
    //false = noughts ^
    //true = crosses  ^
    public bool occupied;

    private void OnMouseOver()
    {
        if (!GameManager.gameManager.Noughts.Contains(pos) && !GameManager.gameManager.Crosses.Contains(pos))
        {
            nought.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 90);
            nought.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!turn && !GameManager.gameManager.Noughts.Contains(pos) && !GameManager.gameManager.Crosses.Contains(pos))
            {
                nought.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                nought.SetActive(true);
                GameManager.gameManager.Noughts.Add(pos);
                occupied = true;
                turn = true;
            }
        }
    }

    private void OnMouseExit()
    {
        if (!GameManager.gameManager.Noughts.Contains(pos) && !GameManager.gameManager.Crosses.Contains(pos))
        {
            nought.SetActive(false);
            cross.SetActive(false);
        }
    }
    

    private void Update()
    {
        //dont remember why i put this here, but i've left is commented just incase
        /*if (!GameManager.gameManager.Noughts.Contains(pos))
        {
            nought.SetActive(false);
        }

        if (!GameManager.gameManager.Crosses.Contains(pos))
        {
            cross.SetActive(false);
        }*/

        occupied = !GameManager.gameManager.Noughts.Contains(pos) && !GameManager.gameManager.Crosses.Contains(pos);
    }
}
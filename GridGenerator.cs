using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject GridSquare;

    public void Start()
    {
        for (int i = 0; i < GameManager.GameArea.x; i++)
        {
            for (int ii = 0; ii < GameManager.GameArea.y; ii++)
            {
                Instantiate(GridSquare, new Vector2(i - GameManager.GameArea.x / 2, ii - GameManager.GameArea.y / 2), new Quaternion());
            }
        }
    }
}

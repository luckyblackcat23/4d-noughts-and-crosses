using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject GridSquare;
    
    public void Start()
    {
        for(i = 0; i < GameManager.GameArea.x; i++)
        {
            for(ii = 0; ii < GameManager.GameArea.y; ii++)
            {
                Instantiate(GridSquare, new Quaternion, new Vector2(i - GameArea.x / 2, ii - GameArea.y / 2))
            }
        }
    }
}

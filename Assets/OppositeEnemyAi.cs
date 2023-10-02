using UnityEngine;

public class OppositeEnemyAi : MonoBehaviour
{
    GameManager GM = GameManager.gameManager;
    void Update()
    {
        if(Gridnode.turn)
        {
           //place a piece at the opposite position to GM.Noughts.Last()
        }
    }

    GridNode FindGridNodeAtPosition(Vector4 pos)
    {
        foreach (GridNode gridNode in GameObject.FindObjectsOfType<GridNode>())
        {
            if(gridNode.pos == pos)
            {
                return gridNode;
            }
        }

        return null;
    }
}

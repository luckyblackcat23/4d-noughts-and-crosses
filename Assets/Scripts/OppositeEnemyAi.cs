using UnityEngine;
using System.Linq;

public class OppositeEnemyAi : MonoBehaviour
{
    GameManager GM;

    private void Start()
    {
        GM = GameManager.gameManager;
    }
    void Update()
    {
        if(GridNode.turn)
        {
            Vector4 pos = GM.GameArea - Vector4.one - GM.Noughts.Last();
            GM.Crosses.Add(pos);
            FindGridNodeAtPosition(pos).cross = Instantiate(GridGenerator.Cross, new Vector2(pos.x - GM.GameArea.x / 2 + 0.5f + ((GM.GameArea.x + 1) * (pos.z - (GM.GameArea.z - 1) / 2)), pos.y - GM.GameArea.y / 2 + 0.5f + (GM.GameArea.y + 1) * (pos.w - (GM.GameArea.w - 1) / 2)), new Quaternion());
            FindGridNodeAtPosition(pos).occupied = true;
            GridNode.turn = false;
            GM.EndTurn();
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

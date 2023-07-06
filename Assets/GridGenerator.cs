using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public static GameObject GridSquare;
    public static GameObject Nought, Cross;

    public void Start()
    {
        for (int i = 0; i < GameManager.GameArea.x; i++)
        {
            for (int ii = 0; ii < GameManager.GameArea.y; ii++)
            {
                GameObject Node = Instantiate(GridSquare, new Vector2(i - GameManager.GameArea.x / 2, ii - GameManager.GameArea.y / 2), new Quaternion());
                Node.GetComponent<GridNode>().nought = Instantiate(Nought, new Vector2(i - GameManager.GameArea.x / 2, ii - GameManager.GameArea.y / 2), new Quaternion());
                Node.GetComponent<GridNode>().cross = Instantiate(Cross, new Vector2(i - GameManager.GameArea.x / 2, ii - GameManager.GameArea.y / 2), new Quaternion());
                Node.GetComponent<GridNode>().nought.SetActive(false);
                Node.GetComponent<GridNode>().cross.SetActive(false);
                Node.GetComponent<GridNode>().pos = new Vector4(i, ii);
            }
        }
    }
}
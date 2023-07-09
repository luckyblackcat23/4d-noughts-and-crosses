using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public static GameObject GridSquare;
    public GameObject gridSqaure;
    public static GameObject Nought, Cross;
    public GameObject nought, cross, GridLine;

    public void Start()
    {
        GridSquare = gridSqaure;
        Nought = nought;
        Cross = cross;
        
        for (int i = 0; i < GameManager.gameManager.GameArea.x; i++)
        {
            for (int ii = 0; ii < GameManager.gameManager.GameArea.y; ii++)
            {
                //GameObject Node = Instantiate(GridSquare, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f, ii - GameManager.gameManager.GameArea.y / 2 + 0.5f), new Quaternion());
                //Node.GetComponent<GridNode>().nought = Instantiate(Nought, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f, ii - GameManager.gameManager.GameArea.y / 2 + 0.5f), new Quaternion());
                //Node.GetComponent<GridNode>().cross = Instantiate(Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f, ii - GameManager.gameManager.GameArea.y / 2 + 0.5f), new Quaternion());
                //Node.GetComponent<GridNode>().nought.SetActive(false);
                //Node.GetComponent<GridNode>().cross.SetActive(false);
                //Node.GetComponent<GridNode>().pos = new Vector4(i, ii);

                for (int iii = 0; iii < GameManager.gameManager.GameArea.z; iii++)
                {
                    for (int iiii = 0; iiii < GameManager.gameManager.GameArea.w; iiii++)
                    {
                        if (!GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                        {
                            int sides = 0;
                            if (!GameManager.gameManager.Unplayable.Contains(new Vector4(i + 1, ii, iii, iiii)))
                            {
                                GameObject gridline = Instantiate(GridLine, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 1, ii - GameManager.gameManager.GameArea.y / 2 + 0.5f), Quaternion.Euler(0, 0, 90));
                                gridline.transform.position = new Vector2(gridline.transform.position.x + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), gridline.transform.position.y + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2));
                                //gridline.transform.position = new Vector2(gridline.transform.position.x - (GameManager.gameManager.GameArea.x + 1 + 2 * (GameManager.gameManager.GameArea.z - 3)), gridline.transform.position.y - (GameManager.gameManager.GameArea.y + 1 + 2 * (GameManager.gameManager.GameArea.w - 3)));
                                sides++;
                            }

                            if (!GameManager.gameManager.Unplayable.Contains(new Vector4(i - 1, ii, iii, iiii)))
                            {
                                GameObject gridline = Instantiate(GridLine, new Vector2(i - GameManager.gameManager.GameArea.x / 2, ii - GameManager.gameManager.GameArea.y / 2 + 0.5f), Quaternion.Euler(0, 0, 90));
                                gridline.transform.position = new Vector2(gridline.transform.position.x + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), gridline.transform.position.y + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2));
                                //gridline.transform.position = new Vector2(gridline.transform.position.x - (GameManager.gameManager.GameArea.x + 1 + 2 * (GameManager.gameManager.GameArea.z - 3)), gridline.transform.position.y - (GameManager.gameManager.GameArea.y + 1 + 2 * (GameManager.gameManager.GameArea.w - 3)));
                                sides++;
                            }

                            if (!GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii + 1, iii, iiii)))
                            {
                                GameObject gridline = Instantiate(GridLine, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f, ii - GameManager.gameManager.GameArea.y / 2 + 1), new Quaternion());
                                gridline.transform.position = new Vector2(gridline.transform.position.x + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), gridline.transform.position.y + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2));
                                //gridline.transform.position = new Vector2(gridline.transform.position.x - (GameManager.gameManager.GameArea.x + 1 + 2 * (GameManager.gameManager.GameArea.z - 3)), gridline.transform.position.y - (GameManager.gameManager.GameArea.y + 1 + 2 * (GameManager.gameManager.GameArea.w - 3)));
                                sides++;
                            }

                            if (!GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii - 1, iii, iiii)))
                            {
                                GameObject gridline = Instantiate(GridLine, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f, ii - GameManager.gameManager.GameArea.y / 2), new Quaternion());
                                gridline.transform.position = new Vector2(gridline.transform.position.x + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), gridline.transform.position.y + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2));
                                //gridline.transform.position = new Vector2(gridline.transform.position.x - (GameManager.gameManager.GameArea.x + 1 + 2 * (GameManager.gameManager.GameArea.z - 3)), gridline.transform.position.y - (GameManager.gameManager.GameArea.y + 1 + 2 * (GameManager.gameManager.GameArea.w - 3)));
                                sides++;
                            }

                            if(sides == 3)
                            {

                            }
                        }
                    }
                }
            }
        }
    }
}
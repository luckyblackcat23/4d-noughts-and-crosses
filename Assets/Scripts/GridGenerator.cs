using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public static GameObject GridSquare;
    public GameObject gridSqaure;
    public static GameObject Nought, Cross;
    public GameObject nought, cross, GridLine;

    public void ClearGrid()
    {
        foreach(GridNode gridNode in GameObject.FindObjectsOfType<GridNode>())
        {
            gridNode.nought.SetActive(false);
            gridNode.cross.SetActive(false);
            gridNode.occupied = false;
        }

        GameManager.gameManager.Noughts.Clear();
        GameManager.gameManager.Crosses.Clear();

        GameManager.gameManager.NoughtPoints = 0;
        GameManager.gameManager.CrossesPoints = 0;
    }

    public void Start()
    {
        GridSquare = gridSqaure;
        Nought = nought;
        Cross = cross;
        
        for (int i = 0; i < GameManager.gameManager.GameArea.x; i++)
        {
            for (int ii = 0; ii < GameManager.gameManager.GameArea.y; ii++)
            {
                for (int iii = 0; iii < GameManager.gameManager.GameArea.z; iii++)
                {
                    for (int iiii = 0; iiii < GameManager.gameManager.GameArea.w; iiii++)
                    {
                        if (!GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                        {
                            GameObject Node = Instantiate(GridSquare, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                            Node.GetComponent<GridNode>().nought = Instantiate(Nought, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                            Node.GetComponent<GridNode>().cross = Instantiate(Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                            Node.GetComponent<GridNode>().nought.SetActive(false);
                            Node.GetComponent<GridNode>().cross.SetActive(false);
                            //i spent 2 days trying to figure why the enemy AI wasnt working only to realise its because i forgot to add iii and iiii to the line below, shame on you past me
                            //                                                     ii   ii
                            Node.GetComponent<GridNode>().pos = new Vector4(i, ii, iii, iiii);

                            int sides = 0;
                            if (!GameManager.gameManager.Unplayable.Contains(new Vector4(i + 1, ii, iii, iiii)))
                            {
                                GameObject gridline = Instantiate(GridLine, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 1 + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), Quaternion.Euler(0, 0, 90));
                                sides++;
                            }

                            if (!GameManager.gameManager.Unplayable.Contains(new Vector4(i - 1, ii, iii, iiii)))
                            {
                                GameObject gridline = Instantiate(GridLine, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), Quaternion.Euler(0, 0, 90));
                                sides++;
                            }

                            if (!GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii + 1, iii, iiii)))
                            {
                                GameObject gridline = Instantiate(GridLine, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f, ii - GameManager.gameManager.GameArea.y / 2 + 1), new Quaternion());
                                gridline.transform.position = new Vector2(gridline.transform.position.x + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), gridline.transform.position.y + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2));
                                sides++;
                            }

                            if (!GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii - 1, iii, iiii)))
                            {
                                GameObject gridline = Instantiate(GridLine, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f, ii - GameManager.gameManager.GameArea.y / 2), new Quaternion());
                                gridline.transform.position = new Vector2(gridline.transform.position.x + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), gridline.transform.position.y + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2));
                                sides++;
                            }

                            if(sides == 4)
                            {

                            }
                        }

                        if(GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                        {

                        }
                    }
                }
            }
        }
    }
}


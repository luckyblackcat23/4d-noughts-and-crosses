using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
    EndTurn:
        if (GridNode.turn)
        {
            for (int iiii = 0; iiii < GameManager.gameManager.GameArea.w; iiii++)
            {
                for (int iii = 0; iii < GameManager.gameManager.GameArea.z; iii++)
                {
                    for (int ii = 0; ii < GameManager.gameManager.GameArea.y; ii++)
                    {
                        for (int i = 0; i < GameManager.gameManager.GameArea.x; i++)
                        {
                            //#XX
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //X#X
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //XX#
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //X##
                            //X##
                            //###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 2, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //X##
                            //###
                            //X##
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //###
                            //X##
                            //X##
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 2, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }


                            //##X
                            //#X#
                            //###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii + 2, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //##X
                            //###
                            //X##
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //###
                            //#X#
                            //X##
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii - 2, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //###
                            //#X#
                            //##X
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii - 2, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //X##
                            //###
                            //##X
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //X##
                            //#X#
                            //###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii + 2, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### #X# #X#
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii + 2, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii + 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //#X# ### #X#
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }


                            //### ### ###
                            //#X# #X# ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii - 2, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### #X# ##X
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii, iii + 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //X## ### ##X
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //X## #X# ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii, iii - 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### #X# X##
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii, iii + 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //##X ### X##
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii + 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //##X #X# ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii, iii - 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### #X#
                            //### #X# ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 2, iii + 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### #X#
                            //### ### ###
                            //#X# ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### #X# ###
                            //#X# ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 2, iii - 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### #X# ###
                            //### ### #X#
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 2, iii + 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //#X# ### ###
                            //### ### ###
                            //### ### #X#
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii + 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //#X# ### ###
                            //### #X# ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 2, iii - 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ##X
                            //### #X# ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii + 2, iii + 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ##X
                            //### ### ###
                            //X## ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### #X# ###
                            //X## ### ###

                            // >:)
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii - 2, iii - 2, iiii)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            //thats right, i swapped the + and - on this one AND THERES NOTHING YOU CAN DO ABOUT IT >:D
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //ok im sory for swapping the + and - around, to make up for it I SWAPPED AROUND THE 1 AND 2 >:D
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii + 2)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //*insert evil luaghter here*

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            //alright nothing wrong this time, nothing to worry about here
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii - 2)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion()); //thats right, you thought this was a useful comment, but no IT WAS ME, DIO
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //>:)

                            //### #X# ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### #X# ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### #X# ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### #X# ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### #X# ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### #X# ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### #X# ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### #X# ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### X## ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii + 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ##X ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### X## ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ##X ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii - 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### X## ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ##X ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### X## ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ##X ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### X## ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii - 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ##X ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### X## ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ##X ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii + 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ##X ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii + 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### X## ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ##X ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### X## ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii - 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ##X ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### X## ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ##X ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### X## ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ##X ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii - 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### X## ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ##X ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### X## ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii + 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### #X#
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii + 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### #X#
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            //seriously, nothing wrong here
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion()); //thats right, you thought this was a useful comment, but no IT WAS ME, ZOIDBERG
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii - 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### #X#
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //#X# ### ###

                            //fine, i wont change anything this time, or will i >:)
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii + 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i, ii - 1, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ##X
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii + 2, iii + 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ##X
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //X## ### ###

                            //ok this is getting confusing even for me now, im just going to go back to swapping your + and - around O_o
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //X## ### ###

                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii - 2, iii - 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ##X
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii - 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //X## ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ##X
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii - 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //X## ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii + 2, iii - 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### X##
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii - 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //##X ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### X##
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii + 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //##X ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii + 2, iii - 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ##X
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii + 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //X## ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ##X
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //X## ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii - 2, iii - 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### X##
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii + 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //##X ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### X##
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii + 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //##X ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii - 2, iii - 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### X##

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii - 2, iii + 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### X##

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //##X ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii - 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //##X ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii + 1, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii + 2, iii - 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ##X

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii - 2, iii + 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ##X

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //X## ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii - 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //X## ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii + 1, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii + 2, iii - 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ##X
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //O## ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 2, ii, iii - 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ##O
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //O## ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i - 1, ii, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii + 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ##O
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //X## ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii, iii + 2, iiii + 2)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii + 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### X##
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //##O ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii, iii - 2, iiii - 2)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### O##
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //##O ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii, iii - 2, iiii - 2)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### O##
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //##X ### ###
                            //### ### ###
                            if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 2, ii, iii - 2, iiii - 2)))
                            {
                                if (GameManager.gameManager.Crosses.Contains(new Vector4(i + 1, ii, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //AHA, THATS RIGHT I COPY AND PASTED YOUR CODE TO MAKE YOUR SCRIPT 2 TIMES LONGER AND EXTREMELY INNEFIECIENT AHAHAAHHAHAA
                            //...
                            //...
                            //[uh sir, they needed to do that anyway]
                            //...
                            //...
                            //*random evil commenter has left the chat*

                            //XOO
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //OXO
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //OOX
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //O##
                            //O##
                            //X##
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 2, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //O##
                            //X##
                            //O##
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //X##
                            //O##
                            //O##
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 2, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }


                            //##O
                            //#O#
                            //X##
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii + 2, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //##O
                            //#X#
                            //O##
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //##X
                            //#O#
                            //O##
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii - 2, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //X##
                            //#O#
                            //##O
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii - 2, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //O##
                            //#X#
                            //##O
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //O##
                            //#O#
                            //##X
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //#X# #O# #O#
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii + 2, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii + 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //#O# #X# #O#
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }


                            //### ### ###
                            //#O# #O# #X#
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii - 2, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //X## #O# ##O
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii + 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //O## #X# ##O
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //O## #O# ##X
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii, iii - 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //##X #O# O##
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii, iii + 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //##O #X# O##
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii + 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //##O #O# X##
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii - 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### #O#
                            //### #O# ###
                            //#X# ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 2, iii + 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### #O#
                            //### #X# ###
                            //#O# ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### #X#
                            //### #O# ###
                            //#O# ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 2, iii - 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //#X# ### ###
                            //### #O# ###
                            //### ### #O#
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 2, iii + 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //#O# ### ###
                            //### #X# ###
                            //### ### #O#
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii + 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //#O# ### ###
                            //### #O# ###
                            //### ### #X#
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii - 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 2, iii - 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ##O
                            //### #O# ###
                            //X## ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii + 2, iii + 2, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ##O
                            //### #X# ###
                            //O## ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ##X
                            //### #O# ###
                            //O## ### ###

                            // >:)
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii - 2, iii - 2, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //#O# ### ###
                            //### ### ###

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            //### ### ###
                            //#O# ### ###
                            //### ### ###

                            //thats right, i swapped the + and - on this one AND THERES NOTHING YOU CAN DO ABOUT IT >:D
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //#O# ### ###
                            //### ### ###

                            //### ### ###
                            //#O# ### ###
                            //### ### ###

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            //ok im sory for swapping the + and - around, to make up for it I SWAPPED AROUND THE 1 AND 2 >:D
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii + 2)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //*insert evil luaghter here*

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            //### ### ###
                            //#O# ### ###
                            //### ### ###

                            //### ### ###
                            //#O# ### ###
                            //### ### ###

                            //alright nothing wrong this time, nothing to worry about here
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii - 2)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion()); //thats right, you thought this was a useful comment, but no IT WAS ME, DIO
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### #O# ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### #X# ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### #O# ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### #O# ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### #X# ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### #O# ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### #O# ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### #X# ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### #O# ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### #O# ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### #X# ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### #O# ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ##X ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### O## ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ##O ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### O## ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ##O ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### X## ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ##X ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### O## ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ##O ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### O## ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ##O ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### X## ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii - 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ##X ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### O## ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ##O ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### O## ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ##O ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### X## ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ##X ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### O## ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii - 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ##O ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### O## ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ##O ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### X## ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii + 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### X## ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ##O ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii + 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### O## ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ##O ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### O## ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ##X ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii - 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### X## ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ##O ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### O## ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ##O ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### O## ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ##X ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### X## ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ##O ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii - 2, iii, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### O## ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ##O ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### O## ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ##X ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### #O#
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //#X# ### ###
                            //### ### ###

                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii + 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### #O#
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //#O# ### ###
                            //### ### ###

                            //seriously, nothing wrong here
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion()); //thats right, you thought this was a useful comment, but no IT WAS ME, ZOIDBERG
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### #X#
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //#O# ### ###
                            //### ### ###

                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii - 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### #O#
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //#O# ### ###

                            //fine, i wont change anything this time, or will i >:)
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ##O
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //X## ### ###

                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii + 2, iii + 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ##O
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //O## ### ###

                            //ok this is getting confusing even for me now, im just going to go back to swapping your + and - around O_o
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ##X
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //O## ### ###

                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii - 2, iii - 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //X## ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ##O
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii - 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //O## ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ##O
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii - 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //O## ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### ##X
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii - 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //##X ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### O##
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii - 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //##O ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### O##
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii + 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //##O ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### X##
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii + 2, iii - 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //X## ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ##O
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii + 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //O## ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ##O
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //O## ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ##X
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii - 2, iii - 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //##X ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### O##
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //##O ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### O##
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii + 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //##O ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### X##
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii - 2, iii - 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //move these up soon to organise the script (yeah this is a messs i am so sorry to anyone reading this and to myself)

                            //### ### ###
                            //### ### ###
                            //### ### O##

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //##X ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii - 2, iii + 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### O##

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //##O ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### X##

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //##O ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii + 2, iii - 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ##O

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //X## ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii - 2, iii + 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ##O

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //O## ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ###
                            //### ### ##X

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //O## ### ###
                            //### ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii - 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ##X
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //O## ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii, iii - 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ##O
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //O## ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii - 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii + 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### ##O
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //X## ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii + 2, iiii + 2)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii + 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### X##
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //##O ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii - 2, iiii - 2)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### O##
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //##O ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //### ### O##
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //##X ### ###
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii, iii + 2, iiii + 2)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii + 1, iiii + 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //X## ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ##O
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii + 2, iiii - 2)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii + 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //O## ### ###
                            //### ### ###

                            //### ### ###
                            //### #X# ###
                            //### ### ###

                            //### ### ###
                            //### ### ##O
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii - 2, iiii - 2)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### ###
                            //O## ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ##X
                            //### ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii - 2, iiii - 2)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).cross = Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        FindGridNodeAtPosition(new Vector4(i, ii, iii, iiii)).occupied = true;
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //#O# ### ###
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //### ### #X#
                        }
                    }
                }
            }
            Vector4 pos = new(Random.Range(0, (int)GameManager.gameManager.GameArea.x), Random.Range(0, (int)GameManager.gameManager.GameArea.y), Random.Range(0, (int)GameManager.gameManager.GameArea.z), Random.Range(0, (int)GameManager.gameManager.GameArea.w));
            if (!GameManager.gameManager.Noughts.Contains(pos) && !GameManager.gameManager.Crosses.Contains(pos) && !GameManager.gameManager.Unplayable.Contains(pos))
            {
                FindGridNodeAtPosition(pos).cross = Instantiate(GridGenerator.Cross, new Vector2(pos.x - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (pos.z - (GameManager.gameManager.GameArea.z - 1) / 2)), pos.y - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (pos.w - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                GameManager.gameManager.Crosses.Add(pos);
                GridNode.turn = false;
            }

        }
            GameManager.gameManager.EndTurn();
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
//X#O
//XX#<X
//O##<X win either way >:O
//(i rage quit because i was forced into losing by myself, man i suck at noughts and crosses :<  )

//ok future jordan here, im now realising i could've just copy and pasted the GameManagers code and it would've worked relatively the same with way less lines of code :(
//ok future future jordan here, im now realising i couldnt of copy and pasted the GameManager because thats even more broken than this :(
//ok future future future jordan here, im now realising i have fixed the game manager and i could still of swapped the enemy AI around to use this method, but that would take too long :(
//ok future future future future jordan here, im now realising i AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH (this whole script doesnt work with different line lengths)
//ok future future future future future jordan here, i came back after a while and i forgot everything please send help
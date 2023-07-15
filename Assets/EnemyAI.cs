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
                            //OXO
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //#O#
                            //#X#
                            //#O#
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii + 1, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii - 1, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //XOO
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii, iii, iiii)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii, iii, iiii)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion()); //thats right, you thought this was a useful comment, but no IT WAS ME, DIO
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion()); //thats right, you thought this was a useful comment, but no IT WAS ME, ZOIDBERG
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii - 1, iii - 1, iiii - 1)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii - 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii + 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii + 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### O##
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //##X ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii + 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii - 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii - 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 1, ii - 1, iii + 1, iiii - 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i + 2, ii - 2, iii + 2, iiii - 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }

                            //### ### X##
                            //### ### ###
                            //### ### ###

                            //### ### ###
                            //### #O# ###
                            //### ### ###

                            //### ### ###
                            //### ### ###
                            //##O ### ###
                            if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 1, ii + 1, iii + 1, iiii + 1)))
                            {
                                if (GameManager.gameManager.Noughts.Contains(new Vector4(i - 2, ii + 2, iii + 2, iiii + 2)))
                                {
                                    if (!GameManager.gameManager.Crosses.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Unplayable.Contains(new Vector4(i, ii, iii, iiii)) && !GameManager.gameManager.Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                                    {
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
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
                                        Instantiate(GridGenerator.Cross, new Vector2(i - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (iii - (GameManager.gameManager.GameArea.z - 1) / 2)), ii - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (iiii - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                                        GameManager.gameManager.Crosses.Add(new Vector4(i, ii, iii, iiii));
                                        GridNode.turn = false;
                                        goto EndTurn;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Vector4 pos = new(Random.Range(0, (int)GameManager.gameManager.GameArea.x), Random.Range(0, (int)GameManager.gameManager.GameArea.y), Random.Range(0, (int)GameManager.gameManager.GameArea.z), Random.Range(0, (int)GameManager.gameManager.GameArea.w));
            if (!GameManager.gameManager.Noughts.Contains(pos) && !GameManager.gameManager.Crosses.Contains(pos) && !GameManager.gameManager.Unplayable.Contains(pos))
            {
                Instantiate(GridGenerator.Cross, new Vector2(pos.x - GameManager.gameManager.GameArea.x / 2 + 0.5f + ((GameManager.gameManager.GameArea.x + 1) * (pos.z - (GameManager.gameManager.GameArea.z - 1) / 2)), pos.y - GameManager.gameManager.GameArea.y / 2 + 0.5f + (GameManager.gameManager.GameArea.y + 1) * (pos.w - (GameManager.gameManager.GameArea.w - 1) / 2)), new Quaternion());
                GameManager.gameManager.Crosses.Add(pos);
                GridNode.turn = false;
            }
        }
    }
}
//X#O
//XX#<X
//O##<X win either way >:O
//(i rage quit because i was forced into losing by myself, man i suck at noughts and crosses :< )
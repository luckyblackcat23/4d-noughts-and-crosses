using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector4 GameArea;
    public List<Vector4> Noughts, Crosses, Unplayable, Temp, Point;
    public int WinLength;
    public static GameManager gameManager;
    public int NoughtPoints, CrossesPoints;
    public int TempNoughtPoints, TempCrossesPoints;
    public int PlayerHealth, EnemyHealth;

    private void Awake()
    {
        gameManager = this;
        StartTurn();
    }

    void StartTurn()
    {
        //let both players play

        //check if both players have played
        EndTurn();
    }

    private int LineLengthNoughts;
    private int LineLengthCrosses;
    public void EndTurn()
    {
        NoughtPoints = 0;
        CrossesPoints = 0;

        #region diagonal win
        #region 2d Diagonal
        //check for diagonal win
        for (int iii = 0; iii < GameArea.w; iii++)
        {
            for (int i = 0; i < GameArea.z; i++)
            {
                for (int offset = 0; offset < GameArea.x; offset++)
                {
                    for (int ii = 0; ii < GameArea.x - offset; ii++)
                    {
                        if (ii < GameArea.y)
                        {
                            if (Noughts.Contains(new Vector4(ii + offset, ii, i, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(ii + offset, ii, i, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii < GameArea.y - offset; ii++)
                    {
                        if (ii < GameArea.x)
                        {
                            if (Noughts.Contains(new Vector4(ii, ii + offset, i, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(ii, ii + offset, i, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                //opposite diagonals
                for (int offset = 0; offset < GameArea.x; offset++)
                {
                    for (int ii = 0; ii < GameArea.x - offset; ii++)
                    {
                        if (ii < GameArea.y)
                        {
                            if (Noughts.Contains(new Vector4(GameArea.x - (ii + offset), ii, i, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(GameArea.x - (ii + offset), ii, i, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii <= GameArea.y - offset; ii++)
                    {
                        if (ii <= GameArea.x)
                        {
                            if (Noughts.Contains(new Vector4(ii, GameArea.y - (ii + offset), i, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(ii, GameArea.y - (ii + offset), i, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            }
        }

        //new thingy
        for (int iii = 0; iii < GameArea.w; iii++)
        {
            for (int i = 0; i < GameArea.y; i++)
            {
                for (int offset = 0; offset < GameArea.z; offset++)
                {
                    for (int ii = 0; ii < GameArea.z - offset; ii++)
                    {
                        if (ii < GameArea.x)
                        {
                            if (Noughts.Contains(new Vector4(ii, i, ii + offset, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(ii, i, ii + offset, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            
                for (int offset = 1; offset < GameArea.x; offset++)
                {
                    for (int ii = 0; ii < GameArea.x - offset; ii++)
                    {
                        if (ii < GameArea.z)
                        {
                            if (Noughts.Contains(new Vector4(ii + offset, i, ii, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(ii + offset, i, ii, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                //opposite diagonals
                for (int offset = 0; offset < GameArea.z; offset++)
                {
                    for (int ii = 0; ii < GameArea.z - offset; ii++)
                    {
                        if (ii < GameArea.x)
                        {
                            if (Noughts.Contains(new Vector4(ii, i, GameArea.z - (ii + offset), iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(ii, i, GameArea.z - (ii + offset), iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii <= GameArea.y - offset; ii++)
                    {
                        if (ii <= GameArea.x)
                        {
                            if (Noughts.Contains(new Vector4(GameArea.x - (ii + offset), i, ii, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(GameArea.x - (ii + offset), i, ii, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            }
        }

        //new thing 2: electric boogaloo

        for (int iii = 0; iii < GameArea.z; iii++)
        {
            for (int i = 0; i < GameArea.y; i++)
            {
                for (int offset = 0; offset < GameArea.w; offset++)
                {
                    for (int ii = 0; ii < GameArea.w - offset; ii++)
                    {
                        if (ii < GameArea.x)
                        {
                            if (Noughts.Contains(new Vector4(ii, i, iii, ii + offset)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(ii, i, iii, ii + offset)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.x; offset++)
                {
                    for (int ii = 0; ii < GameArea.x - offset; ii++)
                    {
                        if (ii < GameArea.w)
                        {
                            if (Noughts.Contains(new Vector4(ii + offset, i, iii, ii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(ii + offset, i, iii, ii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                //opposite diagonals
                for (int offset = 0; offset < GameArea.w; offset++)
                {
                    for (int ii = 0; ii < GameArea.w - offset; ii++)
                    {
                        if (ii < GameArea.x)
                        {
                            if (Noughts.Contains(new Vector4(ii, i, iii, GameArea.w - (ii + offset))))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(ii, i, iii, GameArea.w - (ii + offset))))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.x; offset++)
                {
                    for (int ii = 0; ii <= GameArea.x - offset; ii++)
                    {
                        if (ii <= GameArea.w)
                        {
                            if (Noughts.Contains(new Vector4(GameArea.x - (ii + offset), i, iii, ii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(GameArea.x - (ii + offset), i, ii, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            }
        }

        //new thing 3: return of the thing

        for (int iii = 0; iii < GameArea.w; iii++)
        {
            for (int i = 0; i < GameArea.x; i++)
            {
                for (int offset = 0; offset < GameArea.z; offset++)
                {
                    for (int ii = 0; ii < GameArea.z - offset; ii++)
                    {
                        if (ii < GameArea.y)
                        {
                            if (Noughts.Contains(new Vector4(i, ii, ii + offset, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, ii, ii + offset, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii < GameArea.y - offset; ii++)
                    {
                        if (ii < GameArea.z)
                        {
                            if (Noughts.Contains(new Vector4(i, ii + offset, ii, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, ii + offset, ii, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                //opposite diagonals
                for (int offset = 0; offset < GameArea.z; offset++)
                {
                    for (int ii = 0; ii < GameArea.z - offset; ii++)
                    {
                        if (ii < GameArea.y)
                        {
                            if (Noughts.Contains(new Vector4(i, ii, GameArea.z - (ii + offset), iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, ii, GameArea.z - (ii + offset), iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii <= GameArea.y - offset; ii++)
                    {
                        if (ii <= GameArea.z)
                        {
                            if (Noughts.Contains(new Vector4(i, GameArea.y - (ii + offset), ii, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, GameArea.y - (ii + offset), ii, iii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            }
        }

        //new thing 4: thing strikes back

        for (int iii = 0; iii < GameArea.z; iii++)
        {
            for (int i = 0; i < GameArea.x; i++)
            {
                for (int offset = 0; offset < GameArea.w; offset++)
                {
                    for (int ii = 0; ii < GameArea.w - offset; ii++)
                    {
                        if (ii < GameArea.y)
                        {
                            if (Noughts.Contains(new Vector4(i, ii, iii, ii + offset)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, ii, iii, ii + offset)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii < GameArea.y - offset; ii++)
                    {
                        if (ii < GameArea.w)
                        {
                            if (Noughts.Contains(new Vector4(i, ii + offset, iii, ii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, ii + offset, iii, ii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                //opposite diagonals
                for (int offset = 0; offset < GameArea.w; offset++)
                {
                    for (int ii = 0; ii < GameArea.w - offset; ii++)
                    {
                        if (ii < GameArea.y)
                        {
                            if (Noughts.Contains(new Vector4(i, ii, iii, GameArea.w - (ii + offset))))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, ii, iii, GameArea.w - (ii + offset))))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii <= GameArea.y - offset; ii++)
                    {
                        if (ii <= GameArea.w)
                        {
                            if (Noughts.Contains(new Vector4(i, GameArea.y - (ii + offset), iii, ii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, GameArea.y - (ii + offset), iii, ii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            }
        }

        //new thing 5: neon genesis

        for (int iii = 0; iii < GameArea.y; iii++)
        {
            for (int i = 0; i < GameArea.x; i++)
            {
                for (int offset = 0; offset < GameArea.w; offset++)
                {
                    for (int ii = 0; ii < GameArea.w - offset; ii++)
                    {
                        if (ii < GameArea.z)
                        {
                            if (Noughts.Contains(new Vector4(i, iii, ii, ii + offset)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, iii, ii, ii + offset)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii < GameArea.y - offset; ii++)
                    {
                        if (ii < GameArea.w)
                        {
                            if (Noughts.Contains(new Vector4(i, iii, ii + offset, ii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, iii, ii + offset, ii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                //opposite diagonals
                for (int offset = 0; offset < GameArea.w; offset++)
                {
                    for (int ii = 0; ii < GameArea.w - offset; ii++)
                    {
                        if (ii < GameArea.y)
                        {
                            if (Noughts.Contains(new Vector4(i, iii, ii, GameArea.w - (ii + offset))))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, iii, ii, GameArea.w - (ii + offset))))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii <= GameArea.y - offset; ii++)
                    {
                        if (ii <= GameArea.w)
                        {
                            if (Noughts.Contains(new Vector4(i, iii, GameArea.z - (ii + offset), ii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(i, iii, GameArea.z - (ii + offset), ii)))
                            {
                                LineLengthCrosses++;
                                if (LineLengthCrosses >= WinLength)
                                    CrossesPoints++;
                            }
                            else
                                LineLengthCrosses = 0;
                        }
                        else
                            break;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            }
        }
        #endregion
        #region 3d Diagonal
        for (int iiii = 0; iiii < GameArea.w; iiii++)
        {
            //3d diagonal win
            for (int offset = 0; offset < GameArea.x; offset++)
            {
                for (int ii = 0; ii < GameArea.x - offset; ii++)
                {
                    if (ii < GameArea.y && ii < GameArea.z)
                    {
                        if (Noughts.Contains(new Vector4(ii + offset, ii, ii, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii + offset, ii, ii, iiii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 1; offset < GameArea.y; offset++)
            {
                for (int ii = 0; ii < GameArea.y - offset; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.z)
                    {
                        if (Noughts.Contains(new Vector4(ii, ii + offset, ii, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, ii + offset, ii, iiii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 1; offset < GameArea.z; offset++)
            {
                for (int ii = 0; ii < GameArea.z - offset; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.y)
                    {
                        if (Noughts.Contains(new Vector4(ii, ii, ii + offset, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, ii, ii + offset, iiii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            //check for opposite diagonals
            for (int offset = 0; offset < GameArea.x; offset++)
            {
                for (int ii = 0; ii < GameArea.x - offset; ii++)
                {
                    if (ii < GameArea.y && ii < GameArea.z)
                    {
                        if (Noughts.Contains(new Vector4(GameArea.x - 1 -(ii + offset), ii, ii, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(GameArea.x - 1 -(ii + offset), ii, ii, iiii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }
            
            for (int offset = 0; offset < GameArea.y; offset++)
            {
                for (int ii = 0; ii < GameArea.y - offset; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.z)
                    {
                        if (Noughts.Contains(new Vector4(ii, GameArea.y - 1 - (ii + offset), ii, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, GameArea.y - 1 - (ii + offset), ii, iiii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 0; offset < GameArea.z; offset++)
            {
                for (int ii = 0; ii < GameArea.z - offset; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.y)
                    {
                        if (Noughts.Contains(new Vector4(ii, ii, GameArea.z - 1 - (ii + offset), iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, ii, GameArea.z - 1 - (ii + offset), iiii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }
        }

        //new thingy 3d

        for (int iii = 0; iii < GameArea.z; iii++)
        {
            //3d diagonal win
            for (int offset = 0; offset < GameArea.x; offset++)
            {
                for (int ii = 0; ii < GameArea.x - offset; ii++)
                {
                    if (ii < GameArea.y && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(ii + offset, ii, iii, ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii + offset, ii, iii, ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 1; offset < GameArea.y; offset++)
            {
                for (int ii = 0; ii < GameArea.y - offset; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(ii, ii + offset, iii, ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, ii + offset, iii, ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 1; offset < GameArea.w; offset++)
            {
                for (int ii = 0; ii < GameArea.w - offset; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.y)
                    {
                        if (Noughts.Contains(new Vector4(ii, ii, iii, ii + offset)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, ii, iii, ii + offset)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            //check for opposite diagonals
            for (int offset = 0; offset < GameArea.x; offset++)
            {
                for (int ii = 0; ii < GameArea.x - offset; ii++)
                {
                    if (ii < GameArea.y && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(GameArea.x - 1 - (ii + offset), ii, iii, ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(GameArea.x - 1 - (ii + offset), ii, iii, ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 0; offset < GameArea.y; offset++)
            {
                for (int ii = 0; ii < GameArea.y - offset; ii++)
                {
                    if (ii <= GameArea.x && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(ii, GameArea.y - 1 - (ii + offset), iii, ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, GameArea.y - 1 - (ii + offset), iii, ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 0; offset < GameArea.w; offset++)
            {
                for (int ii = 0; ii < GameArea.w - offset; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.y)
                    {
                        if (Noughts.Contains(new Vector4(ii, ii, iii, GameArea.w - 1 - (ii + offset))))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, ii, iii, GameArea.w - 1 - (ii + offset))))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }
        }

        //new thingy 3d 2: the epilouge

        for (int iii = 0; iii < GameArea.y; iii++)
        {
            //3d diagonal win
            for (int offset = 0; offset < GameArea.x; offset++)
            {
                for (int ii = 0; ii < GameArea.x - offset; ii++)
                {
                    if (ii < GameArea.z && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(ii + offset, iii, ii, ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii + offset, iii, ii, ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 1; offset < GameArea.z; offset++)
            {
                for (int ii = 0; ii < GameArea.z - offset; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(ii, iii, ii + offset, ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, iii, ii + offset, ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 1; offset < GameArea.w; offset++)
            {
                for (int ii = 0; ii < GameArea.w - offset; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.z)
                    {
                        if (Noughts.Contains(new Vector4(ii, iii, ii, ii + offset)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, iii, ii, ii + offset)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            //check for opposite diagonals
            for (int offset = 0; offset < GameArea.x; offset++)
            {
                for (int ii = 0; ii < GameArea.x - offset; ii++)
                {
                    if (ii < GameArea.z && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(GameArea.x - 1 - (ii + offset), iii, ii, ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(GameArea.x - 1 - (ii + offset), iii, ii, ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 0; offset < GameArea.z; offset++)
            {
                for (int ii = 0; ii < GameArea.z - offset; ii++)
                {
                    if (ii <= GameArea.x && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(ii, iii, GameArea.z - 1 - (ii + offset), ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, iii, GameArea.z - 1 - (ii + offset), ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 0; offset < GameArea.w; offset++)
            {
                for (int ii = 0; ii < GameArea.w - offset; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.z)
                    {
                        if (Noughts.Contains(new Vector4(ii, iii, ii, GameArea.w - 1 - (ii + offset))))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, iii, ii, GameArea.w - 1 - (ii + offset))))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }
        }

        //new thingy 3d 3: the epilouge: the epilouge

        for (int iii = 0; iii < GameArea.x; iii++)
        {
            //3d diagonal win
            for (int offset = 0; offset < GameArea.y; offset++)
            {
                for (int ii = 0; ii < GameArea.y - offset; ii++)
                {
                    if (ii < GameArea.z && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(iii, ii + offset, ii, ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(iii, ii + offset, ii, ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 1; offset < GameArea.z; offset++)
            {
                for (int ii = 0; ii < GameArea.z - offset; ii++)
                {
                    if (ii < GameArea.y && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(iii, ii, ii + offset, ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(iii, ii, ii + offset, ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 1; offset < GameArea.w; offset++)
            {
                for (int ii = 0; ii < GameArea.w - offset; ii++)
                {
                    if (ii < GameArea.y && ii < GameArea.z)
                    {
                        if (Noughts.Contains(new Vector4(iii, ii, ii, ii + offset)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(iii, ii, ii, ii + offset)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            //check for opposite diagonals
            for (int offset = 0; offset < GameArea.y; offset++)
            {
                for (int ii = 0; ii < GameArea.y - offset; ii++)
                {
                    if (ii < GameArea.z && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(iii, GameArea.y - 1 - (ii + offset), ii, ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(iii, GameArea.y - 1 - (ii + offset), ii, ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 0; offset < GameArea.z; offset++)
            {
                for (int ii = 0; ii < GameArea.z - offset; ii++)
                {
                    if (ii <= GameArea.y && ii < GameArea.w)
                    {
                        if (Noughts.Contains(new Vector4(iii, ii, GameArea.z - 1 - (ii + offset), ii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(iii, ii, GameArea.z - 1 - (ii + offset), ii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }

            for (int offset = 0; offset < GameArea.w; offset++)
            {
                for (int ii = 0; ii < GameArea.w - offset; ii++)
                {
                    if (ii < GameArea.y && ii < GameArea.z)
                    {
                        if (Noughts.Contains(new Vector4(iii, ii, ii, GameArea.w - 1 - (ii + offset))))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(iii, ii, ii, GameArea.w - 1 - (ii + offset))))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                                CrossesPoints++;
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    else
                        break;
                }
                LineLengthNoughts = 0;
                LineLengthCrosses = 0;
            }
        }
        #endregion
        #region 4d Diagonal
        for (int offset = 0; offset < GameArea.x; offset++)
        {
            for (int ii = 0; ii < GameArea.x - offset; ii++)
            {
                if (ii < GameArea.y && ii < GameArea.z && ii < GameArea.w)
                {
                    if (Noughts.Contains(new Vector4(ii + offset, ii, ii, ii)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(ii + offset, ii, ii, ii)))
                    {
                        LineLengthCrosses++;
                        if (LineLengthCrosses >= WinLength)
                            CrossesPoints++;
                    }
                    else
                        LineLengthCrosses = 0;
                }
                else
                    break;
            }
            LineLengthNoughts = 0;
            LineLengthCrosses = 0;
        }

        for (int offset = 1; offset < GameArea.y; offset++)
        {
            for (int ii = 0; ii < GameArea.y - offset; ii++)
            {
                if (ii < GameArea.x && ii < GameArea.z && ii < GameArea.w)
                {
                    if (Noughts.Contains(new Vector4(ii, ii + offset, ii, ii)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(ii, ii + offset, ii, ii)))
                    {
                        LineLengthCrosses++;
                        if (LineLengthCrosses >= WinLength)
                            CrossesPoints++;
                    }
                    else
                        LineLengthCrosses = 0;
                }
                else
                    break;
            }
            LineLengthNoughts = 0;
            LineLengthCrosses = 0;
        }

        for (int offset = 1; offset < GameArea.z; offset++)
        {
            for (int ii = 0; ii < GameArea.z - offset; ii++)
            {
                if (ii < GameArea.x && ii < GameArea.y && ii < GameArea.w)
                {
                    if (Noughts.Contains(new Vector4(ii, ii, ii + offset, ii)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(ii, ii, ii + offset, ii)))
                    {
                        LineLengthCrosses++;
                        if (LineLengthCrosses >= WinLength)
                            CrossesPoints++;
                    }
                    else
                        LineLengthCrosses = 0;
                }
                else
                    break;
            }
            LineLengthNoughts = 0;
            LineLengthCrosses = 0;
        }

        for (int offset = 1; offset < GameArea.w; offset++)
        {
            for (int ii = 0; ii < GameArea.w - offset; ii++)
            {
                if (ii < GameArea.x && ii < GameArea.y && ii < GameArea.z)
                {
                    if (Noughts.Contains(new Vector4(ii, ii, ii, ii + offset)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(ii, ii, ii, ii + offset)))
                    {
                        LineLengthCrosses++;
                        if (LineLengthCrosses >= WinLength)
                            CrossesPoints++;
                    }
                    else
                        LineLengthCrosses = 0;
                }
                else
                    break;
            }
            LineLengthNoughts = 0;
            LineLengthCrosses = 0;
        }

        //opposite diagonals
        for (int offset = 0; offset < GameArea.x; offset++)
        {
            for (int ii = 0; ii < GameArea.x - offset; ii++)
            {
                if (ii < GameArea.y && ii < GameArea.z && ii < GameArea.w)
                {
                    if (Noughts.Contains(new Vector4(GameArea.x - 1 - (ii + offset), ii, ii, ii)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(GameArea.x - 1 - (ii + offset), ii, ii, ii)))
                    {
                        LineLengthCrosses++;
                        if (LineLengthCrosses >= WinLength)
                            CrossesPoints++;
                    }
                    else
                        LineLengthCrosses = 0;
                }
                else
                    break;
            }
            LineLengthNoughts = 0;
            LineLengthCrosses = 0;
        }

        for (int offset = 0; offset < GameArea.y; offset++)
        {
            for (int ii = 0; ii < GameArea.y - offset; ii++)
            {
                if (ii < GameArea.x && ii < GameArea.z && ii < GameArea.w)
                {
                    if (Noughts.Contains(new Vector4(ii, GameArea.y - 1 - (ii + offset), ii, ii)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(ii, GameArea.y - 1 - (ii + offset), ii, ii)))
                    {
                        LineLengthCrosses++;
                        if (LineLengthCrosses >= WinLength)
                            CrossesPoints++;
                    }
                    else
                        LineLengthCrosses = 0;
                }
                else
                    break;
            }
            LineLengthNoughts = 0;
            LineLengthCrosses = 0;
        }

        for (int offset = 0; offset < GameArea.z; offset++)
        {
            for (int ii = 0; ii < GameArea.z - offset; ii++)
            {
                if (ii < GameArea.x && ii < GameArea.y && ii < GameArea.w)
                {
                    if (Noughts.Contains(new Vector4(ii, ii, GameArea.z - 1 - (ii + offset), ii)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(ii, ii, GameArea.z - 1 - (ii + offset), ii)))
                    {
                        LineLengthCrosses++;
                        if (LineLengthCrosses >= WinLength)
                            CrossesPoints++;
                    }
                    else
                        LineLengthCrosses = 0;
                }
                else
                    break;
            }
            LineLengthNoughts = 0;
            LineLengthCrosses = 0;
        }

        for (int offset = 0; offset < GameArea.w; offset++)
        {
            for (int ii = 0; ii < GameArea.w - offset; ii++)
            {
                if (ii < GameArea.x && ii < GameArea.y && ii < GameArea.z)
                {
                    if (Noughts.Contains(new Vector4(ii, ii, ii, GameArea.w - 1 - (ii + offset))))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(ii, ii, ii, GameArea.w - 1 - (ii + offset))))
                    {
                        LineLengthCrosses++;
                        if (LineLengthCrosses >= WinLength)
                            CrossesPoints++;
                    }
                    else
                        LineLengthCrosses = 0;
                }
                else
                    break;
            }
            LineLengthNoughts = 0;
            LineLengthCrosses = 0;
        }
        #endregion
        #endregion
        //check for x win
        for (int iiii = 0; iiii < GameArea.w; iiii++)
        {
            for (int iii = 0; iii < GameArea.z; iii++)
            {
                for (int ii = 0; ii < GameArea.y; ii++)
                {
                    for (int i = 0; i < GameArea.x; i++)
                    {
                        if (Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                            {
                                NoughtPoints++;
                                LineLengthNoughts = 0;
                            }
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(i, ii, iii, iiii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                            {
                                CrossesPoints++;
                                LineLengthCrosses = 0;
                            }
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            }
        }

        //check for y win
        for (int iiii = 0; iiii < GameArea.w; iiii++)
        {
            for (int iii = 0; iii < GameArea.z; iii++)
            {
                for (int i = 0; i < GameArea.x; i++)
                {
                    for (int ii = 0; ii < GameArea.y; ii++)
                    {
                        if (Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                            {
                                NoughtPoints++;
                                LineLengthNoughts = 0;
                            }
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(i, ii, iii, iiii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                            {
                                CrossesPoints++;
                                LineLengthCrosses = 0;
                            }
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            }
        }
        //check for z win
        for (int iiii = 0; iiii < GameArea.w; iiii++)
        {
            for (int i = 0; i < GameArea.x; i++)
            {
                for (int ii = 0; ii < GameArea.y; ii++)
                {
                    for (int iii = 0; iii < GameArea.z; iii++)
                    {
                        if (Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                            {
                                NoughtPoints++;
                                LineLengthNoughts = 0;
                            }
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(i, ii, iii, iiii)))
                        {
                            LineLengthCrosses++;
                            if (LineLengthCrosses >= WinLength)
                            {
                                CrossesPoints++;
                                LineLengthCrosses = 0;
                            }
                        }
                        else
                            LineLengthCrosses = 0;
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            }
        }
        
        //check for w win
        for (int i = 0; i < GameArea.x; i++)
        {
            for (int ii = 0; ii < GameArea.y; ii++)
            {
                for (int iii = 0; iii < GameArea.z; iii++)
                {
                    for (int iiii = 0; iiii < GameArea.w; iiii++)
                    {
                        if (Noughts.Contains(new Vector4(i, ii, iii, iiii)))
                        {
                            LineLengthNoughts++;
                            Temp.Add(new Vector4(i, ii, iii, iiii));
                            if (LineLengthNoughts >= WinLength)
                            {
                                NoughtPoints++;
                                LineLengthNoughts = 0;
                            }
                        }
                        else
                        {
                            LineLengthNoughts = 0;
                            Temp.Clear();
                        }

                        if (Crosses.Contains(new Vector4(i, ii, iii, iiii)))
                        {
                            LineLengthCrosses++;
                            Temp.Add(new Vector4(i, ii, iii, iiii));
                            if (LineLengthCrosses >= WinLength)
                            {
                                CrossesPoints++;
                                LineLengthCrosses = 0;
                                //make all temp positions red (or any other colour if necessary)
                            }
                        }
                        else
                        {
                            LineLengthCrosses = 0;
                            Temp.Clear();
                        }
                    }
                    LineLengthNoughts = 0;
                    LineLengthCrosses = 0;
                }
            }
        }
        

        if (TempNoughtPoints > NoughtPoints)
        {
            //enemy has taken damage, show tiles that did damage as feedback for the player
            foreach(Vector4 tile in Point)
            {
                foreach(GridNode gridNode in GameObject.FindObjectsOfType<GridNode>())
                {
                    if(gridNode.pos == tile)
                    {
                        //change the colour of the tile in the gridnode to signify that, that tile was what produced a point
                    }
                }
            }
        }

        if (TempCrossesPoints < CrossesPoints)
        {
            //player has taken damage, show tiles that did damage as feedback for the player
            foreach(Vector4 tile in Point)
            {
                foreach(GridNode gridNode in GameObject.FindObjectsOfType<GridNode>())
                {
                    if(gridNode.pos == tile)
                    {
                        //change the colour of the tile in the gridnode to signify that, that tile was what produced a point
                    }
                }
            }
        }

        if (TempNoughtPoints < NoughtPoints)
            EnemyHealth -= NoughtPoints - TempNoughtPoints;
        if (TempCrossesPoints < CrossesPoints)
            PlayerHealth -= CrossesPoints - TempCrossesPoints;
        
        TempNoughtPoints = NoughtPoints;
        TempCrossesPoints = CrossesPoints;
    }
}
//AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
//^each H represents 1 strand of hair i lost from writing this script^

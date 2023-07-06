using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Vector4 GameArea;
    public static List<Vector4> Noughts, Crosses, temp;
    public static int WinLength = 3;
    public int NoughtPoints, CrossesPoints;

    private void Start()
    {
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
    void EndTurn()
    {
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
                    for (int ii = 0; ii < GameArea.x; ii++)
                    {
                        if (ii < GameArea.y)
                        {
                            if (Noughts.Contains(new Vector4(GameArea.x + (ii + offset) * -1, ii, i, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(GameArea.x + (ii + offset) * -1, ii, i, iii)))
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
                    for (int ii = 0; ii <= GameArea.y; ii++)
                    {
                        if (ii <= GameArea.x)
                        {
                            if (Noughts.Contains(new Vector4(ii, GameArea.y + (ii + offset) * -1, i, iii)))
                            {
                                LineLengthNoughts++;
                                if (LineLengthNoughts >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLengthNoughts = 0;

                            if (Crosses.Contains(new Vector4(ii, GameArea.y + (ii + offset) * -1, i, iii)))
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
            for (int offset = 1; offset < GameArea.x; offset++)
            {
                for (int ii = 0; ii < GameArea.x; ii++)
                {
                    if (ii < GameArea.y && ii < GameArea.z)
                    {
                        if (Noughts.Contains(new Vector4(GameArea.x + (ii + offset) * -1, ii, ii, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(GameArea.x + (ii + offset) * -1, ii, ii, iiii)))
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
                for (int ii = 0; ii < GameArea.y; ii++)
                {
                    if (ii <= GameArea.x && ii < GameArea.z)
                    {
                        if (Noughts.Contains(new Vector4(ii, GameArea.y + (ii + offset) * -1, ii, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, GameArea.y + (ii + offset) * -1, ii, iiii)))
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
                for (int ii = 0; ii < GameArea.z; ii++)
                {
                    if (ii < GameArea.x && ii < GameArea.y)
                    {
                        if (Noughts.Contains(new Vector4(ii, ii, GameArea.z + (ii + offset) * -1, iiii)))
                        {
                            LineLengthNoughts++;
                            if (LineLengthNoughts >= WinLength)
                                NoughtPoints++;
                        }
                        else
                            LineLengthNoughts = 0;

                        if (Crosses.Contains(new Vector4(ii, ii, GameArea.z + (ii + offset) * -1, iiii)))
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
        for (int offset = 1; offset < GameArea.x; offset++)
        {
            for (int ii = 0; ii < GameArea.x; ii++)
            {
                if (ii < GameArea.y && ii < GameArea.z && ii < GameArea.w)
                {
                    if (Noughts.Contains(new Vector4(GameArea.x + (ii + offset) * -1, ii, ii, ii)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(GameArea.x + (ii + offset) * -1, ii, ii, ii)))
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
            for (int ii = 0; ii < GameArea.y; ii++)
            {
                if (ii < GameArea.x && ii < GameArea.z && ii < GameArea.w)
                {
                    if (Noughts.Contains(new Vector4(ii, GameArea.y + (ii + offset) * -1, ii, ii)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(ii, GameArea.y + (ii + offset) * -1, ii, ii)))
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
            for (int ii = 0; ii < GameArea.y; ii++)
            {
                if (ii < GameArea.x && ii < GameArea.y && ii < GameArea.w)
                {
                    if (Noughts.Contains(new Vector4(ii, ii, GameArea.z + (ii + offset) * -1, ii)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(ii, ii, GameArea.z + (ii + offset) * -1, ii)))
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
            for (int ii = 0; ii < GameArea.y; ii++)
            {
                if (ii < GameArea.x && ii < GameArea.y && ii < GameArea.z)
                {
                    if (Noughts.Contains(new Vector4(ii, ii, ii, GameArea.w + (ii + offset) * -1)))
                    {
                        LineLengthNoughts++;
                        if (LineLengthNoughts >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLengthNoughts = 0;

                    if (Crosses.Contains(new Vector4(ii, ii, ii, GameArea.w + (ii + offset) * -1)))
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
    }
}
//AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
//^each H represents 1 strand of hair i lost from writing this script^
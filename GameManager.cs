using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector4 GameArea;
    public List<Vector4> Noughts, Crosses;
    public int WinLength;
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

    private int LineLength;
    void EndTurn()
    {
        #region diagonal win
        #region 2d digonal
        //check for diagonal win
        for (int iii = 0; iii < GameArea.w; iii++)
        {
            for (int i = 0; i < GameArea.z; i++)
            {
                for (int offset = 0; offset < GameArea.x; offset++)
                {
                    for (int ii = 0; ii < GameArea.x - offset; ii++)
                    {
                        if (ii <= GameArea.y)
                        {
                            if (Noughts.Contains(new Vector4(ii + offset, ii, i, iii)))
                            {
                                LineLength++;
                                if (LineLength >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLength = 0;
                        }
                        else
                            break;
                    }
                    LineLength = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii < GameArea.y - offset; ii++)
                    {
                        if (ii <= GameArea.x)
                        {
                            if (Noughts.Contains(new Vector4(ii, ii + offset, i, iii)))
                            {
                                LineLength++;
                                if (LineLength >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLength = 0;
                        }
                        else
                            break;
                    }
                    LineLength = 0;
                }

                //opposite diagonals
                for (int offset = 0; offset < GameArea.x; offset++)
                {
                    for (int ii = 0; ii < GameArea.x; ii++)
                    {
                        if (ii <= GameArea.y)
                        {
                            if (Noughts.Contains(new Vector4(GameArea.x - 1 + (ii + offset) * -1, ii, i, iii)))
                            {
                                LineLength++;
                                Debug.Log(string.Format("x: {0} y: {1} Length: {2}", ii, GameArea.y - 1 + (ii + offset) * -1, LineLength));
                                if (LineLength >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLength = 0;
                        }
                        else
                            break;
                    }
                    LineLength = 0;
                }

                for (int offset = 1; offset < GameArea.y; offset++)
                {
                    for (int ii = 0; ii < GameArea.y; ii++)
                    {
                        if (ii <= GameArea.x)
                        {
                            if (Noughts.Contains(new Vector4(ii, GameArea.y - 1 + (ii + offset) * -1, i, iii)))
                            {
                                LineLength++;
                                Debug.Log(string.Format("x: {0} y: {1} Length: {2}", ii, GameArea.y - 1 + (ii + offset) * -1, LineLength));
                                if (LineLength >= WinLength)
                                    NoughtPoints++;
                            }
                            else
                                LineLength = 0;
                        }
                        else
                            break;
                    }
                    LineLength = 0;
                }
            }
        }
        #endregion
        //3d diagonal win
        for (int offset = 1; offset < GameArea.x; offset++)
        {
            for (int ii = 0; ii < GameArea.x - offset; ii++)
            {
                if (ii <= GameArea.y && ii <= GameArea.z)
                {
                    if (Noughts.Contains(new Vector4(ii + offset, ii, ii)))
                    {
                        LineLength++;
                        if (LineLength >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLength = 0;
                }
                else
                    break;
            }
            LineLength = 0;
        }

        for (int offset = 1; offset < GameArea.y; offset++)
        {
            for (int ii = 0; ii < GameArea.y - offset; ii++)
            {
                if (ii <= GameArea.x && ii <= GameArea.z)
                {
                    if (Noughts.Contains(new Vector4(ii, ii + offset, ii)))
                    {
                        LineLength++;
                        if (LineLength >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLength = 0;
                }
                else
                    break;
            }
            LineLength = 0;
        }

        for (int offset = 0; offset < GameArea.z; offset++)
        {
            for (int ii = 0; ii < GameArea.z - offset; ii++)
            {
                if (ii <= GameArea.x && ii <= GameArea.y)
                {
                    if (Noughts.Contains(new Vector4(ii, ii, ii + offset)))
                    {
                        LineLength++;
                        Debug.Log(string.Format("x: {0} y: {1} z: {2} Length: {3}", ii, ii, ii + offset, LineLength));
                        if (LineLength >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLength = 0;
                }
                else
                    break;
            }
            LineLength = 0;
        }

        //check for opposite diagonals
        for (float offset = GameArea.x - 1; offset < 0; offset--)
        {
            for (float ii = GameArea.x; ii < 0 + offset; ii--)
            {
                if (ii < GameArea.y && ii < GameArea.z)
                {
                    if (Noughts.Contains(new Vector4(ii + offset, ii, ii)))
                    {
                        LineLength++;
                        if (LineLength >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLength = 0;
                }
                else
                    break;
            }
            LineLength = 0;
        }

        for (float offset = GameArea.y - 1; offset < 0; offset--)
        {
            for (float ii = GameArea.y; ii < 0 + offset; ii--)
            {
                if (ii < GameArea.x && ii < GameArea.z)
                {
                    if (Noughts.Contains(new Vector4(ii, ii + offset, ii)))
                    {
                        LineLength++;
                        if (LineLength >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLength = 0;
                }
                else
                    break;
            }
            LineLength = 0;
        }

        for (float offset = GameArea.z; offset < 0; offset--)
        {
            for (float ii = GameArea.z; ii < 0 + offset; ii--)
            {
                Debug.Log(offset + " " + ii);
                if (ii < GameArea.x && ii < GameArea.y)
                {
                    if (Noughts.Contains(new Vector4(ii, ii, ii + offset)))
                    {
                        LineLength++;
                        if (LineLength >= WinLength)
                            NoughtPoints++;
                    }
                    else
                        LineLength = 0;
                }
                else
                    break;
            }
            LineLength = 0;
        }
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
                            LineLength++;
                            if (LineLength >= WinLength)
                            {
                                NoughtPoints++;
                                Debug.Log(LineLength);
                                LineLength = 0;
                            }
                        }
                        else
                            LineLength = 0;
                    }
                    LineLength = 0;
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
                            LineLength++;
                            if (LineLength >= WinLength)
                            {
                                NoughtPoints++;
                                Debug.Log(LineLength);
                                LineLength = 0;
                            }
                        }
                        else
                            LineLength = 0;
                    }
                    LineLength = 0;
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
                            LineLength++;
                            if (LineLength >= WinLength)
                            {
                                NoughtPoints++;
                                Debug.Log(LineLength);
                                LineLength = 0;
                            }
                        }
                        else
                            LineLength = 0;
                    }
                    LineLength = 0;
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
                            LineLength++;
                            if (LineLength >= WinLength)
                            {
                                NoughtPoints++;
                                Debug.Log(LineLength);
                                LineLength = 0;
                            }
                        }
                        else
                            LineLength = 0;
                    }
                    LineLength = 0;
                }
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public variables
    public GameObject gameModel;
    public float value;
    public Vector3 sizeChange;

    // Move Left Function
    public void MoveLeft()
    {
        value = value - 0.1f;
        gameModel.transform.position = new Vector3(value, 0, 0);
    }

    // Move Right Function
    public void MoveRight()
    {
        value = value + 0.1f;
        gameModel.transform.position = new Vector3(value, 0, 0);
    }

    // Grow Function
    public void Grow()
    {
        gameModel.transform.localScale = gameModel.transform.localScale + sizeChange;
    }



}

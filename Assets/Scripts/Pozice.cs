using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pozice : MonoBehaviour
{
    private Vector3 Position;

    void Start()
    {
        Position = transform.position;
    }

    public void ResetToDefaultPosition()
    {
        transform.position = Position;
    }
}

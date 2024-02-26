using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    public float speed = 0.001f;
    void Update()
    {
        Vector2 move = new Vector2(speed, 0);
        gameObject.transform.Translate(move);
    }
}

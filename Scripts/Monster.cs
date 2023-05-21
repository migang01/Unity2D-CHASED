using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        if (!GameManager.isCanvasOn)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
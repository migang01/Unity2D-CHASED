using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float timer = 0;
    public float maxTime = 2;


    private void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        Destroy(this.gameObject, 10f);
    }
}
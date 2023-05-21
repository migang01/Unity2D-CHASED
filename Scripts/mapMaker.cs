using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapMaker : MonoBehaviour
{
    public GameObject BG;
    private int count = 1;
    private int start = 0;
    public static int scoreCount = 0;

    private void Update()
    {
        if (count > start)
        {
            // When the player collides collider in the middle of the map object
            if (Player.isEnter == true)
            {
                GameObject newBG = Instantiate(BG, transform.position, Quaternion.identity);
                Player.isEnter = false;
                start = 1;
                scoreCount++;
            }
        }
    }
}
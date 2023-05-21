using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    // (O, X, X), (X, O, X) ....
    public GameObject[] enemy;
    public float timer = 0;
    public float maxTime = 5;

    private void Update()
    {
        if (GameManager.isCanvasOn == false)
        {
            if (timer > maxTime)
            {
                if (warningSpawn.ran == 0)
                {
                    if (timer > maxTime)
                    {
                        GameObject enemySet = Instantiate(enemy[0], transform.position, Quaternion.identity);

                        timer = 0;
                    }
                    timer += Time.deltaTime;

                }

                else if (warningSpawn.ran == 1)
                {
                    if (timer > maxTime)
                    {
                        GameObject enemySet = Instantiate(enemy[1], transform.position, Quaternion.identity);

                        timer = 0;
                    }
                    timer += Time.deltaTime;
                }

                else if (warningSpawn.ran == 2)
                {
                    if (timer > maxTime)
                    {
                        GameObject enemySet = Instantiate(enemy[2], transform.position, Quaternion.identity);

                        timer = 0;
                    }
                    timer += Time.deltaTime;
                }

                else if (warningSpawn.ran == 3)
                {
                    if (timer > maxTime)
                    {
                        GameObject enemySet = Instantiate(enemy[3], transform.position, Quaternion.identity);

                        timer = 0;
                    }
                    timer += Time.deltaTime;
                }

                else if (warningSpawn.ran == 4)
                {
                    if (timer > maxTime)
                    {
                        GameObject enemySet = Instantiate(enemy[4], transform.position, Quaternion.identity);

                        timer = 0;
                    }
                    timer += Time.deltaTime;
                }

                else if (warningSpawn.ran == 5)
                {
                    if (timer > maxTime)
                    {
                        GameObject enemySet = Instantiate(enemy[5], transform.position, Quaternion.identity);

                        timer = 0;
                    }
                    timer += Time.deltaTime;
                }

                else if (warningSpawn.ran == 6)
                {
                    if (timer > maxTime)
                    {
                        GameObject enemySet = Instantiate(enemy[6], transform.position, Quaternion.identity);

                        timer = 0;
                    }
                    timer += Time.deltaTime;
                }


                timer = 0;
            }
            timer += Time.deltaTime;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warningSpawn : MonoBehaviour
{
    public static int ran;
    public GameObject[] warning;
    public float timer = 0;
    public float maxTime = 5;
    public float start = 0;
    public float count = 5;

    public float closeStart = 0;
    public float closeCount = 3;

    private void Start()
    {
        warning[0].SetActive(false);
        warning[1].SetActive(false);
        warning[2].SetActive(false);
    }

    private void Update()
    {
        if (start > count)
        {
            ran = Random.Range(0, 7);

            start = 0;
        }
        start += Time.deltaTime;



        if (GameManager.isCanvasOn == false)
        {

            if (ran == 0)
            {
                if (timer > maxTime)
                {
                    Audio.WarningSoundPlay();
                    warning[0].SetActive(true);
                    warning[1].SetActive(false);
                    warning[2].SetActive(false);
                    timer = 0;

                }

                timer += Time.deltaTime;


            }

            else if (ran == 1)
            {
                if (timer > maxTime)
                {
                    Audio.WarningSoundPlay();
                    warning[0].SetActive(false);
                    warning[1].SetActive(true);
                    warning[2].SetActive(false);
                    timer = 0;
                }
                timer += Time.deltaTime;

            }

            else if (ran == 2)
            {

                if (timer > maxTime)
                {
                    Audio.WarningSoundPlay();
                    warning[0].SetActive(false);
                    warning[1].SetActive(false);
                    warning[2].SetActive(true);

                    timer = 0;
                }
                timer += Time.deltaTime;

            }

            else if (ran == 3)
            {
                if (timer > maxTime)
                {
                    Audio.WarningSoundPlay();
                    warning[0].SetActive(true);
                    warning[1].SetActive(true);
                    warning[2].SetActive(false);

                    timer = 0;
                }
                timer += Time.deltaTime;

            }

            else if (ran == 4)
            {

                if (timer > maxTime)
                {
                    Audio.WarningSoundPlay();
                    warning[0].SetActive(true);
                    warning[1].SetActive(false);
                    warning[2].SetActive(true);

                    timer = 0;
                }
                timer += Time.deltaTime;

            }

            else if (ran == 5)
            {
                if (timer > maxTime)
                {
                    Audio.WarningSoundPlay();
                    warning[0].SetActive(false);
                    warning[1].SetActive(true);
                    warning[2].SetActive(true);

                    timer = 0;
                }
                timer += Time.deltaTime;

            }

            else if (ran == 6)
            {
                if (timer > maxTime)
                {
                    Audio.WarningSoundPlay();
                    warning[0].SetActive(true);
                    warning[1].SetActive(true);
                    warning[2].SetActive(true);

                    timer = 0;
                }
                timer += Time.deltaTime;

            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    const float ORIGIN_SPEED = 3;

    public static float globalSpeed;
    public static float score;
    public static bool isLive;

    void Start()
    {
        isLive = true;
    }
    void Update()
    {
        if (isLive)
        {
            score += Time.deltaTime * 2;
            globalSpeed = ORIGIN_SPEED + score * 0.01f;
        }
    }
}

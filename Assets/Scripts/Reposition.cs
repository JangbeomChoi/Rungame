using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    void LateUpdate() //��ó�� �뵵
    {
        if (transform.position.x > -10)
            return;

        transform.Translate(24,0,0, Space.Self); 
    }
}

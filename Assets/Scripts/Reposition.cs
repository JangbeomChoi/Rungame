using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Reposition : MonoBehaviour
{
    public UnityEvent onMove;
    void LateUpdate() //후처리 용도
    {
        if (transform.position.x > -10)
            return;

        transform.Translate(24,0,0, Space.Self); 
        onMove.Invoke();
    }
}

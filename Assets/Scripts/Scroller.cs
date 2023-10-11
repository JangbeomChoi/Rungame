
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public int count;
    public float speedRate;

    
    void Start()
    {
        count = transform.childCount;
    }
    
    void Update()
    {
        if (GameManager.isLive)
        {
            float totalSpeed = GameManager.globalSpeed * speedRate * Time.deltaTime * -1f;
            transform.Translate(totalSpeed, 0, 0);
        }
    }
}

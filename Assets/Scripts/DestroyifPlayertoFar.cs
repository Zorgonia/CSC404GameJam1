using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyifPlayertoFar : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(player.transform.position, transform.position);
        Debug.Log(dis);
        if (dis > 1000f)
        {
            Destroy(gameObject);
        }
            
    }
}

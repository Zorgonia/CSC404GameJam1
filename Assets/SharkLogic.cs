using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkLogic : MonoBehaviour
{
    private float moveSpeed = 1.0f;
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTransform);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, step);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Game over");
        }
    }

}

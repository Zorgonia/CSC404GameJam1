using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject section;
    public Transform player; 
    
    public int zPos;

    public bool createSection = false;

    // Update is called once per frame
    void Update()
    {
        if (createSection is false)
        {
            if (player.position.x % 350f / 350f > 0.5 || player.position.z % 350f / 350f > 0.5)
            {
                createSection = true;
                Debug.Log("there");
                StartCoroutine(GenerateSection());
            }
        }
    }

    IEnumerator GenerateSection()
    {
        Instantiate(section, new Vector3(player.position.x, 0, player.position.z), Quaternion.identity);
        yield return new WaitForSeconds(5);
        createSection = false;
    }
}

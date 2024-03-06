using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3 (0, 5, -7);
    private Vector3 offset2 = new Vector3(0.00f, 2.58f, 1.00f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
     
       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (offset != offset2)
            {
                offset = offset2;
            }
            else
            {
                offset = new Vector3(0, 5, -7);
            }
        }
    }
}

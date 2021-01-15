using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*---------Objects Destroy--------*/
        //The object will be destroyed after the "Player" passes through it!
        float z = transform.position.z + 8;
        float playerZ = GameObject.Find("Player").transform.position.z;
        if (playerZ > z) {
            //Destroy
            Destroy(gameObject);
        }
        /*---------Objects Destroy--------*/    
    }
}
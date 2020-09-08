using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winBlock : MonoBehaviour
{

    public CameraScript cam;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.transform.name == "Player")
        {

            Debug.Log("You win!");
            Destroy(other.gameObject);
            cam.isMoving = false;
            cam.win();

        }

    }
}

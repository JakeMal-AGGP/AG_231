using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathBlock : MonoBehaviour
{

    public CameraScript cam;

    // Start is called before the first frame update
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

            Destroy(other.gameObject);
            cam.isMoving = false;
            cam.lose();
            Debug.Log("Game over");

        }

    }

}

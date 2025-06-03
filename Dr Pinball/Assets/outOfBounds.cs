using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    public GameManager gm;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            GameObject.Destroy(other);
        }
        

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

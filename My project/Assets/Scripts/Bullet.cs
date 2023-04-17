using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
         rb.velocity = new Vector3(speed, 0, 0);
    }

    void OnTriggerEnter(Collider hitInfo) {
        Debug.Log("Cambio le pegaste");
        Destroy(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

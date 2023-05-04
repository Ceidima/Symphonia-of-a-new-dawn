using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody rb;
    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
         rb.velocity = new Vector3(speed, 0, 0);
    }

    void OnTriggerEnter(Collider hitInfo) {
        Enemy enemy= hitInfo.GetComponent<Enemy>();
        enemy.TakeDamage(damage);
        Debug.Log("Cambio le pegaste");
        Instantiate(impactEffect,transform.position, transform.rotation);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

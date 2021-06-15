using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    private Rigidbody2D rig;
    private BoxCollider2D box;
    public float enemyVelocity;
    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }
    void FixedUpdate()
    {
        rig.velocity = Vector2.left * enemyVelocity;
    }
   void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.gameObject.transform.CompareTag("DestroyObstacles"))
        {
          Destroy(this.gameObject);
        }
         if(other.collider.gameObject.transform.CompareTag("Player"))
        {
          
        }
        }
    
}

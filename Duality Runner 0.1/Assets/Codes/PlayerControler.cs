using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rb;
    public bool isGround;
    public GameObject gameOverUI;
    public bool gameIsPaused = false;
    //public GameObject al;
    public Transform groundPivot;
    public float radius;
    public LayerMask layer;
    private SpriteRenderer sprite;
    private BoxCollider2D box;
    public float bufferTime;
    private float bufferCount = 0.01f;
    public float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();   
        sprite = GetComponentInChildren<SpriteRenderer>();
        gameIsPaused = false;
        isGround = false;
        //al.SetActive(true);
        bufferCount = -1f;
    }

    void Start()
    {
      int i = Random.Range(1,4);
      if(i == 1){FindObjectOfType<AudioManager>().Play("Theme1");}
      if(i == 2){FindObjectOfType<AudioManager>().Play("Theme2");}
      if(i == 3){FindObjectOfType<AudioManager>().Play("Theme3");}
     
    }
    void Update()
    {
       
      Pause();
       
    }
     void FixedUpdate() {
       Jump();
       Move();
    }
    void Jump()
    {
      
      //Pequeno princípe
      if(Input.GetButtonUp("Jump") && rb.velocity.y > 0f){
          
          rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * .5f);
        }

      //Bust no pulo errado do player, kappa
      if(Input.GetButtonDown("Jump"))
      {
        bufferCount = bufferTime;
      }
      else{
        bufferCount -= Time.deltaTime;
      }

        if(bufferCount >= 0f && isGround == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            FindObjectOfType<AudioManager>().Play("Jump");
            bufferCount = 0f;
        } 
        isGround = Physics2D.OverlapCircle(groundPivot.position, radius, layer);
    }
     void OnCollisionEnter2D(Collision2D other) {
       
        if(other.collider.transform.gameObject.CompareTag("Enemy"))
        {
          FindObjectOfType<AudioManager>().Play("EnemyHit"); 
          bufferCount = -1f;
          sprite.color = Color.black;
          gameOverUI.SetActive(true);
          //al.SetActive(false);
          gameIsPaused = true;
        }
    }
    void Pause()
    {
        if(gameIsPaused)
        {
          Time.timeScale = 0f;
        } 
        else
        {
          Time.timeScale = 1f;
        }
    }
    void Move()
    {
      rb.velocity = new Vector2(speed , rb.velocity.y);
    }
}

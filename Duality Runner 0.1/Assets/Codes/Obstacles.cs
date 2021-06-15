using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float maxTime;
    float timer;
    public GameObject firstEnemy;
    public GameObject secondEnemy;
    public GameObject thirdEnemy;
    int chooseObstacle;

    void Start()
    {
       maxTime = 2.7f;
    }
    void FixedUpdate()
    {
        if(maxTime > 2.0f)
        {
            maxTime -= .0000001f;
        }
        else{
            if(maxTime > 1.0)
            {
                
                maxTime -= .0000050f;
            }        
            Debug.Log(maxTime);
        }
    }

    
    void Update()
    {
         timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            GenerateObstacle();
            timer = 0;
            
        }
        
    }
    void GenerateObstacle()
    {
       chooseObstacle = Random.Range(1, 4);
       if(chooseObstacle == 1) {GameObject newObstacle = Instantiate(firstEnemy, new Vector3(transform.position.x, 0.242f, 0), Quaternion.identity);}
       if(chooseObstacle == 2) {GameObject newObstacle = Instantiate(secondEnemy, new Vector3(transform.position.x, 0.276f, 0), Quaternion.identity);}
       if(chooseObstacle == 3) {GameObject newObstacle = Instantiate(thirdEnemy, new Vector3(transform.position.x, 0.191f, 0), Quaternion.identity);}
    }
}

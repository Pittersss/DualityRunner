using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchAndSquash : MonoBehaviour
{
    private PlayerControler player;
    private bool hasLanded;
    private float inAirTime;
    void Start()
    {
        player = GetComponentInParent<PlayerControler>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            StartCoroutine(JumpStretchEffect());
        }
        
        CheckIfLanded();
        if(hasLanded){
          StartCoroutine(SquashLandEffect());
          hasLanded = false;
          }
        CheckAirTime();
        
      
      
    }
    IEnumerator JumpStretchEffect()
    {
      transform.localScale += new Vector3(-.2f,.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(-.2f,.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(-.2f,.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(-.2f,.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(-.2f,.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(-.2f,.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(-.2f,.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(-.2f,.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(-.2f,.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale = new Vector3(50f, 25f, 50f);

      
    }
    IEnumerator SquashLandEffect(){
      transform.localScale += new Vector3(.2f,-.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(.2f,-.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(.2f,-.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(.2f,-.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(.2f,-.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(.2f,-.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(.2f,-.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(.2f,-.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale += new Vector3(.2f,-.2f,0f);
      yield return new WaitForSeconds(0.015f);

      transform.localScale = new Vector3(50f, 25f, 50f);
    }
    public void CheckIfLanded(){
     if(inAirTime > 0f)
     {
      if(player.isGround)
      {
        hasLanded = true;
      }
     }
    }
    public void CheckAirTime(){
      if(player.isGround){

        inAirTime = 0f;
      }
      else{

        inAirTime += Time.deltaTime;
      }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    public GameObject[] backGround;
    public float adicionalScrollSpeed;
    public float[] scrollSpeed;
      private void FixedUpdate() {
         for(int background = 0; background < backGround.Length; background++)
         {
             Renderer rend = backGround[background].GetComponent<Renderer>();
             float offset = Time.time * (scrollSpeed[background] + adicionalScrollSpeed);
             rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
         }
     }
}
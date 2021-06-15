using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverCode : MonoBehaviour
{
    public void Restart()
    {
      SceneManager.LoadScene("Scene1");
    }
    public void Exit()
   {
     Application.Quit();
   }
}

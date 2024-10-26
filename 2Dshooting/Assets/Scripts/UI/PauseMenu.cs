using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   public static bool GameIsPaused = false;
   public GameObject puaseMenuUI;

   void Update()
   {
      if(Input.GetKeyDown(KeyCode.Escape))
      {
         if(GameIsPaused)
         {
            Resume();
         }
         else
         {
            Pause();
         }
      }
   }
   public void Resume()
   {
      puaseMenuUI.SetActive(false);
      Time.timeScale = 1f;
      GameIsPaused = false;
   }
   void Pause()
   {
      puaseMenuUI.SetActive(true);
      Time.timeScale = 0f;
      GameIsPaused = true;

   }

   public void Home()
    {
        SceneManager.LoadSceneAsync(0);
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

   public void Restart()
   {
   if (SceneManager.GetActiveScene().buildIndex == 2)
      {
         // Load the Game scene (scene index 1) to restart from Game Over
         SceneManager.LoadScene(1);
      }
      else
      {
         // Restart the current scene (Game scene)
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }
}
}



  


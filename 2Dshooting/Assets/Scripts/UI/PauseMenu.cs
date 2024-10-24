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
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Time.timeScale = 1f;
      GameIsPaused = false;
   }

  
}

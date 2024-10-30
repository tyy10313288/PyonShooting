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
    /*public void Restart()
{
   // 確保遊戲的時間速度設定為正常
   Time.timeScale = 1f;

   // 檢查當前場景索引
   int sceneIndex = SceneManager.GetActiveScene().buildIndex;

   // 如果是 Game Over 场景 (假設為索引 2)，則加載 Game 场景 (假設為索引 1)
   if (sceneIndex == 2)
   {
      SceneManager.LoadScene(1);
   }
   else
   {
      // 重新加載當前場景
      SceneManager.LoadScene(sceneIndex);
   }

   // 確保遊戲暫停狀態被重置
   GameIsPaused = false;
}*/

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



  


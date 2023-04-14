using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButton : MonoBehaviour
{
   public void RestartGame()
   {
      SceneManager.LoadScene("Scenes/Game");
   }

   public void GoHome()
   {
      SceneManager.LoadScene("Menu");
   }
}

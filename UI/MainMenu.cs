using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame ()
   {
       SceneManager.LoadScene("BeginnerField");
   }

   public void QuitGame ()
   {
      Debug.Log ("You Can't Quit HAHA!");
      Application.Quit();
   }
}

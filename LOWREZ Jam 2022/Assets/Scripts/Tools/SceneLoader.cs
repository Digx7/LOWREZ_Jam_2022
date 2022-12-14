using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  public void LoadScene(string name){
    SceneManager.LoadScene(name);
  }

  public void ReloadScene(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void Quit(){
    Application.Quit();
    #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
    #endif
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneload : MonoBehaviour
{
    public string SceneToLoad;
   public void SceneLoader()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}

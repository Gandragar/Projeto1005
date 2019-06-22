using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void SceneLoarder(int SceneIndex)
    {
      SceneManager.LoadScene (SceneIndex);
    }
}

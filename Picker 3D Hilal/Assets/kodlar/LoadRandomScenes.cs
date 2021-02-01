using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadRandomScenes : MonoBehaviour
{
    public void LoadRandomScene()
    {
        int index = Random.Range(1, 10);
        SceneManager.LoadScene(index);
        Debug.Log("Scene Loaded");
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

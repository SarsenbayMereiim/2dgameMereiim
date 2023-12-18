using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOADMANAGER : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    private void OnEnable()
    {
        SceneManager.sceneLoaded += SceneManagerSceneLoaded;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= SceneManagerSceneLoaded;
    }
    private void SceneManagerSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Debug.Log(arg0);
    }
    public void loadGame()
    {
        SceneManager.LoadScene(1);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

  
    
    public void LoadScene(int index)
    {

        SceneManager.LoadScene(index);
        Time.timeScale=1;
        
    }
}

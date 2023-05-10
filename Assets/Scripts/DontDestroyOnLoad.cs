using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour
{

    public int score = 1000;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        SceneManager.LoadScene("DontDestroyOnLoad");
    }

    
}

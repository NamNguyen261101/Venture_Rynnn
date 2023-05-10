using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDontDestroyOnLoad : MonoBehaviour
{
    

    void Start()
    {
        var load = GameObject.FindObjectOfType<DontDestroyOnLoad>();
        
        Debug.Log("score " + load.score);

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

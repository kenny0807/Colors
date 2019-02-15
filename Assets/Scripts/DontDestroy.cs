using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("Audio").Length == 2)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    
}

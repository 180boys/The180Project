using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoMenu : MonoBehaviour
{
    public float AutoTimer = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AutoTimer -= Time.deltaTime;

        if (AutoTimer <= 0)
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }
}

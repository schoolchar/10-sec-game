using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winReset : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("newScene", 2f);
        audioSource.Play();
    }

    // Update is called once per frame
    private void newScene()
    {
        SceneManager.LoadScene(0);
    }
}

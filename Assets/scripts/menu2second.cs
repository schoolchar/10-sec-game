using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu2second : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
        Invoke("newScene", 2f);
    }

    // Update is called once per frame
    private void newScene()
    {
        SceneManager.LoadScene(2);
    }
}

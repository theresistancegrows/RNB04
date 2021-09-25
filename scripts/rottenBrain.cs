using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rottenBrain : MonoBehaviour
{
    [SerializeField] GameObject Brain;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    void OnMouseDown(){
        audioSource.clip = audioClip;
        audioSource.Play();
        Invoke("destroy", 12);
    }

    void destroy() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

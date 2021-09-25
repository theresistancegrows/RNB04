using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnergyCellScript : MonoBehaviour
{

    private int count = 7;
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    [SerializeField] GameObject page;

    void Update() {
        if(count == 0) {
            meshRenderer.enabled = true;
        }
    }

    void OnMouseDown(){
        audioSource.clip = audioClip;
        audioSource.Play();
        page.SetActive(true);
        Invoke("nextLevel", 19);
    }

    void nextLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void decrement() {
        count -= 1;
    }
 
}

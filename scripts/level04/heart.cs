using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heart : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    void OnCollisionEnter (UnityEngine.Collision collision) {
          player.GetComponent<FirstPersonMovement>().enabled = false;
          Invoke("removeTables", 1);
   }

   void backToFirstMenu() {
       SceneManager.LoadScene(5);
   }

   void removeTables() {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("tables");
        foreach(GameObject go in gos) {
            Destroy(go);
        }
       Invoke("removeHallways", 2);
   }

   void removeHallways() {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("hallway");
        foreach(GameObject go in gos) {
            Destroy(go);
        }
       Invoke("removeEverything", 2);
   }


   void removeEverything() {
       GameObject[] gos = GameObject.FindGameObjectsWithTag("ground");
        foreach(GameObject go in gos) {
            Destroy(go);
        }
        audioSource.clip = audioClip;
        audioSource.Play();
        Invoke("backToFirstMenu", 12);
   }


}

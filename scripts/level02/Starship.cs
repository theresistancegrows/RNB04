using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starship : MonoBehaviour
{
    [SerializeField] AudioSource audioSource02;
    [SerializeField] AudioClip audioClip02;
    [SerializeField] GameObject starship01;

    void OnMouseDown(){
        audioSource02.clip = audioClip02;
        audioSource02.Play();
        starship01.transform.position = new Vector3(-12, -10, 3);
    }
}

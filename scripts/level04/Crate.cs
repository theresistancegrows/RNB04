using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    Animator m_Animator;
    [SerializeField] GameObject crateObj;
    [SerializeField] GameObject openCrateObj;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    private int count = 7;

    void Start()
    {
        openCrateObj.SetActive(false);
    }

    public void decrement()
    {
        count -= 1;
    }

    void Update()
    {
        if (count == 0)
        {
            openCrateObj.SetActive(true);
            audioSource.clip = audioClip;
            audioSource.Play();
            Destroy(crateObj);
        }
    }

}

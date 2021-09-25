using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class brainOne : MonoBehaviour
{
    [SerializeField] GameObject brain01;
    [SerializeField] GameObject page;
    [SerializeField] AudioSource audioSource01;
    [SerializeField] AudioClip audioClip01;
    [SerializeField] int delayTime;
    [SerializeField] string level;
    [SerializeField] GameObject energyCell;
    [SerializeField] GameObject crateObj;

    void OnMouseDown(){
        audioSource01.clip = audioClip01;
        audioSource01.volume = 1f;
        audioSource01.Play();
        page.SetActive(true);
        Invoke("destroy", delayTime);
    }

    void destroy() {
        Destroy(page);
        Destroy(brain01);
        if (level.Equals("level01") || level.Equals("level02")) {
        energyCell.GetComponent<EnergyCellScript>().decrement();
        }
        else {
        crateObj.GetComponent<Crate>().decrement();
        }
    }
}

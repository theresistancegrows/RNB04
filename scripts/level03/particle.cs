using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{

    [SerializeField] GameObject text;
    [SerializeField] GameObject guideline;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    [SerializeField] int delayTime;
    [SerializeField] MeshRenderer meshRenderer;

    void OnCollisionEnter (UnityEngine.Collision collision) {
        meshRenderer.enabled = true;
        audioSource.clip = audioClip;
        audioSource.Play();
        Invoke("Destroy", delayTime);
    }

    void Destroy() {
        Destroy(text);
        Destroy(guideline);
    }
}

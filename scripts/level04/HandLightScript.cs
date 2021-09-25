using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLightScript : MonoBehaviour
{
    [SerializeField] GameObject thisLight;
    [SerializeField] GameObject anotherLight;
    [SerializeField] GameObject deadEnd;

    void Start() {
        anotherLight.SetActive(false);
    }


    void OnMouseDown() {
        anotherLight.SetActive(true);
        Destroy(deadEnd);
        Destroy(thisLight);
    }
}

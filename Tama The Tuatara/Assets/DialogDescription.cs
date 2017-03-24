using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogDescription : MonoBehaviour {

    public string Title;
    public string[] Description;

    [HideInInspector]
    public int NumberOfSlides;


    void Start()
    {
        NumberOfSlides = Description.Length;
    }
}

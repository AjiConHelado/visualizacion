using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class movebodyagain : MonoBehaviour
{
    private Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = new Vector3(-2.925f, 0.92461f, 2.5892f);
    }

    // Update is called once per frame
   
    public void moveBack()
    {
        Debug.Log("Moving back...");
        transform.DOMove(originalPosition, 1f);
    }
}




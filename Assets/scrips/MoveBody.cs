using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveBody : MonoBehaviour
{
    private Vector3 originalPosition;
    private Vector3 position;
    
    void Start()
    {
       
        originalPosition = new Vector3(-2.925f, 0.92461f, 2.5892f);
        position = new Vector3(-5.55f, 0.92461f, 2.5892f);
    }

    public void move()
    {
        transform.DOMove(position, 1f);
        
    }
    public void moveBack()
    {
        Debug.Log("Moving back...");
        transform.DOMove(originalPosition, 1f);
    }
}

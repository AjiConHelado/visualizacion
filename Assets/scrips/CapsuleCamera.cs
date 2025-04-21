using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;
public class CapsuleCamera : MonoBehaviour
{
   
    
    [SerializeField] UnityEvent escenacapsula;

    void OnMouseDown()
    {
        
        escenacapsula.Invoke();
       
    }
    // Start is called before the first frame update
  
}

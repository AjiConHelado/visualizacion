using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public List<GameObject> activate = new List<GameObject>();
    public List<GameObject> deactivate = new List<GameObject>();

    public void ActivateAllGameObjects()
    {
        // Loop through each GameObject in the list
        foreach (GameObject obj in activate)
        {
            // Check if the GameObject is not null before deactivating
            if (obj != null)
            {
                // Deactivate the GameObject
                obj.SetActive(true);
            }
        }
    }
   

    public void DeactivateAllGameObjects()
    {
        // Loop through each GameObject in the list
        foreach (GameObject obj in deactivate)
        {
            // Check if the GameObject is not null before deactivating
            if (obj != null)
            {
                // Deactivate the GameObject
                obj.SetActive(false);
            }
        }
    }
}

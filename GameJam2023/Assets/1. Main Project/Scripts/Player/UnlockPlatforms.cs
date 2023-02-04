using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockPlatforms : MonoBehaviour
{
    
    public Transform camera;
    public LayerMask unlockGrappleable;
    public List<GameObject> LockedPlatforms = new List<GameObject>();


    void ActiveByRayCast()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.position, camera.forward, out hit, unlockGrappleable))
        {
            foreach (var platform in LockedPlatforms)
            {
                platform.layer = LayerMask.NameToLayer("Ground");
            }
        }
    }
}

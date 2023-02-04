using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUnlocker : MonoBehaviour
{
    // public static PlatformUnlocker instance;
    public GameObject[] platforms;
    
    public void UnlockPlatforms()
    {
        foreach (var platform in platforms)
        {
            platform.GetComponent<MeshRenderer>().enabled = true;
        }
    }

}

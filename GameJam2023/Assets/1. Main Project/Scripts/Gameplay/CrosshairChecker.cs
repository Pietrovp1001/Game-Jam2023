using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class CrosshairChecker : MonoBehaviour
{
    
    public Image crossHairChecker;
    
     private void OnTriggerEnter(Collider other)
     {
         if (LayerMask.LayerToName(other.gameObject.layer) == "Grap")
         {
             crossHairChecker.GetComponent<Image>().color = Color.green;
         }
     }

     private void OnTriggerExit(Collider other)
     {
         if (LayerMask.LayerToName(other.gameObject.layer) == "Grap")
         {
             crossHairChecker.GetComponent<Image>().color = Color.red;
         }
     }
}

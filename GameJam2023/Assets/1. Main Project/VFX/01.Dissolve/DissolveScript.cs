 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class DissolveScript : MonoBehaviour
 {
     [Header("Dissolve")]
     [SerializeField] private float dissolveSpeed = 1;
     [SerializeField] private float dissolveWait = 1;
     [Space] 
     [SerializeField] private bool useIndex;
     [SerializeField] private MeshRenderer dissolveMesh;
     [SerializeField] private int dissolveMeshIndex;
     
     
     [Header("References")] 
     [SerializeField]private Material dissolveMaterial;

     private bool isDissolving;

     private float dissolveValue;
     private float startValue = 0;
     private float endValue = 0;

     private int hashDissolve = Shader.PropertyToID("_DISSOLVE");

     private void Start()
     {
      if (useIndex)dissolveMaterial = dissolveMesh.materials[dissolveMeshIndex];
      
      dissolveMaterial.SetFloat(hashDissolve, startValue);
     }

     /*private void Update()
     {
      if (Input.GetKeyDown(KeyCode.Space) && !isDissolving)
      {
       StartCoroutine(MakeDissolve());
      }
     }*/

     private IEnumerator MakeDissolve()
     {
      isDissolving = true;

      dissolveValue = startValue;

      while (dissolveValue < 3)
      {
       dissolveValue += Time.deltaTime * dissolveSpeed;
       dissolveMaterial.SetFloat(hashDissolve, dissolveValue);
       yield return null;
      }
      
      isDissolving = false;
     }
     
 }

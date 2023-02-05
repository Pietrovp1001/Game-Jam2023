using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumPad : MonoBehaviour
{
   [Range(100, 100000)] public float bounceHight;
   public AudioSource audioSource;
   public AudioClip jumpSFX; 

   private void OnCollisionEnter(Collision collision)
   {
      
      Debug.Log("Collision");
      audioSource.PlayOneShot(jumpSFX);
      GameObject bouncer = collision.gameObject;
      Rigidbody rb = bouncer.GetComponent<Rigidbody>();
      rb.AddForce(Vector3.up * bounceHight);
   }
}

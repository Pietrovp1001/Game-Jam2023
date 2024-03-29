using System;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class GrapplinGun : MonoBehaviour {

    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrappleable, unlockGrappleable;
    public Transform gunTip, camera, player;
    private float maxDistance = 50f;
    private SpringJoint joint;
    public float maxCuerda = 0.8f;
    public float minCuerda = 0.25f;
    public float spring, damper, massScale;
    public Image crossHair;
    public GameObject meshObject;

    void Awake() {
        lr = GetComponent<LineRenderer>();
        
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            StartGrapple();
           
        }
        
        else if (Input.GetMouseButtonUp(0)) {
            StopGrapple();
        }
        
        if (IsGrappling()) {
            
            crossHair.GetComponent<Image>().color = Color.green;
        }
        else
        {
            crossHair.GetComponent<Image>().color = Color.red;
        }
    }

    //Called after Update
    void LateUpdate() {
        DrawRope();
    }

    /// <summary>
    /// Call whenever we want to start a grapple
    /// </summary>
    void StartGrapple() {
        RaycastHit hit;
        if (Physics.Raycast(camera.position, camera.forward, out hit, maxDistance, whatIsGrappleable)) {
            grapplePoint = hit.point;
            joint = player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplePoint;

            

            float distanceFromPoint = Vector3.Distance(player.position, grapplePoint);

            //The distance grapple will try to keep from grapple point. 
            joint.maxDistance = distanceFromPoint * maxCuerda;
            joint.minDistance = distanceFromPoint * minCuerda;
            
            
            
            joint.spring = spring;
            joint.damper = damper;
            joint.massScale = massScale;
            
            lr.positionCount = 2;
            currentGrapplePosition = gunTip.position;

            
            if (hit.transform.GetComponent<PlatformUnlocker>() != null)
            {
                hit.transform.GetComponent<PlatformUnlocker>().UnlockPlatforms();
                hit.transform.GetComponent<DissolveScript>().StartCoroutine("MakeDissolve");
            }
            
            
        }
    }
        
    

    void StopGrapple() {
        lr.positionCount = 0;
        Destroy(joint);
    }

    private Vector3 currentGrapplePosition;
    
    void DrawRope() {
        //If not grappling, don't draw rope
        if (!joint) return;

        currentGrapplePosition = Vector3.Lerp(currentGrapplePosition, grapplePoint, Time.deltaTime * 8f);
        
        lr.SetPosition(0, gunTip.position);
        lr.SetPosition(1, currentGrapplePosition);
    }
    
    public bool IsGrappling() {
        return joint != null;
    }

    public Vector3 GetGrapplePoint() {
        return grapplePoint;
    }
}
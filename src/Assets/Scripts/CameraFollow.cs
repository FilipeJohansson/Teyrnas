using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    //public float initialSmoothSpeed = 0.00001f;
    public float smoothSpeed; //0.125f
    public Vector3 offset;

    private bool isOnPlayerCheck;
    //private bool isOnPlayer = false;
    public Transform playerCheck;
    public float checkRadius;
    public LayerMask whatIsPLayer;
    public GameObject vmCam;

    void FixedUpdate() {

        Vector3 desiredPosition;
        Vector3 smoothedPosition;

        isOnPlayerCheck = Physics2D.OverlapCircle(playerCheck.position, checkRadius, whatIsPLayer);

        desiredPosition = target.position + offset;
        smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        if (isOnPlayerCheck) {
            //isOnPlayer = true;
            StartCoroutine(TimerRoutine());

        }

        /*if (!isOnPlayer) {

            desiredPosition = target.position + offset;
            smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, initialSmoothSpeed);
            transform.position = smoothedPosition;

        } else {

            desiredPosition = target.position + offset;
            smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

        }*/

    }

    IEnumerator TimerRoutine() {

        yield return new WaitForSeconds(1.5f);
        vmCam.SetActive(true);

    }

    private void OnDrawGizmosSelected() {
    
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(playerCheck.position, checkRadius);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, target.position);

        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(target.position, 1f);

    }

}

using Unity.XR.CoreUtils;
using UnityEngine;

public class LensDirection : MonoBehaviour
{
    public Transform viewTarget;
    public Transform mainCamera;
    public Transform mag;
    //private Quaternion prevRotation;

    void Update()
    {
        //transform.rotation = mag.rotation;
        //var temp = mainCamera;
        //temp.position = mainCamera.position.Inverse();
        //transform.rotation = transform.rotation * Quaternion.Inverse(prevRotation);

        //Quaternion deltaRot = transform.rotation * Quaternion.Inverse(prevRotation);
        //transform.localRotation = Quaternion.Inverse(mag.localRotation);// * transform.localRotation; //prevRotation

        //transform.rotation =  transform.rotation * deltaRot;

        viewTarget.position = (transform.position - mainCamera.position).normalized * 8.0f + transform.position;
        transform.LookAt(viewTarget, mag.up);
        //transform.LookAt(mainCamera, mainCamera.up);
        //transform.Rotate(0f,180f,0f);
        //prevRotation = mag.rotation;
    }
    
}
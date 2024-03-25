using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFaceCameraBehavior : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Transform cam = Camera.main.transform;
        transform.LookAt(transform.position + cam.forward);
    }
}

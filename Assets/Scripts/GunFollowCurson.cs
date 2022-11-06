using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollowCurson : MonoBehaviour
{
 
    void Update()
    {
        //mouse position
        Vector3 mousePos = Input.mousePosition;

        //afairesh tis apostasis tou cursor me to antikeimeno mas
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(-mousePos.y, -mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0 , angle));
        //tansform.eulerAngles = new Vector3(0, 0, angle);
    }
}

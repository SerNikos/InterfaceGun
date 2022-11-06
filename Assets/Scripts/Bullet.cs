using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //with only one interface we can impelent the Damage function with only few lines of code -Polymorphism-

    private void OnTriggerEnter(Collider other)
    {
        IDamagable damObject = other.GetComponent<IDamagable>();
        if(damObject != null)
        {
            damObject.Damage();
        }
    }

}

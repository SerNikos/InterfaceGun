using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderEnemy : MonoBehaviour,IDamagable
{
    public void Damage()
    {
        print("Cylinder here and i take damage");
    }
}

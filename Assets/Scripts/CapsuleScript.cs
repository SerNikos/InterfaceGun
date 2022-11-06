using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour, IDamagable
{
    public void Damage()
    {
        print("I am the Capsule Monster and i take damage");
    }
}

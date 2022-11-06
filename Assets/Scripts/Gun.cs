using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
	
    public Transform spawnPoint;
    public GameObject bulletPref;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPref, spawnPoint.position,spawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * 400f);

        //Debug.Break();  
        GetComponent<Animation>().Play("PistolShoot");
    } 

}

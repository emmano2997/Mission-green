using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingControler : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletSpaw;
    public float fireRate;
    private Transform _bullet;
   void Start(){
   }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
       _bullet = Instantiate(bullet.transform, bulletSpaw.transform.position, Quaternion.identity);
    }
}

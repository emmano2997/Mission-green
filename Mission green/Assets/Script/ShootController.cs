using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform gun;
    
    /*void Start() {
        GameObject.Destroy (gameObject, 5);

    }*/
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Rigidbody a = Rigidbody.Instantiate(bullet, gun.position, gun.rotation)
            as Rigidbody;

            a.AddForce(gun.forward * 1250);
        }
    }
}

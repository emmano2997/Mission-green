using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float aliveTime;
    public float demege;
    public float moveSpeed;

     void Start() {
    }
    void Update()
    {
        aliveTime -=1 * Time.deltaTime;
        if (aliveTime <= 0)
        {
            Destroy(this.gameObject);
        }

        this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour{
    public float aliveTime;
    public float damage;
    public float moveSpeed;
    public GameObject bulletSpawn;

    private GameObject enemyTriggered;

     void Start() {
         bulletSpawn = GameObject.Find("Bullet Spawn");
         this.transform.rotation = bulletSpawn.transform.rotation;
    }
    void Update(){
        aliveTime -=1 * Time.deltaTime;
        if (aliveTime <= 0)
        {
            Destroy(this.gameObject);
        }
        this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }

    void OnTriggerEnter(Collider other){
          if (other.tag == "Enemy" ){
              enemyTriggered = other.gameObject;
              //enemyTriggered.GetComponent<Enemy>()health -= damage; 
              Destroy(this.gameObject);
          }
    }
}

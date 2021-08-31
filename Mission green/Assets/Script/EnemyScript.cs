using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour{

    public float health;
    void OnTriggerEnter(Collider other){
          if (health <= 0){
              Die();
          }
    }
    public void Die() {
        Destroy(this.gameObject);
    }
}

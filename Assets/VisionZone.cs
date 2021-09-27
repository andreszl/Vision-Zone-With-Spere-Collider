using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class VisionZone : MonoBehaviour {
    public List<Collider> enemies;

    void OnTriggerEnter(Collider other) {
        print("new enemy " + other.name);
        enemies.Add(other);
    }

     void OnTriggerExit(Collider other) {
        print("leave enemy " + other.name);
        enemies.Remove(other);
    }

    void OnDrawGizmos() {
        Gizmos.DrawWireSphere(transform.position, 1f);
    } 
}

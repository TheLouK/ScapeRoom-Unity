using UnityEngine;
using System.Collections;

public class AttackTrigger : MonoBehaviour {
    [SerializeField]
    private EnemyStateManager manager;

    void OnTriggerStay(Collider col) {
        if (col.name == "Player") {
            manager.startAttack();
        }
    }
    
    void OnTriggerExit(Collider col) {
        if (col.name == "Player") {
            manager.startPatrol();
         }
    }
}

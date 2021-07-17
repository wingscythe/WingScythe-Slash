using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegHitboxManager : MonoBehaviour {
    // Used for organization
    public PolygonCollider2D[] colliders;

    // Collider on this game object
    private PolygonCollider2D localCollider;

    public bool isEnemy = false;

    void Start() {
        // Create a polygon collider
        localCollider = gameObject.AddComponent<PolygonCollider2D>();
        localCollider.isTrigger = true; // Set as a trigger so it doesn't collide with our environment
        localCollider.pathCount = 0; // Clear auto-generated polygons
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (!isEnemy) {
            EnemyController controller = col.gameObject.GetComponentInParent<EnemyController>();

            if (controller) {
                controller.legHit(PlayerController.Instance.strength);
            }
        } else {
            EnemyController controller = GetComponentInParent<EnemyController>();
            if (col.tag == "Player") {
                PlayerController.Instance.legHit(controller.strength);
            }
        }
    }

    public void setHitBox(int val) {
        if (val != -1) {
            localCollider.SetPath(0, colliders[val].GetPath(0));
            return;
        }
        localCollider.pathCount = 0;
    }
}


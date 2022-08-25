using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollisionCheck : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D col) {
        Destroy(gameObject);
    }
}

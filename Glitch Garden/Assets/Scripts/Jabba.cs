using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jabba : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionObject = collision.gameObject;
        if (collisionObject.GetComponent<Defenders>())
        {
            GetComponent<Attacker>().SetMovementSpeed(1);
        }
    }
}

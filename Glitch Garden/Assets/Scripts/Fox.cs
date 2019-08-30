using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionObject = collision.gameObject;

        if (collisionObject.GetComponent<Gravestone>())
        {
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }
        else if (collisionObject.GetComponent<Defenders>())
        {
            GetComponent<Attacker>().Attack(collisionObject);
        }
    }
}

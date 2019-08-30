using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject gun;

    AttackerSpawner myLaneSpawner;
    Animator animator;

    GameObject projectileParent;
    const string PROJECTILE_PARENT_NAME = "Projectiles";

    // Start is called before the first frame update
    void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();

        CreateProjectileParent();
    }

    private void CreateProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners)
        {
            bool isCloseEnough = Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon;
            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isAttackerInLane())
        {
            //change animation state to shooting
            animator.SetBool("isAttacking", true);
            
        }
        else
        {
            //start idle animation
            animator.SetBool("isAttacking", false);
        }
    }

    private bool isAttackerInLane()
    {
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        return true;
    }

    public void Shoot()
    {
        GameObject proj = Instantiate(bullet, gun.transform.position, gun.transform.rotation) as GameObject;
        proj.transform.parent = projectileParent.transform;
    }
}

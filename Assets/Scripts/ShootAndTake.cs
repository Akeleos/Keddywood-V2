using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAndTake : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private bool isPicked;
    [SerializeField] private int bulletCount = 0;
    public float shootSpeed = 0f;
    private void Update()
    {
        if (isPicked)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ShootBullet();
            }
        }
        
    }
    private void ShootBullet()
    {

        Rigidbody rgBullet = bullet.GetComponent<Rigidbody>();
        bullet.GetComponent<Rigidbody>().isKinematic = false;
       
        rgBullet.AddForce(transform.forward * shootSpeed, ForceMode.Impulse);
        rgBullet.useGravity = true;
        bullet.transform.SetParent(null);
        isPicked = false;
        bulletCount--;
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "collectible" && bulletCount == 0)
        {
            PickUp(collision);
        }
    }
    

    void PickUp(Collision collision)
    {
        bullet = collision.gameObject;
        bullet.transform.position = transform.position + new Vector3(2f, 2, 0);
        bullet.GetComponent<Rigidbody>().useGravity = false;
        bullet.GetComponent<Rigidbody>().isKinematic = true;
        bullet.transform.SetParent(transform);
        bulletCount++;
        isPicked = true;
    }

   
}

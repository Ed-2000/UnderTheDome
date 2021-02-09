using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] protected GameObject bulletPrefab;
    [SerializeField] protected Transform pointOfShot;

    protected int numberOfBulletsInStore;
    protected float rateOfFire;
    protected float damage;
    protected float bulletSpeed;

    protected void Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, pointOfShot.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }
}
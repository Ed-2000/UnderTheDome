using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    private void Start()
    {
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.transform.position = pointOfShot.position;
    }
}
﻿using System.Collections;
using UnityEngine;

public class LinePattern : MonoBehaviour, IShootable
{
    IEnumerator Shooting()
    {
        Weapon weapon = transform.parent.GetComponent<PlayerShoot>().GetWeapon();
        GameObject _projectilePrefab = weapon.GetProjectile;
        
        while (true)
        {
            var a = Instantiate(_projectilePrefab, transform.position, Quaternion.identity);
            a.GetComponent<Projectile>().SetStats(weapon.GetSpeed, weapon.GetDamage);
            yield return new WaitForSeconds(weapon.GetFireRate);
        }
    }

    public void Shoot()
    {
        StartCoroutine(Shooting());
    }

    public void StopShoot()
    {
        StopAllCoroutines();
    }
}

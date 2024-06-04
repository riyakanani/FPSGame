using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletVelocity = 30f;
    public float bulletPrefabLifeTime = 3f;

    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            FireWeapon();
        }
    }

    private void FireWeapon(){
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward.normalized * bulletVelocity, ForceMode.Impulse);
        StartCoroutine(DestoryBulletAfterTime(bullet, bulletPrefabLifeTime));
    }

    private IEnumerator DestoryBulletAfterTime(GameObject bullet, float delay){
        yield return new WaitForSeconds(delay);
        Destroy(bullet);
    }

}

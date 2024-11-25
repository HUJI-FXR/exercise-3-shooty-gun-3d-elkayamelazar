using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyGunScript : MonoBehaviour
{
    [SerializeField] public GameObject Bullet;
    [SerializeField] public float bulletSpeed;
    [SerializeField] private Transform bulletSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        GameObject newBullet = Instantiate(Bullet, transform.position, transform.rotation);

        Rigidbody bulletRb = newBullet.GetComponent<Rigidbody>();

        newBullet.SetActive(true);

        bulletRb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

    }
}
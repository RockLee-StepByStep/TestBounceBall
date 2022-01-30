using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankAI : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    public GameObject player;
    public GameObject bullet;
    public GameObject turret;
    public Rigidbody rb;


    public GameObject GetPLayer()
    {
        return player;
    }

    void Fire()
    {
        Instantiate(bullet, turret.transform.position, turret.transform.rotation);
        // b.GetComponent<Rigidbody>().AddForce(turret.transform.forward * 1500);
        // b.transform.Translate(Vector3.forward * 30);

    }

    public void StopFiring()
    {
        CancelInvoke("Fire");
    }
    public void StartFiring()
    {
        InvokeRepeating("Fire", 1f, 4f);
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Distance", Vector3.Distance(transform.position, player.transform.position));


    }
}

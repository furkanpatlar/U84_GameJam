using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Rigidbody))]
public class T_Object : MonoBehaviour
{

    Rigidbody rb;
    public bool taken = false;
    //private int puan = 0;
    //public TMP_Text puanGoster;

    [HideInInspector]
    public bool hasReseted = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (taken == true)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("pivot");

            rb.MovePosition(obj.transform.position);
            rb.MoveRotation(Quaternion.LookRotation(Camera.main.transform.forward));

            rb.useGravity = false;


        }
        else
        {
            rb.useGravity = true;
        }

        if (hasReseted == false)
        {
            resetForce();
            hasReseted = true;
        }

    }

    public void resetForce()
    {
        rb.isKinematic = true;
        rb.isKinematic = false;
    }

    public void Force()
    {
        rb.AddForce(Camera.main.transform.forward * 15, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        taken = false;
    }




    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hedef")
        {
            puan++;
            Destroy(other.gameObject);
            puanGoster.text = "Puanin = " + puan;
        }

    }*/



}

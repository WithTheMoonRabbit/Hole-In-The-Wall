using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCtrl : MonoBehaviour
{
    public GameManager manager;

    public BoxCollider[] boxCollider;
    Rigidbody myRigid;

    private void Awake()
    {
        myRigid= GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        manager.GameOver();
    }
}

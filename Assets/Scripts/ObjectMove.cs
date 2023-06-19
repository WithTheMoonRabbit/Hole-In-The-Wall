using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ObjectMove : MonoBehaviour
{
    public GameManager manager;
    Rigidbody rigid;
    GameObject my;

    [System.Obsolete]
    private void OnEnable()
    {
        rigid = GetComponent<Rigidbody>();
        my = GetComponent<GameObject>();
        if(this.gameObject.active == true)
        {
            StartCoroutine(Destroy());
        }
    }

    IEnumerator Destroy()
    {
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, -5), 0.01f);
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, (float)0.7, -5), Time.deltaTime * 0.5f);
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, -5), 0.01f);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, (float)0.7, -5), Time.deltaTime * 3f);
    }
}

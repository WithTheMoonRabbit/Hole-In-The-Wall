using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour
{
    public GameObject[] GameObjectwall;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateObject());
    }

    IEnumerator CreateObject()
    {
        for(int i = 0; i < GameObjectwall.Length;)
        {
            Instantiate(GameObjectwall[i], new Vector3(0, (float)1.2, 4),Quaternion.identity);
            i++;
            yield return new WaitForSeconds(8f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

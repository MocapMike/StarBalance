using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Houdini : MonoBehaviour
{
    public GameObject prefab_fakestar;
    public Vector3 fakestar_position;

    // Update is called once per frame
    void Update()
    {
        if((GameObject.Find("FakeStar(Clone)")==null) || (GameObject.Find("FakeStar")==null))
        {
            Vector3 randomSpawn = new Vector3(Random.Range(-0.8,0.9),.5,Random.Range(-0.8,0.9));
             GameObject fakestar = Instantiate(prefab_fakestar);
            fakestar.transform.position = fakestar_position;

        }
        
    }
}

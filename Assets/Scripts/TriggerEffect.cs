using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEffect : MonoBehaviour
{
    private Rigidbody rb;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Touched"))
        {
            count = count + 1;
            Debug.Log(count);
           // other.gameObject.SetActive(false);
            Destroy(other.gameObject,.5f);
           
        
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTouch : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            Debug.DrawRay(ray.origin, ray.direction * 20f,Color.green);

            if (Physics.Raycast(ray,out hit))
            {
                Debug.Log("Hit!!!!!");
                Debug.Log("Name = " + hit.transform.gameObject.name);

                Destroy(hit.transform.gameObject);
            }

        }

    }
}

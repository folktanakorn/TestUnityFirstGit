using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceloroTest : MonoBehaviour
{
    public int speed = 5;
    public int speedTurn = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X =  Input.acceleration.x;
        float Z = Input.acceleration.z;
        Debug.Log(X);
        transform.Translate(0,0,-Z * speed * Time.deltaTime);
        transform.Rotate(0, 0, -X * speedTurn * Time.deltaTime);

    }
}

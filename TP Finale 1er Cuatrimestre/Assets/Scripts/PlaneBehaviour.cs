using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBehaviour : MonoBehaviour
{
    float movementSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movementSpeed, 0, 0);

        //if(LA POSICION DEL PLANO ES == A POSICION DONDE APARECE LA MONEDA){
        //movementSpeed = 0;
        //}
    }
}

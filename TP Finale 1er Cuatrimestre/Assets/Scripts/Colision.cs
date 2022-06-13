using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colision : MonoBehaviour
{
    public GameObject Panel_perdiste;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Pared 1" || other.gameObject.name == "Pared 2" || other.gameObject.name == "Obstaculo")
        {
            Destroy(gameObject);
            Panel_perdiste.SetActive(true);
        }
    }
}

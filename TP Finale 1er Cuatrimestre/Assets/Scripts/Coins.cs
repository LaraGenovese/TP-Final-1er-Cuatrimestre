using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text txt_monedas;
    int monedas;

    public GameObject Panel_ganar;
    public GameObject Panel_perder;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (monedas == 10)
        {
            Panel_ganar.SetActive(true);
            Destroy(Panel_perder);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //other.gameObject.name = "Moneda";

        if (other.gameObject.name == "Moneda")
        {
            Destroy(other.gameObject);
            monedas = monedas + 1;
        }
        txt_monedas.text = "Score: " + monedas;
    }
}

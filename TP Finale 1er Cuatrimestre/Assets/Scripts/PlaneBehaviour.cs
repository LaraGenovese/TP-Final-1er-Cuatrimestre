using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneBehaviour : MonoBehaviour
{
    public float movementSpeed = 0.1f;
    public Coins coinsScript;

    public Text txt_time;
    public float currentTime = 3;

    public GameObject txt_tiempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        txt_time.text = (3 - Mathf.Floor(currentTime)).ToString();

        if(txt_time.text == "0")
        {
            transform.position += new Vector3(movementSpeed, 0, 0);
        }

        if (coinsScript.monedas == 10)
        {
            movementSpeed = 0;
        }
    }
}

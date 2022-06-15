using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneBehaviour : MonoBehaviour
{
    public float movementSpeed;
    public Coins coinsScript;
    private float remainingTime;

    public Text txt_time;
    public GameObject tiempo;
    public float currentTime;

    public GameObject clone;
    int cantDeCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (cantDeCubos < 100)
        {
            Instantiate(clone);
            cantDeCubos += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        remainingTime = 3 - Mathf.Floor(currentTime);

        txt_time.text = remainingTime.ToString();

        if (remainingTime <= 0)
        {
            transform.position += new Vector3(movementSpeed, 0, 0);
            tiempo.SetActive(false);
        }


        if (coinsScript.monedas == 10)
        {
            movementSpeed = 0;
        }
    }
}

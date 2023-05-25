using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject Time_gauge;
    float time = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.Time_gauge = GameObject.Find("Time");
    }


    public void DecreaseHp() { 
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.Time_gauge.GetComponent<TextMeshProUGUI>().text =
            this.time.ToString("F1");

    }
}

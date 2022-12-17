using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timeDisplay: MonoBehaviour
{
    public Clock clock;
    public TextMeshPro text;
    //private TextMeshProUGUI displaytext;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TMP_Text>().text = "" + clock.mins + ":"+ string.Format("{0:00}", clock.secs);
    }
}

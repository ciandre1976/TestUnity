using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanagerTap : MonoBehaviour
{
    [SerializeField] Text tap;
    void Start()
    {
        tap.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        tap.text = Spawner.toKlik.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UimanagerMerge : MonoBehaviour
{

    [SerializeField] Text merge;
    void Start()
    {
        merge.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        merge.text = Spawner.tracker.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static int tracker = 0;
    public static int toKlik = 0;//for menu

    [SerializeField] AudioSource playAudio;

    int pos = tracker;
    int kliks = 0;

    void Update()
    {
        Draw();
    }



    public void Draw()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playAudio.Play();
            kliks++;
            toKlik++;
            ObjectPool.Instance.SpawnfromPool("red", new Vector3(pos, 0, 0), Quaternion.identity, pos);
            pos++;
            if (kliks == 10)
            {
                ObjectPool.Instance.SpawnfromPool("blue", new Vector3(tracker, 0, 0), Quaternion.identity, tracker);
                ObjectPool.Instance.DeactivateFromPool("red");
                tracker++;
                if (tracker == 10)
                {
                    tracker = 0;
                    ObjectPool.Instance.DeactivateFromPool("blue");
                }
                kliks = 0;
                pos = tracker;
            }
        }
    }
}
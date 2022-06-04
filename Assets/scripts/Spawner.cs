using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static int tracker = 0;
    int pos = tracker;
    int kliks = 0;

    void Update()
    {
        DrawScene();
    }

    public void DrawScene()
    {
        Draw();
    }


    public void Draw()
    {
        if (Input.GetMouseButtonDown(0))
        {
            kliks++;
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
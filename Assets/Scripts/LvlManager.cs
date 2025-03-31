using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlManager : MonoBehaviour
{
    public static LvlManager main;

    public Transform startPoint;
    public Transform[] path;

    public void Awake()
    {
        main = this;
    }
}

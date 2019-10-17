using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomSemParar : MonoBehaviour {

    public static SomSemParar instance;

    void Awake()
    {
        if (SomSemParar.instance == null)
        {
            DontDestroyOnLoad(transform.gameObject);
            SomSemParar.instance = this;
        }else
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour {

    public int vida;
    public int numVidas;

    public Image[] caveiras;
    public Sprite caveiraInteira;
    public Sprite caveiraMetade;
    public Sprite caveiraVazia;
    
    void Update()
    {
        if(vida > numVidas)
        {
            vida = numVidas;
        }
        for (int i = 0; i < caveiras.Length; i++)
        {
            if (i < vida)
            {
                caveiras[i].sprite = caveiraInteira;
            }
            else
            {
                caveiras[i].sprite = caveiraVazia;
            }
            if(i < numVidas)
            {
                caveiras[i].enabled = true;
            }
            else
            {
                caveiras[i].enabled = false;
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public GameObject RojoDa�o;
    public GameObject Enemigo;
    private int PlayerVida;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        PlayerVida = 10;
        RojoDa�o.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerVida == 0)
        {
            Debug.Log("Estas Muerto, fiera...");
        }
    }

    public void SumVida(int modificador)
    {
        if (PlayerVida > 0)
        PlayerVida = PlayerVida + modificador;
    }

    public void QuitarVida(int modificador)
    {
        if (PlayerVida > 0)
            PlayerVida = PlayerVida - modificador;
    }


    public void ImprimirVida(float modificador)
    {
        RojoDa�o.SetActive(true);
        Debug.Log("Te Faltan " +PlayerVida + " Puntos de Vida");
    }
    public void QuitarRojo()
    {
        RojoDa�o.SetActive(false);
    }

}

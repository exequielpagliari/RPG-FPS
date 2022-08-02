using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAttack : MonoBehaviour
{
    private float XFaltante;
    private float ZFaltante;
    private float XPlayer;
    private float ZPlayer;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Player.GetComponent<PlayerStats>().QuitarRojo();
        XPlayer = Player.transform.position.x;
        ZPlayer = Player.transform.position.z;
        XFaltante = transform.position.x - XPlayer;
        ZFaltante = transform.position.z - ZPlayer;

        if (Input.anyKeyDown)
        {
            //Debug.Log(XFaltante);
            //Debug.Log(XFaltante);
            //Debug.Log("x Faltante: +" + XFaltante);
            //Debug.Log("y Faltante: +" + ZFaltante);
            if (XFaltante > -2 && XFaltante < 2 && ZFaltante > -2 && ZFaltante < 2)
            {
                Jugadordamage();

            }
        }


        void Jugadordamage()
        {
            Player.GetComponent<PlayerStats>().QuitarVida(1);
            Player.GetComponent<PlayerStats>().ImprimirVida(3);
            
        }
    }
}
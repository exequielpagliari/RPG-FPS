using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Engine : MonoBehaviour
{
    
    public GameObject Enemigo1;
    public GameObject Enemigo2;
    public GameObject Enemigo3;
    public GameObject Enemigo4;
    public GameObject Enemigo5;
    public GameObject Enemigo6;
    public GameObject Enemigo7;
    public GameObject TextBox;
    public int turno;
    public int turnoenemigo;
    // Start is called before the first frame update
    void Start()
    {
        TextBox.GetComponent<TMP_InputField>();
        
        turno = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(turno);
    
    }

    public void SumarTurno(int cantturno)
    {
        turno += cantturno;
        

    }

    public void SumarTurnoEnemigo(int cantturno)
    {
        turnoenemigo = cantturno; //* Enemigo1.tag.Length;
    }

    public void Description()
    {
        Enemigo1.GetComponent<EnemigoDescripcion>().leerdescricion();
    }

}

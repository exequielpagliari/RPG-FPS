using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDescripcion : MonoBehaviour
{
    private string descripcion;
    // Start is called before the first frame update
    void Start()
    {
        descripcion = "El enemigo me mira feo";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void leerdescricion()
    {
        Debug.Log(descripcion);
    }
}

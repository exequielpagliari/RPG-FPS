using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public GameObject Motor;
    public GameObject Sur;
    public GameObject Norte;
    public GameObject Este;
    public GameObject Oeste;
    private bool Sinmovimiento;
    private float Rotate;
    private float Z;
    // Start is called before the first frame update
    void Start()
    {
        Sur.SetActive(true);
        Norte.SetActive(false);
        Este.SetActive(false);
        Oeste.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    

                if (Input.GetKeyDown(KeyCode.A))
                {
                    transform.Rotate(0, -90, 0);
                    Rotate += 1;
                }


                if (Input.GetKeyDown(KeyCode.D))
                {
                    transform.Rotate(0, 90, 0);
                    Rotate -= 1;
                }


                if (Rotate > 3)
                {
                    Rotate = 0;
                }

                if (Rotate < 0)
                {
                    Rotate = 3;
                }

                if (Rotate == 0) 
                { 
                Sur.SetActive(true);
                Norte.SetActive(false);
                Este.SetActive(false);
                Oeste.SetActive(false);
                }

                if (Rotate == 1)
                {
                    Sur.SetActive(false);
                    Norte.SetActive(false);
                    Este.SetActive(true);
                    Oeste.SetActive(false);
                }

                if (Rotate == 2)
                {
                    Sur.SetActive(false);
                    Norte.SetActive(true);
                    Este.SetActive(false);
                    Oeste.SetActive(false);
                }


                if (Rotate == 3)
                {
                    Sur.SetActive(false);
                    Norte.SetActive(false);
                    Este.SetActive(false);
                    Oeste.SetActive(true);
                }

            if (Input.GetKeyDown(KeyCode.W))
             {
                Foward();
             }

            if (Input.GetKeyDown(KeyCode.S))
                {
                Back();
                }

            

        }




    public void RotateR()
    {
        {
            transform.Rotate(0, 90, 0);
            Rotate -= 1;
        }


        if (Rotate > 3)
        {
            Rotate = 0;
        }

        if (Rotate < 0)
        {
            Rotate = 3;
        }

        if (Rotate == 0)
        {
            Sur.SetActive(true);
            Norte.SetActive(false);
            Este.SetActive(false);
            Oeste.SetActive(false);
        }

        if (Rotate == 1)
        {
            Sur.SetActive(false);
            Norte.SetActive(false);
            Este.SetActive(true);
            Oeste.SetActive(false);
        }

        if (Rotate == 2)
        {
            Sur.SetActive(false);
            Norte.SetActive(true);
            Este.SetActive(false);
            Oeste.SetActive(false);
        }


        if (Rotate == 3)
        {
            Sur.SetActive(false);
            Norte.SetActive(false);
            Este.SetActive(false);
            Oeste.SetActive(true);
        }

    }

    public void RotateL()
    {
        transform.Rotate(0, -90, 0);
        Rotate += 1;


        if (Rotate > 3)
        {
            Rotate = 0;
        }

        if (Rotate < 0)
        {
            Rotate = 3;
        }

        if (Rotate == 0)
        {
            Sur.SetActive(true);
            Norte.SetActive(false);
            Este.SetActive(false);
            Oeste.SetActive(false);
        }

        if (Rotate == 1)
        {
            Sur.SetActive(false);
            Norte.SetActive(false);
            Este.SetActive(true);
            Oeste.SetActive(false);
        }

        if (Rotate == 2)
        {
            Sur.SetActive(false);
            Norte.SetActive(true);
            Este.SetActive(false);
            Oeste.SetActive(false);
        }


        if (Rotate == 3)
        {
            Sur.SetActive(false);
            Norte.SetActive(false);
            Este.SetActive(false);
            Oeste.SetActive(true);
        }

    }
   public void Foward()
    {
        Motor.GetComponent<Engine>().SumarTurno(1);
 ///       Motor.GetComponent<Engine>().SumarTurnoEnemigo(1);
        if (Rotate == 0)
        {
            if (!Physics.Raycast(transform.position + new Vector3(0, 0, 1f), Vector3.forward, 1f))
                transform.Translate(Vector3.forward);
        }

        if (Rotate == 1)
        {
            if (!Physics.Raycast(transform.position + new Vector3(-1f, 0, 0), Vector3.left, 1))
                transform.position = transform.position + Vector3.left;
        }

        if (Rotate == 2)
        {
            if (!Physics.Raycast(transform.position + new Vector3(0, 0, -1f), Vector3.back, 1))
                transform.position = transform.position + Vector3.back;
        }

        if (Rotate == 3)
        {
            if (!Physics.Raycast(transform.position + new Vector3(1f, 0, 0), Vector3.right, 1))
                transform.position = transform.position + Vector3.right;
        }
        Motor.GetComponent<Engine>().SumarTurno(0);

    }
                    
    public void Back()
    {
        Motor.GetComponent<Engine>().SumarTurno(1);
///        Motor.GetComponent<Engine>().SumarTurnoEnemigo(1);
        if (Rotate == 0)
        {
            if (!Physics.Raycast(transform.position + new Vector3(0, 0, -1f), Vector3.back, 1))
                transform.position = transform.position + Vector3.back;
        }

        if (Rotate == 1)
        {
            if (!Physics.Raycast(transform.position + new Vector3(1f, 0, 0), Vector3.right, 1))
                transform.position = transform.position + Vector3.right;
        }

        if (Rotate == 2)
        {
            if (!Physics.Raycast(transform.position + new Vector3(0, 0, 1f), Vector3.forward, 1f))
                transform.position = transform.position + Vector3.forward;
        }

        if (Rotate == 3)
        {
            if (!Physics.Raycast(transform.position + new Vector3(-1f, 0, 0), Vector3.left, 1))
                transform.position = transform.position + Vector3.left;
        }
        Motor.GetComponent<Engine>().SumarTurno(0);
    }


}


    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemigoMovi : MonoBehaviour
{
    public GameObject Up;
    public GameObject Down;
    public GameObject Enemigo;
    public GameObject Motor;
    private bool Sinmovimiento;
    private float XFaltante;
    private float ZFaltante;
    private float XPlayer;
    private float ZPlayer;
    public GameObject Player;
    public GameObject ButtonUP;
    public int turno;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        turno = Motor.GetComponent<Engine>().turnoenemigo;



        XPlayer = Player.transform.position.x;
        ZPlayer = Player.transform.position.z;

    if ( turno > 0)
        {
            Debug.Log(turno);
            MoveEnemy();
            
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

        }



        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)) //|| Input.GetKeyDown(KeyCode.Space))
        {
            MoveEnemy();
        }
    }
    public void MoveEnemy()
    {

            
                            
                            XFaltante = transform.position.x - XPlayer;
                            if (XFaltante > 0)
                            {
                                if (!Physics.Raycast(transform.position, Vector3.left, 1f))
                                    transform.position = transform.position + Vector3.left;
                                //else
                                //    transform.position = transform.position + Vector3.right;
                            }
                            if (XFaltante < 0)
                            {
                                if (!Physics.Raycast(transform.position, Vector3.right, 1f))
                                    transform.position = transform.position + Vector3.right;
                                //else
                                // transform.position = transform.position + Vector3.left;
                            }

                            if (XFaltante == 0)
                            {
                                ZFaltante = transform.position.z - ZPlayer;

                                if (ZFaltante > 0)
                                {
                                    if (!Physics.Raycast(transform.position, Vector3.back, 1f))
                                        transform.position = transform.position + Vector3.back;
                                    //else
                                    //    transform.position = transform.position + Vector3.forward;
                                }
                                if (ZFaltante < 0)
                                {
                                    if (!Physics.Raycast(transform.position, Vector3.forward, 1f))
                                        transform.position = transform.position + Vector3.forward;
                                    //else
                                    //    transform.position = transform.position + Vector3.back;
                                }
                            }

                        

                }
                
    }


    
    
    
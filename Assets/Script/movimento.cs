using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    public Animator anima;

    public CharacterController persona;
    float velocidade = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocidade = Input.GetAxis("Vertical");

        if (velocidade ==1 & Input.GetKey(KeyCode.LeftShift))
        {
            velocidade = 2;
        }

        if (velocidade ==1 & Input.GetKeyUp(KeyCode.LeftShift))
        {
            velocidade = 1;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            anima.SetTrigger("pular");
        }

        transform.Rotate(new Vector3(0,Input.GetAxis("Horizontal"),0));
        anima.SetFloat("andar" ,velocidade);

        if(!persona.isGrounded)
        {
            persona.Move(new Vector3(0, -1, 0));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 3.5f;
 
    
    private float gravidade = 10f;
   
    private CharacterController controle;
    //Variaveis aonde vão definir a velocidade e a gravidade em que o usuario ficara dentro da Realidade Virtual.
    //Instanciando uma classe do Unity "CharacterController" para já o unity reconhecer o que estamos fazendo.
    void Start()
    {
        controle = GetComponent<CharacterController>();
        //Controle agora esta usando o componente da Classe CharacterController
    }

    
    void Update()
    {
        
        Movimentacao();
        //atualiza a movimentação do jogador por frames 
    }

    void Movimentacao()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //Pegando direção que a pessoa esta indo e enviando a informação para que o jogo entenda pra onde você esta querendo ir.
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * velocidade;
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -= gravidade;
        controle.Move(velocity * Time.deltaTime);


    }
}

using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    //5. (Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
    //incompleta".

    [SerializeField] int Miss�o = 0;
    void Start()
    {
        if (Miss�o >= 50)
        {
            print("Miss�o Completa");

        }
        else
        {
            print("Miss�o Incompleta");
        }
    }

   
    void Update()
    {
        
    }
}

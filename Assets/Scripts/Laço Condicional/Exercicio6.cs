using UnityEngine;

public class Exercicio6 : MonoBehaviour
{
    //6. (Escolha de personagem) O jogador pode escolher entre o
    //personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar
    //Mago.

    //[SerializeField] string Escolhapersonagem;
    [SerializeField] bool mago;
    [SerializeField] bool guerreiro;
    void Start()
    {
        //if (Escolhapersonagem == "Guerreiro")
        //{
        //    print("Guerreiro Escolhido");
        //}

        //else if (Escolhapersonagem == "Mago")
        //{
        //    print("Mago Escolhido");
        //}

        //else
        //{
        //    print("Escolha Inválida");
        //}

        if (mago == true && guerreiro == false)
        {
            print("Mago escolhido");
        }
        else if (mago == false && guerreiro == true)
        {
            print("Guerreiro escolhido");
        }
        else if (mago && guerreiro)
        {
            print("Escolha apenas um personagem");
        }
        else
        {
            print("Escolha um ");
        }

    }

   
    void Update()
    {
        
    }
}

using UnityEngine;
using static UnityEditor.Progress;

public class Exercicio10 : MonoBehaviour
{
    //10. (Itens do invent�rio) Crie um script onde o jogador pode coletar
    //diferentes tipos de itens(como moedas, po��es, ou power-ups)
    //que t�m efeitos diferentes dependendo do tipo coletado.Use um
    //switch case para determinar o efeito de cada tipo de item.

    //Item 1: Moedas
    //Item 2: Po��es
    //Item 3: Power-Ups

    [SerializeField] int Item = 1;

    void Start()
    {

        switch (Item) 
        {
            case 1:
                
             print("Moedas Coletadas");

             if (true)
             {

             print("Voc� coletou Moedas");

             }
             break;

            case 2:

             print("Poc�es de vida coletada");

             if (true)
              {

              print("Voc� coletou uma po��o de vida");

              }
              break;

            case 3:

             print("Voc� encontrou um Power-Up");

             if (true)
              {

              print("Voc� coletou um Power-Up");

              }
              break;

             default:

              print("Item n�o encontrado");
              break;

        }


    }


    void Update()
    {
        
    }
}

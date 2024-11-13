using UnityEngine;
using static UnityEditor.Progress;

public class Exercicio10 : MonoBehaviour
{
    //10. (Itens do inventário) Crie um script onde o jogador pode coletar
    //diferentes tipos de itens(como moedas, poções, ou power-ups)
    //que têm efeitos diferentes dependendo do tipo coletado.Use um
    //switch case para determinar o efeito de cada tipo de item.

    //Item 1: Moedas
    //Item 2: Poções
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

             print("Você coletou Moedas");

             }
             break;

            case 2:

             print("Pocões de vida coletada");

             if (true)
              {

              print("Você coletou uma poção de vida");

              }
              break;

            case 3:

             print("Você encontrou um Power-Up");

             if (true)
              {

              print("Você coletou um Power-Up");

              }
              break;

             default:

              print("Item não encontrado");
              break;

        }


    }


    void Update()
    {
        
    }
}

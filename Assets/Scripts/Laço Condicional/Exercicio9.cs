using System;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
    //9. (Placar final) Crie um script que lê o placar de uma partida entre
    //time A e time B.Depois, escreva no console qual dos três
    //resultados possíveis aconteceu: vitória do time A, vitória do time B
    //ou empate.Se o empate teve mais de 3 pontos para cada lado,
    //escreva que foi “um empate emocionante”.

    [SerializeField] int TimeA = 0;
    [SerializeField] int TimeB = 0;
    void Start()
    {
        if (TimeA > TimeB)
        {
            print("Time A ganhou");
        }

        else if (TimeB > TimeA)
        {
            print("Time B ganhou");
        }

        else
        {
            if (TimeA > 3 && TimeB > 3)
        {
            print("Empate emocionante");
        }
            else
            {
            print("Empate");
            }

        }
    }

    
    void Update()
    {
        
    }
}

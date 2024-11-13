using UnityEngine;

public class ExercicioRepeticao4 : MonoBehaviour
{
    //(Pontuação em combos) Cada combo realizado aumenta em 10
    //pontos.Exiba a pontuação total após 7 combos.

    [SerializeField] int Pontos = 10;
    [SerializeField] int TotalPontos = 0;


    void Start()
    {

        for (int i = 1; i <= 7; i++)
        {
            print("Combo " + i + ": Pontos = " + Pontos);
            TotalPontos += Pontos;
            Pontos += 10;


        }

        print("Pontuação Total após 7 combos: " + TotalPontos);
    }
     

    void Update()
    {
        
    }
}

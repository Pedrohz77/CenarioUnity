using UnityEngine;

public class ExercicioRepeticao7 : MonoBehaviour
{
    //(Maior n�mero em uma lista) Dada uma lista de n�meros,
    //encontre o maior valor.

    int[] numeros = { 3, 5, 7, 10, 68, 23, 71, 18, 97 };
    int maior = 0; 
    void Start()
    {
        foreach (var item in numeros)
        {
            if (item > maior) 
            {
                maior = item;
            }
        }

        print("O maior n�mero �: " + maior);
    }    


    void Update()
    {
        
    }
}

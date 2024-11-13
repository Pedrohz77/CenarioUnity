using UnityEngine;

public class Exercicio7 : MonoBehaviour
{
    //7. (Dado com N faces) Para fazer um jogo de RPG, vamos precisar
    //calcular probabilidades e simular a rolagem de dados.Crie um
    //script em que o usuário defina o número de faces de um dado
    //(int) e calcule a rolagem de um dado com esse número de faces.
    //Use a função abaixo para o cálculo: Random.Range (valor_min,
    //valor_max); (Coloque o código dentro da função-evento Start).

    //System.Random numerosdados = new System.Random();
    //int numeroslados = 6;

    //public int numerodefaces = 6;
    //[SerializeField] System.Random random;

    [SerializeField] int faces;
    void Start()
    {
        //if (numeroslados > 0)
        //{
        //    // Rolagem do dado
        //    int resultado = Random.Range(1, numeroslados);
        //    print("Resultado da rolagem do dado: " + resultado);
        //}
        //else
        //{
        //    print("Número de faces inválido! Deve ser maior que 0.");
        //}

        //random = new System.Random(); 

        //if (numerodefaces > 0)
        //{
        //    int resultado = random.Next(1, numerodefaces + 1);
        //    print("Resultado da rolagem do dado: " + resultado);
        //}
        //else
        //{
        //    print("Número Deve ser maior que 0.");
        //}

        if (faces == 0)
        {
            print("O número de faces do dado não pode ser: " + faces);
        }
        else
        {
            print(Random.Range(1, faces));
        }

        //condição? vdd : falso

        print(faces == 0 ? ("O número de faces do dado não pode ser: " + faces) : (Random.Range(1, faces)));

    }

    void Update()
    {
        
    }
}

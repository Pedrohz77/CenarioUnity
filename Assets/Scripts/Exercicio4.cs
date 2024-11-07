using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    //4. (Verificar item de inventário) Um jogador possui itens limitados
    //no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //indisponível".

    [SerializeField] bool pocaodevida;
    void Start()
    {
        if (pocaodevida)
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção indisponível");
        }
    }

    
    void Update()
    {
        
    }
}

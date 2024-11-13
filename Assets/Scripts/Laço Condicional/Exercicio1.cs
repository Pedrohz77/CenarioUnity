using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    [SerializeField] int vidapersonagem = 100;
     
    void Start()
    {
        //resultado = vidaHeroi > vidadiminuida ? "Héroi está vivo" : "Herói está morto";

        //print(resultado

        if (vidapersonagem > 0) {

           print("O Personagem está vivo.");
        
    }
       else {

           print("O Personagem está morto");
            
        }
        
    }
    void Update() {


    }
}

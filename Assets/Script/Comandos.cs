using UnityEngine;
using UnityEngine.SceneManagement;

/* 
 *   Autor/Author: Pedro Lucas de Oliveira Cabral 
 *   GitHub: https://github.com/DoisLucas
 *   Data/Date: 30/01/2018
 */

public class Comandos : MonoBehaviour
{

    public void TrocaTela(string nome)
    {
        SceneManager.LoadScene(nome);
    }

    public void TrocaTelaSom(string nome)
    {
        Sistema.instancia.BotaoSom();
        SceneManager.LoadScene(nome);
    }

}

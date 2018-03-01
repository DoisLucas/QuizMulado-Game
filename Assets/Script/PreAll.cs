using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/* 
 *   Autor/Author: Pedro Lucas de Oliveira Cabral 
 *   GitHub: https://github.com/DoisLucas
 *   Data/Date: 31/01/2018
 */

public class PreAll : MonoBehaviour
{

    #region Variaveis

    public Text nome;
    public Text score;

    #endregion

    void Start()
    {
        Sistema.instancia.BotaoSomFade();
        Sistema.instancia.Pausar();
        nome.text = Sistema.instancia.GetNomeTema();

        if (nome.text.Equals("EXATAS"))
        {
            score.text = PlayerPrefs.GetInt("ScoreE").ToString();
        }
        else if (nome.text.Equals("HUMANAS"))
        {
            score.text = PlayerPrefs.GetInt("ScoreH").ToString();
        }
        else if (nome.text.Equals("BIOLÓGICAS"))
        {
            score.text = PlayerPrefs.GetInt("ScoreB").ToString();
        }
        else if (nome.text.Equals("GERAL"))
        {
            score.text = PlayerPrefs.GetInt("ScoreG").ToString();
        }

        StartCoroutine(GoPartida());
    }

    private IEnumerator GoPartida()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Partida");
        Sistema.instancia.BotaoSomNormal();
    }

}

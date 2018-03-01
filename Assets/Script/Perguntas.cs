using UnityEngine;

/* 
 *   Autor/Author: Pedro Lucas de Oliveira Cabral 
 *   GitHub: https://github.com/DoisLucas
 *   Data/Date: 01/02/2018
 */

public class Perguntas : MonoBehaviour
{

    #region Variaveis

    private string texto;
    private int resposta;
    private string q1;
    private string q2;
    private string q3;
    private string q4;
    private int coin;

    #endregion

    public Perguntas(string texto, int resposta, string q1, string q2, string q3, string q4)
    {
        this.texto = texto;
        this.resposta = resposta;
        this.q1 = q1;
        this.q2 = q2;
        this.q3 = q3;
        this.q4 = q4;
    }

    public Perguntas(string texto, int resposta, string q1, string q2, string q3, string q4, int coin)
    {
        this.texto = texto;
        this.resposta = resposta;
        this.q1 = q1;
        this.q2 = q2;
        this.q3 = q3;
        this.q4 = q4;
        this.coin = coin;
    }

    public string GetTexto()
    {
        return this.texto;
    }

    public void SetTexto(string texto)
    {
        this.texto = texto;
    }

    public int GetResposta()
    {
        return this.resposta;
    }

    public void SetResposta(int numero)
    {
        this.resposta = numero;
    }

    public string GetQ1()
    {
        return this.q1;
    }

    public void SetQ1(string texto)
    {
        this.q1 = texto;
    }

    public string GetQ2()
    {
        return this.q2;
    }

    public void SetQ2(string texto)
    {
        this.q2 = texto;
    }

    public string GetQ3()
    {
        return this.q3;
    }

    public void SetQ3(string texto)
    {
        this.q3 = texto;
    }

    public string GetQ4()
    {
        return this.q4;
    }

    public void SetQ4(string texto)
    {
        this.q4 = texto;
    }

    public int GetCoin()
    {
        return this.coin;
    }

    public void SetCoin(int coin)
    {
        this.coin = coin;
    }

}

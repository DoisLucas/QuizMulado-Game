using UnityEngine;

/* 
 *   Autor/Author: Pedro Lucas de Oliveira Cabral 
 *   GitHub: https://github.com/DoisLucas
 *   Data/Date: 01/02/2018
 */

public class Sistema : MonoBehaviour
{

    #region Variaveis

    public AudioSource musica;
    public AudioSource fx;
    public AudioSource fade;
    public AudioSource truee;
    public AudioSource falsee;

    public bool ativomusica = true;
    public bool ativofx = true;

    public int click = 0;
    public int pontuacao = 0;
    public int record = 0;
    public int newrecord = 0;

    public static Sistema instancia;

    public string nometema;

    #endregion

    public void SetPontuacao(int newP)
    {
        this.pontuacao = newP;
    }

    public int GetPontuacao()
    {
        return this.pontuacao;
    }

    public void SetRecord(int newP)
    {
        this.record = newP;
    }

    public int GetRecord()
    {
        return this.record;
    }

    public void SetClick(int n)
    {
        click = n;
    }

    public int GetClick()
    {
        return this.click;
    }

    public string GetNomeTema()
    {
        return this.nometema;

    }

    public void SetNomeTema(string nome)
    {
        this.nometema = nome;
    }

    public AudioSource GetMusica()
    {
        return this.musica;
    }

    public bool GetAtivoMusica()
    {
        return this.ativomusica;
    }

    public void SetAtivoMusica(bool status)
    {
        this.ativomusica = status;
    }

    public bool GetAtivofx()
    {
        return this.ativofx;
    }

    public void SetAtivoFX(bool status)
    {
        this.ativofx = status;
    }

    void Awake()
    {
        if (instancia == null)
        {
            DontDestroyOnLoad(gameObject);
            instancia = this;
        }
        else if (instancia != this)
        {
            Destroy(gameObject);
        }
    }

    public void Tocar()
    {
        Sistema.instancia.GetMusica().Play();
    }

    public void TocarFade()
    {
        Sistema.instancia.fade.Play();
    }

    public void Pausar()
    {
        Sistema.instancia.GetMusica().Pause();
    }

    public void BotaoSom()
    {
        if (ativofx)
            fx.Play();
    }

    public void BotaoSomNormal()
    {
        if (ativomusica)
            musica.Play();
    }

    public void BotaoSomFade()
    {
        if (ativofx)
            fade.Play();
    }

    public void Erro()
    {
        if (ativofx)
            falsee.Play();
    }

    public void Acerto()
    {
        if (ativofx)
            truee.Play();
    }

}






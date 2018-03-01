using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

/* 
 *   Autor/Author: Pedro Lucas de Oliveira Cabral 
 *   GitHub: https://github.com/DoisLucas
 *   Data/Date: 31/01/2018
 */

public class Perfil : MonoBehaviour
{
    #region Variaveis

    public Text nome;
    public Text ano;
    public Text acertos;
    public Text erros;
    public Text media;
    public Text scoreE;
    public Text scoreH;
    public Text scoreB;
    public Text scoreG;
    public Text coins;
    public Text reset;
    public Text pular;
    public Text porcent;
    public Text[] txtbtn;

    public GameObject rese;
    public GameObject dele;
    public GameObject[] teste;

    public Animation up;
    public Button[] botao;
    public InputField inputConfirm;

    private bool anim = true;
    private int clicker;

    #endregion

    void Start()
    {
        pular.text = PlayerPrefs.GetInt("Pulos").ToString();
        porcent.text = PlayerPrefs.GetInt("Chance").ToString();
        reset.text = PlayerPrefs.GetInt("Reset").ToString();

        if (PlayerPrefs.GetInt("Reset") > 0)
        {
            botao[2].GetComponent<Selectable>().interactable = true;
        }
        else
        {
            botao[2].GetComponent<Selectable>().interactable = false;
        }

        dele.SetActive(false);
        Color txtoff;
        ColorUtility.TryParseHtmlString("#C8C8C880", out txtoff);
        rese.SetActive(false);
        SetarValores();
        clicker = 0;
    }

    void Update()
    {
        if (dele.activeInHierarchy)
        {
            if (anim)
            {
                AnimacaoUP();
            }
            else
            {
                AnimacaoDown();
            }
        }

        if (clicker != 0)
        {
            SetarValores();
            clicker = 0;
            if (PlayerPrefs.GetInt("Reset") > 0)
            {
                botao[2].GetComponent<Selectable>().interactable = true;
            }
            else
            {
                botao[2].GetComponent<Selectable>().interactable = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape) && !rese.activeInHierarchy && !dele.activeInHierarchy)
        {
            Sistema.instancia.BotaoSom();
            SceneManager.LoadScene("Inicio");
        }

        if (Input.GetKeyDown(KeyCode.Escape) && rese.activeInHierarchy)
        {
            Sistema.instancia.BotaoSom();
            OffPopup(rese.GetComponent<Animation>());
        }

        if (Input.GetKeyDown(KeyCode.Escape) && dele.activeInHierarchy)
        {
            Sistema.instancia.BotaoSom();
            OffPopup(dele.GetComponent<Animation>());
        }
    }

    public void DeletarConta()
    {
        try
        {
            string confirm = inputConfirm.text;

            // IgnoreCase: !confirm.Equals ("CONFIRMAR", StringComparison.InvariantCultureIgnoreCase))

            if (confirm.Equals("") || !confirm.Equals("CONFIRMAR"))
            {
                up.Blend("Error");
                up.Blend("Error1");
            }
            else
            {
                PlayerPrefs.DeleteKey("Nome");
                PlayerPrefs.DeleteKey("Idade");
                PlayerPrefs.DeleteKey("Acertos");
                PlayerPrefs.DeleteKey("Coins");
                PlayerPrefs.DeleteKey("Erros");
                PlayerPrefs.DeleteKey("ScoreE");
                PlayerPrefs.DeleteKey("ScoreH");
                PlayerPrefs.DeleteKey("ScoreB");
                PlayerPrefs.DeleteKey("ScoreG");
                PlayerPrefs.DeleteKey("Pulos");
                PlayerPrefs.DeleteKey("Chance");
                PlayerPrefs.DeleteKey("Jogou");
                PlayerPrefs.DeleteKey("Vida");
                PlayerPrefs.DeleteKey("Reset");
                Sistema.instancia.BotaoSom();
                SceneManager.LoadScene("Inicio");
            }
        }
        catch (Exception)
        {
            print("erro");
        }
    }

    public void ShowPopup(GameObject PopupGameObject)
    {
        Sistema.instancia.BotaoSom();
        UiOff();
        BotoesOff();
        PopupGameObject.SetActive(true);
    }

    public void OffPopup(Animation animGameObject)
    {
        Sistema.instancia.BotaoSom();
        UiOn();
        BotoesOn();
        animGameObject.Play("exitMotionSecond");
    }

    public void Resetar(Animation animGameObject)
    {
        Sistema.instancia.BotaoSom();
        PlayerPrefs.SetInt("Acertos", 0);
        PlayerPrefs.SetInt("Erros", 0);
        PlayerPrefs.SetInt("ScoreE", 0);
        PlayerPrefs.SetInt("ScoreH", 0);
        PlayerPrefs.SetInt("ScoreB", 0);
        PlayerPrefs.SetInt("ScoreG", 0);
        PlayerPrefs.SetInt("Reset", PlayerPrefs.GetInt("Reset") - 1);
        clicker = 1;
        UiOn();
        BotoesOn();
        animGameObject.Play("exitMotionSecond");
    }

    private void BotoesOn()
    {
        int reset = PlayerPrefs.GetInt("Reset");

        Color c;
        ColorUtility.TryParseHtmlString("#FFFFFFFF", out c);

        for (int i = 0; i < botao.Length; i++)
        {
            if (i == 2 && reset == 0)
            {
                botao[2].interactable = false;
            }
            else
            {
                botao[i].interactable = true;
            }
        }

        for (int i = 0; i < txtbtn.Length; i++)
        {
            txtbtn[i].color = c;
        }
    }

    private void BotoesOff()
    {
        Color c;
        ColorUtility.TryParseHtmlString("#C8C8C880", out c);

        for (int i = 0; i < botao.Length; i++)
        {
            botao[i].interactable = false;
        }

        for (int i = 0; i < txtbtn.Length; i++)
        {
            txtbtn[i].color = c;
        }
    }

    private void UiOn()
    {
        for (int i = 0; i < teste.Length; i++)
        {
            teste[i].GetComponent<Selectable>().interactable = true;
        }
    }

    private void UiOff()
    {
        for (int i = 0; i < teste.Length; i++)
        {
            teste[i].GetComponent<Selectable>().interactable = false;
        }
    }

    private void SetarValores()
    {
        float a = PlayerPrefs.GetInt("Acertos");
        float e = PlayerPrefs.GetInt("Erros");
        float m = a / e;

        nome.text = PlayerPrefs.GetString("Nome");
        ano.text = PlayerPrefs.GetString("Idade").ToString();
        acertos.text = PlayerPrefs.GetInt("Acertos").ToString();
        erros.text = PlayerPrefs.GetInt("Erros").ToString();
        coins.text = PlayerPrefs.GetInt("Coins").ToString();
        reset.text = PlayerPrefs.GetInt("Reset").ToString();

        if (m.ToString() == "NaN")
        {
            media.text = ("0");
        }
        else if (m.ToString() == "Infinity")
        {
            media.text = PlayerPrefs.GetInt("Acertos").ToString();
        }
        else
        {
            media.text = m.ToString("F1");
        }

        scoreE.text = PlayerPrefs.GetInt("ScoreE").ToString();
        scoreH.text = PlayerPrefs.GetInt("ScoreH").ToString();
        scoreB.text = PlayerPrefs.GetInt("ScoreB").ToString();
        scoreG.text = PlayerPrefs.GetInt("ScoreG").ToString();
    }

    private void AnimacaoUP()
    {
        if (TouchScreenKeyboard.visible)
        {
            up.Play("KeyOn1");
            anim = false;
        }
    }

    private void AnimacaoDown()
    {
        if (!TouchScreenKeyboard.visible)
        {
            up.Play("KeyOn2");
            anim = true;
        }
    }

}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/* 
 *   Autor/Author: Pedro Lucas de Oliveira Cabral 
 *   GitHub: https://github.com/DoisLucas
 *   Data/Date: 31/01/2018
 */

public class Tema : MonoBehaviour
{

    #region Variaveis

    public GameObject exatas_dia;
    public GameObject humanas_dia;
    public GameObject bio_dia;
    public GameObject all_dia;
    public GameObject[] text;

    public Button exatas;
    public Button humanas;
    public Button bio;
    public Button all;
    public Button back;

    public Text info;
    public Text tema;
    public Text press;

    #endregion

    void Start()
    {
        exatas_dia.SetActive(false);
        humanas_dia.SetActive(false);
        bio_dia.SetActive(false);
        all_dia.SetActive(false);

        for (int i = 0; i < text.Length; i++)
        {
            text[i].GetComponent<Selectable>().interactable = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !exatas_dia.activeInHierarchy && !humanas_dia.activeInHierarchy && !bio_dia.activeInHierarchy && !all_dia.activeInHierarchy)
        {
            Sistema.instancia.BotaoSom();
            SceneManager.LoadScene("Inicio");
        }

        if (Input.GetKeyDown(KeyCode.Escape) && exatas_dia.activeInHierarchy)
        {
        
            Sistema.instancia.BotaoSom();
            OffPopup(exatas_dia.GetComponent<Animation>());

        }

        if (Input.GetKeyDown(KeyCode.Escape) && humanas_dia.activeInHierarchy)
        {

            Sistema.instancia.BotaoSom();
            OffPopup(humanas_dia.GetComponent<Animation>());

        }

        if (Input.GetKeyDown(KeyCode.Escape) && bio_dia.activeInHierarchy)
        {

            Sistema.instancia.BotaoSom();
            OffPopup(bio_dia.GetComponent<Animation>());

        }

        if (Input.GetKeyDown(KeyCode.Escape) && all_dia.activeInHierarchy)
        {
            Sistema.instancia.BotaoSom();
            OffPopup(all_dia.GetComponent<Animation>());

        }
    }

    public void OffPopup(Animation animGameObject)
    {
        Sistema.instancia.BotaoSom();
        exatas.interactable = true;
        humanas.interactable = true;
        bio.interactable = true;
        all.interactable = true;
        info.GetComponent<Selectable>().interactable = true;
        tema.GetComponent<Selectable>().interactable = true;
        press.GetComponent<Selectable>().interactable = true;
        back.interactable = true;

        for (int i = 0; i < text.Length; i++)
        {
            text[i].GetComponent<Selectable>().interactable = true;
        }

        animGameObject.Play("exitMotionSecond");
    }

    public void PopupOnPress()
    {
        Sistema.instancia.BotaoSom();
        exatas.interactable = false;
        humanas.interactable = false;
        bio.interactable = false;
        all.interactable = false;
        info.GetComponent<Selectable>().interactable = false;
        tema.GetComponent<Selectable>().interactable = false;
        press.GetComponent<Selectable>().interactable = false;
        back.interactable = false;

        for (int i = 0; i < text.Length; i++)
        {
            text[i].GetComponent<Selectable>().interactable = false;
        }
    }

    public void AddExatas()
    {
        Sistema.instancia.BotaoSom();
        Sistema.instancia.SetNomeTema("EXATAS");
        AddPerguntas.Add_exatas();
        SceneManager.LoadScene("PreAll");
    }

    public void AddHumanas()
    {
        Sistema.instancia.BotaoSom();
        Sistema.instancia.SetNomeTema("HUMANAS");
        AddPerguntas.Add_humanas();
        SceneManager.LoadScene("PreAll");
    }

    public void AddBio()
    {
        Sistema.instancia.BotaoSom();
        AddPerguntas.Add_bio();
        Sistema.instancia.SetNomeTema("BIOLÓGICAS");
        SceneManager.LoadScene("PreAll");
    }

    public void AddGeral()
    {
        Sistema.instancia.BotaoSom();
        Sistema.instancia.SetNomeTema("GERAL");
        AddPerguntas.Add_All();
        SceneManager.LoadScene("PreAll");
    }

}

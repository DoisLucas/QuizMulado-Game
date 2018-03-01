using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/* 
 *   Autor/Author: Pedro Lucas de Oliveira Cabral 
 *   GitHub: https://github.com/DoisLucas
 *   Data/Date: 29/01/2018
 */

public class Loja : MonoBehaviour
{

#if UNITY_IOS
	private string gameId = "1581950";
#elif UNITY_ANDROID
    private string gameId = "1581949";
#endif

    #region Variaveis

    private GameObject coringago;
    public GameObject confirmacao;
    public GameObject btnok;
    public GameObject vida;
    public GameObject reset;
    public GameObject recompensa;
    public GameObject[] vetor;

    public Sprite SpritePulo;
    public Sprite SpriteChance;
    public Sprite SpriteReset;
    public Sprite SpriteVida;

    public Image img;

    public Text txt;
    public Text quantidade;
    public Text valortotal;

    /* 
     * 1 = pulo
     * 2 = chance
     * 3 = estatistica
     * 4 = vida
    */

    int poderid = 0;
    int dinheiro = 0;

    private int valor;
    private int index;
    private int updatecall = 0;

    #endregion

    void Start()
    {
        dinheiro = PlayerPrefs.GetInt("Coins");
        Verificacao();
        recompensa.SetActive(false);
        vetor[27].GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
        vida.SetActive(false);
        reset.SetActive(false);    
        this.confirmacao.SetActive(false);    
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && !vida.activeInHierarchy && !reset.activeInHierarchy && !confirmacao.activeInHierarchy && !recompensa.activeInHierarchy)
        {
            Sistema.instancia.BotaoSom();
            SceneManager.LoadScene("Inicio");
        }

        if (Input.GetKeyDown(KeyCode.Escape) && vida.activeInHierarchy)
        {
            Sistema.instancia.BotaoSom();
            OffPopup(vida.GetComponent<Animation>());
        }

        if (Input.GetKeyDown(KeyCode.Escape) && reset.activeInHierarchy)
        {
            Sistema.instancia.BotaoSom();
            OffPopup(reset.GetComponent<Animation>());
        }

        if (Input.GetKeyDown(KeyCode.Escape) && confirmacao.activeInHierarchy)
        {
            Sistema.instancia.BotaoSom();
            OffPopup(confirmacao.GetComponent<Animation>());
        }

        if (updatecall == 1)
        {
            if (index > 10)
            {
                print("Máxima Unidade: 10");
            }
            else
            {
                if ((valor * index) > dinheiro)
                {
                    btnok.GetComponent<Selectable>().interactable = false;
                }
                else
                {
                    btnok.GetComponent<Selectable>().interactable = true;
                }
                quantidade.text = index.ToString();
                valortotal.text = "TOTAL: " + (valor * index).ToString();
            }
            updatecall = 0;
        }

        if (updatecall == 2)
        {
            LimparValores();
            Verificacao();
            vetor[27].GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
            updatecall = 0;
        }

    }

    public void Mais()
    {
        if (index < 10)
        {
            index += 1;
        }
        updatecall = 1;
    }

    public void Menos()
    {
        if (index != 1)
        {
            index -= 1;
        }
        updatecall = 1;
    }

    public void BotaoComprar()
    {
        if (coringago.name.Equals("poderChance"))
        {
            if ((valor * index) <= dinheiro)
            {
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - (valor * index));
                PlayerPrefs.SetInt("Chance", PlayerPrefs.GetInt("Chance") + index);
                updatecall = 2;
            }
        }
        else if (coringago.name.Equals("poderPulo"))
        {
            if ((valor * index) <= dinheiro)
            {
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - (valor * index));
                PlayerPrefs.SetInt("Pulos", PlayerPrefs.GetInt("Pulos") + index);
                updatecall = 2;
            }
        }
        else if (coringago.name.Equals("poderVida"))
        {
            if ((valor * index) <= dinheiro)
            {
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - (valor * index));
                PlayerPrefs.SetInt("Vida", PlayerPrefs.GetInt("Vida") + index);
                updatecall = 2;
            }
        }
        else if (coringago.name.Equals("poderEstatisticas"))
        {
            if ((valor * index) <= dinheiro)
            {
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - (valor * index));
                PlayerPrefs.SetInt("Reset", PlayerPrefs.GetInt("Reset") + index);
                updatecall = 2;
            }
        }
    }

    public void ShowPopupCompra(GameObject popup)
    {
        Sistema.instancia.BotaoSom();

        if (coringago.name.Equals("poderChance"))
        {
            valor = 250;
            index = 1;
            quantidade.text = index.ToString();
            valortotal.text = "TOTAL: " + valor.ToString();
        }
        else if (coringago.name.Equals("poderPulo"))
        {
            valor = 100;
            index = 1;
            quantidade.text = index.ToString();
            valortotal.text = "TOTAL: " + valor.ToString();
        }
        else if (coringago.name.Equals("poderVida"))
        {
            valor = 500;
            index = 1;
            quantidade.text = index.ToString();
            valortotal.text = "TOTAL: " + valor.ToString();
        }
        else if (coringago.name.Equals("poderEstatisticas"))
        {
            valor = 300;
            index = 1;
            quantidade.text = index.ToString();
            valortotal.text = "TOTAL: " + valor.ToString();
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i].GetComponent<Selectable>().interactable = false;
        }

        popup.SetActive(true);
        updatecall = 1;
    }

    public void ShowPopup(GameObject popup)
    {
        Sistema.instancia.BotaoSom();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i].GetComponent<Selectable>().interactable = false;
        }

        popup.SetActive(true);
    }

    public void OffPopup(Animation animpopup)
    {
        //Sistema.instancia.BotaoSom();
        for (int i = 0; i < vetor.Length; i++)
        {
            if ((i == 10) || (i == 5) || (i == 16) || (i == 21))
            {
                //vetor[i].GetComponent<Selectable>().interactable = false;
            }
            else
            {
                vetor[i].GetComponent<Selectable>().interactable = true;
            }
        }

        animpopup.Play("exitMotionSecond");
        Verificacao();
        StartCoroutine(ReativarCompra());
        
    }

    public void GameObjectCoringa(GameObject coringa)
    {
        this.coringago = coringa;
    }

    public void ChamarAnuncio()
    {
        AtivarRecompensa();

        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, true);
            ShowOptions options = new ShowOptions();
            options.resultCallback = HandleShowResult;
            Advertisement.Show("rewardedVideo", options);
        }
    }

    public void BotaoPegarRecompensa()
    {
        if (poderid == 1)
        {
            PlayerPrefs.SetInt("Pulos", PlayerPrefs.GetInt("Pulos") + 1);
        }
        else if (poderid == 2)
        {
            PlayerPrefs.SetInt("Chance", PlayerPrefs.GetInt("Chance") + 1);
        }
        else if (poderid == 3)
        {
            PlayerPrefs.SetInt("Reset", PlayerPrefs.GetInt("Reset") + 1);
        }
        else if (poderid == 4)
        {
            PlayerPrefs.SetInt("Vida", PlayerPrefs.GetInt("Vida") + 1);
        }

        OffPopup(recompensa.GetComponent<Animation>());
    }

    public void Verificacao()
    {
        if (dinheiro < 100)
        {
            vetor[10].GetComponent<Selectable>().interactable = false;
            vetor[5].GetComponent<Selectable>().interactable = false;
            vetor[21].GetComponent<Selectable>().interactable = false;
            vetor[16].GetComponent<Selectable>().interactable = false;
        }
        else if (dinheiro < 250)
        {
            vetor[5].GetComponent<Selectable>().interactable = false;
            vetor[21].GetComponent<Selectable>().interactable = false;
            vetor[16].GetComponent<Selectable>().interactable = false;
            vetor[10].GetComponent<Selectable>().interactable = true;
        }
        else if (dinheiro < 300)
        {
            vetor[21].GetComponent<Selectable>().interactable = false;
            vetor[16].GetComponent<Selectable>().interactable = false;
            vetor[10].GetComponent<Selectable>().interactable = true;
            vetor[5].GetComponent<Selectable>().interactable = true;
        }
        else if (dinheiro < 500)
        {
            vetor[16].GetComponent<Selectable>().interactable = false;
            vetor[21].GetComponent<Selectable>().interactable = true;
            vetor[10].GetComponent<Selectable>().interactable = true;
            vetor[5].GetComponent<Selectable>().interactable = true;
        }
        else if (dinheiro >= 500)
        {
            vetor[16].GetComponent<Selectable>().interactable = true;
            vetor[21].GetComponent<Selectable>().interactable = true;
            vetor[10].GetComponent<Selectable>().interactable = true;
            vetor[5].GetComponent<Selectable>().interactable = true;
        }
    }

    private void AtivarRecompensa()
    {
        /*
         *0-10 Poder pulo
         * 11-20 Poder Chance
         * 21-23 Poder Estatostoca
         * 24 Poder Vida
        */

        int randomIndex = Random.Range(0, 24);
        print(randomIndex);

        if (randomIndex >= 0 && randomIndex <= 10)
        {
            poderid = 1;
        }
        else if (randomIndex >= 11 && randomIndex <= 20)
        {
            poderid = 2;
        }
        else if (randomIndex >= 21 && randomIndex <= 23)
        {
            poderid = 3;
        }
        else if (randomIndex == 24)
        {
            poderid = 4;
        }
    }

    private void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            EscolhaPoder();
        }
        else if (result == ShowResult.Skipped)
        {
            //Pulo
        }
        else if (result == ShowResult.Failed)
        {
            //Falha
        }
    }

    private void EscolhaPoder()
    {
        if (poderid == 1)
        {
            img.sprite = SpritePulo;
            txt.text = "1X PODER DE PULO";
        }
        else if (poderid == 2)
        {
            img.sprite = SpriteChance;
            txt.text = "1X PODER DE CHANCE";
        }
        else if (poderid == 3)
        {
            img.sprite = SpriteReset;
            txt.text = "1X PODER DE RESETAR";
        }
        else if (poderid == 4)
        {
            img.sprite = SpriteVida;
            txt.text = "1X PODER DE VIDA";
        }

        StartCoroutine(MostraRecompensa());
    }

    private void LimparValores()
    {
        index = 1;
        dinheiro = PlayerPrefs.GetInt("Coins");
    }

    private IEnumerator MostraRecompensa()
    {
        yield return new WaitForSeconds(0.3f);
        ShowPopup(recompensa);
    }

    private IEnumerator ReativarCompra()
    {
        yield return new WaitForSeconds(0.07f);
        btnok.GetComponent<Selectable>().interactable = true;
    }

}

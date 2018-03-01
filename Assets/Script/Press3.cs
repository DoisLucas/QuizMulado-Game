using UnityEngine;
using UnityEngine.EventSystems;

/* 
 *   Autor/Author: Pedro Lucas de Oliveira Cabral 
 *   GitHub: https://github.com/DoisLucas
 *   Data/Date: 01/02/2018
 */

public class Press3 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    #region Variaveis

    public static bool mouseDown;
    public float timeMouseDown;
    public GameObject GameObjectPopup;
    public GameObject Script;

    #endregion

    void Start()
    {
        GameObjectPopup.SetActive(false);
    }

    void Update()
    {
        if (mouseDown)
        {
            timeMouseDown += Time.deltaTime;
            WhilePressed();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        mouseDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        mouseDown = false;
        timeMouseDown = 0;
    }

    public void WhilePressed()
    {
        if (timeMouseDown >= 1)
        {
            GameObjectPopup.SetActive(true);
            Script.GetComponent<Tema>().PopupOnPress();
            timeMouseDown = 0;
        }
    }

}



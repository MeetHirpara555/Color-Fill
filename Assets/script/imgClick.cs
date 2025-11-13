using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class imgClick : MonoBehaviour, IPointerClickHandler
{
    colorGen cc;
    // Start is called before the first frame update
    void Start()
    {
         cc = FindObjectOfType<colorGen>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
     
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject[] colorbtns = GameObject.FindGameObjectsWithTag("color");
        gameObject.GetComponent<Image>().color = colorbtns[cc.selectedColor].GetComponent<Image>().color;

    }
}

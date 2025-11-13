using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class colorGen : MonoBehaviour
{
    public GameObject colorholder,btnprefab;
    Color[] a = {Color.black };
    public int selectedColor;
    // Start is called before the first frame update
    void Start()
    {
        colorgen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void colorgen()
    {
        for (int i = 0; i < 8; i++)
        {
            GameObject g = Instantiate(btnprefab,colorholder.transform);
            int In = i;
            g.tag = "color";
            switch(i)
            {
                case 0: 
                    g.GetComponent<Image>().color = Color.white;
                    break;

                case 1:
                    g.GetComponent<Image>().color = Color.blue;
                    break;

                case 2:
                    g.GetComponent<Image>().color = Color.black;
                    break;

                case 3:
                    g.GetComponent<Image>().color = Color.cyan;
                    break;

                case 4:
                    g.GetComponent<Image>().color = Color.red;
                    break;

                case 5:
                    g.GetComponent<Image>().color = Color.yellow;
                    break;

                case 6:
                    g.GetComponent<Image>().color = Color.green;
                    break;

                case 7:
                    g.GetComponent<Image>().color = Color.magenta;
                    break;
            }
            
            g.GetComponent<Button>().onClick.AddListener(() => colorclick(In));
        }
    }

    void colorclick(int In)
    {
        selectedColor = In;
    }

   

    
    
}

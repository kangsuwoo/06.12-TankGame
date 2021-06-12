using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fireCount : MonoBehaviour
{

    public Text text;
    public int Count;

    void Start()
    {
        text.text = "Score : ";
    }
    public void PlusCount()
    {
       

            Count++;

            text.text = "Score : " + Count.ToString();
        
        if(Count == 10)
        {
            text.text = " Congratulation! ";
        }
    }

    

   
       
    

}

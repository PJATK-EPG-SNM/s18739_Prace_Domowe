using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
   public void Start()
    {   int a = 10;
        float b = 15.5f;    
        bool c = true;
        bool d = false;
        string p = "Programuję w C#";
        string e = "EPG";

        Warunki(a,b);
        Equals (p,e);
        Koniunkcja (c,d);
        Alternatywa (c,d);


        Debug.Log(" int: "+ a+ "; " + " float: "+ b + "; " + " bool: " + c  + ", "+ d + "; " +" strings: "+ p + ", "+ e+ ". ");
    }



    public void Warunki (int a, float b) {


                if(a == b)
                {
                    Debug.Log("Tak");
                } 
                else
                {
                    Debug.Log("Nie");
                } ;

                if(a >= b)
                {
                    Debug.Log("Tak");
                } else
                {
                    Debug.Log("Nie");
                    }; 

                if(a <= b)
                {
                    Debug.Log("Tak");
                } 
                else
                {
                    Debug.Log("Nie");
                    }; 
    }
    public void Equals(string p, string e){
        if (!p.Equals(e))
            Debug.Log("różne");
    }
        
    public void Koniunkcja(bool c, bool d) {
        Debug.Log("Koniunkcja c i d: " + (c && d));
    }
        
    public void Alternatywa(bool c, bool d){
        Debug.Log("Alternatywa c i d: " + (c || d));
    }
    
}

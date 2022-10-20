using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opgave2 : MonoBehaviour
{
    public string Name = "Ebuc";
    int level = 6;
    // Start is called before the first frame update
    void Start()
    {
        int outPutFromMethod;
        AdventureStatus(Name, level);
        outPutFromMethod = AdventureStatus("Ebuc",level);
     
        print("Woah level up! Your level is now "+outPutFromMethod);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Our cool adventure cube tells us his name and level
    /// Ebuc gains a level and that is returned
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    int AdventureStatus(string a, int b)
    {
        print("I'm the adventurer "+a+(" I am a proud ranger level " )+b);
        
        return b+1;

    }

}

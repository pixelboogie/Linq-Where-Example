using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // * Linq needed


public class Main : MonoBehaviour
{
    public string[] names = {"uno", "uno", "dos", "dos", "tres", "quatro"};

    void Start()
    {
        var result = names.Where(n => n.Length > 5);

        foreach(var name in result)
        {
            Debug.Log(name);
        }

    }
}

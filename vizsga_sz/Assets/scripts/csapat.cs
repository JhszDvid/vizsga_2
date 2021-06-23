using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csapat : MonoBehaviour
{
    public string nev;
    public string rovidites;

    public List<string> eredmenyek;

    public void addEredmeny(string result)
    {
        eredmenyek.Add(result);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eredmenyfelvetel_handler : MonoBehaviour
{
    public InputField csapat1;
    public InputField csapat2;
    public InputField eredmeny1;
    public InputField eredmeny2;


    private datahandler data;
    private void Start() {
        data = GetComponent<datahandler>();
    }

    void findCsapatok()
    {
        int count = 0;

        for(int i=0; i<data.csapatok.Count; i++)
        {
            if(csapat1.text.ToString() == data.csapatok[i].nev.ToString())
            {
                count++;
                
            }

            if(csapat2.text.ToString() == data.csapatok[i].nev.ToString())
            {
                count++;
            }

            
        }
        
        if(count > 0)
            Debug.Log("csapat1 helyes");
    }

    public void addEredmeny()
    {
        Debug.Log("SZIA");
        findCsapatok();
    }
}

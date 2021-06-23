using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class datahandler : MonoBehaviour
{
    
    public List<csapat> A;
    public List<csapat> B;
    public List<csapat> C;

   [HideInInspector] public List<csapat> csapatok;


    public Text textA;
    public Text textB;
    public Text textC;

   

    private void Start() {
        addTextToCsoport();
        loadCsapatok();
    }

    void addTextToCsoport()
    {
        if(textA == null) return;
        textA.text = "";
        textB.text = "";
        textC.text = "";
        for(int i=0; i<A.Count; i++)
        {
            textA.text += A[i].nev + "\n";
            
        }

        for(int i=0; i<B.Count; i++)
        {
            textB.text += B[i].nev + "\n";
            
        }

         for(int i=0; i<C.Count; i++)
        {
            textC.text += C[i].nev + "\n";
           
        }
    }

    void loadCsapatok()
    {
         for(int i=0; i<A.Count; i++)
        {
           
            csapatok.Add(A[i]);
        }

        for(int i=0; i<B.Count; i++)
        {
            
            csapatok.Add(B[i]);
        }

         for(int i=0; i<C.Count; i++)
        {
            
            csapatok.Add(C[i]);
        }
    }

    

    
}

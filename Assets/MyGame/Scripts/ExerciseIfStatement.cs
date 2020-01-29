using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseIfStatement : MonoBehaviour
{
    public bool condition;
    public string text;
    public string text2;
    
    // Start is called before the first frame update
    void Start()
    {
        if (condition)
        {
            //Debug.Log("Diese Aussage(Condition) ist richtig!");
        }
        else
        {
            Debug.Log("Diese Aussage(Condition) ist falsch!");
        }
    }

    // Update is called once per frame
    void Update()
    {

        // If Statement Float Values
        float rnd = Random.Range(5f,15f);

        if (rnd > 10)
        {
            //Debug.Log("Ist groeßer 10");
        }
        else
        {
            //Debug.Log("ist kleiner oder gleich 10");
        }

        // If Statement String Values
        if (text == text2)
        {
            //Debug.Log("Text1 entspricht Text2");
        }
        else
        {
            //Debug.Log("Text1 entspricht NICHT Text2");
        }

        // If Statement mit mehreren Konditionen

        // Mit dem && (Und) Operator - Beide müssen richtig sein
        if (text == text2 && condition)
        {
            Debug.Log("Beide Konditionen sind richtig");
        }


        // Mit dem || (Oder) Operator - Einer der beiden muss richtig sein
        if (text == text2 || condition) // Windows: AltGr + >     Mac: Alt + 7
        {
            Debug.Log("Eine der beiden Konditionen ist richtig");
        }
    }
}

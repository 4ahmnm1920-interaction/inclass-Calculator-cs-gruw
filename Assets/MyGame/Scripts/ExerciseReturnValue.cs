using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseReturnValue : MonoBehaviour
{
    public float value1;
    public float value2;

    void Start()
    {

    }

    private void Update()
    {
        Debug.Log(Random.Range(value1,value2) + Random.Range(value1,value2));
    }

    public int AddIntegers(int variable1, int variable2)
    {
        return (variable1 + variable2);
    }

    /*
    public int AddNumbers()
    {
        
    }
    */
    /*
    public float FloatReturnValue()
    {

    }

    public string StringReturnValue()
    {

    }
    */
}

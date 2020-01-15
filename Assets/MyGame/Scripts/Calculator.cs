using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField number1;
    public InputField number2;
    public Text operatorText;
    public Text resultText;

    public void AddNumbers()
    {
        operatorText.text = "+";
        float result = float.Parse(number1.text) + float.Parse(number2.text);
        Debug.Log(result);
        resultText.text = result.ToString();
    }

    public void SubtractNumbers()
    {
        operatorText.text = "-";
        float result = float.Parse(number1.text) - float.Parse(number2.text);
        Debug.Log(result);
        resultText.text = result.ToString();
    }

    public void MultiplyNumbers()
    {
        operatorText.text = "*";
        float result = float.Parse(number1.text) * float.Parse(number2.text);
        Debug.Log(result);
        resultText.text = result.ToString();
    }

    public void DivideNumbers()
    {
        operatorText.text = "/";
        float result = float.Parse(number1.text) / float.Parse(number2.text);
        Debug.Log(result);
        resultText.text = result.ToString();
    }
}

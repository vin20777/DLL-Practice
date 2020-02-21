using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CalculatorDll;

public class CalTechScript : MonoBehaviour
{
    CalculatorClass myDll;
    Text answerText;
    InputField num1;
    InputField num2;
    // Start is called before the first frame update
    void Start()
    {
        answerText = GameObject.Find("AnswerText").GetComponent<Text>();
        num1 = GameObject.Find("Num1InputField").GetComponent<InputField>();
        num2 = GameObject.Find("Num2InputField").GetComponent<InputField>();
        myDll = new CalculatorClass();
    }

    public void SumTwoNums()
    {
        int first = int.Parse(num1.text);
        int second = int.Parse(num2.text);
        answerText.text = (myDll.Add(first, second)).ToString();

    }

    public void SubstractNum()
    {
        int first = int.Parse(num1.text);
        int second = int.Parse(num2.text);
        answerText.text = (myDll.Substract(first, second)).ToString();
    }

    public void MultiplyNum()
    {
        int first = int.Parse(num1.text);
        int second = int.Parse(num2.text);
        answerText.text = (myDll.multiply(first, second)).ToString();
    }

    public void DivideNum()
    {
        int first = int.Parse(num1.text);
        int second = int.Parse(num2.text);
        answerText.text = (myDll.divide(first, second)).ToString();
    }
}

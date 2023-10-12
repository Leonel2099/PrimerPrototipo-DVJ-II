using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OperationBehaviour : MonoBehaviour
{
    private int operator01;
    private int operator02;
    public TMP_Text operationText;
    public int solution;
    public int numRandom;
    // Start is called before the first frame update
    void Start()
    {

        Invoke("GenerateNumbers", 0f);
        
    }

    public void GenerateNumbers()
    {
        numRandom = Random.Range (1, 5);
        operator01 = Random.Range (1, 21);
        operator02 = Random.Range (1, 21);
        solution = operator01 + operator02;
        
        operationText.text = operator01.ToString() + " + " + operator02.ToString() + " = ?" ;

        //Debug.Log(operator01);
       // Debug.Log(operator02);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

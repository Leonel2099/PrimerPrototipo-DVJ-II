using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.UI;
using TMPro;

public class ChangeColor : MonoBehaviour
{
    KeywordRecognizer keywordrecognizer;
    Dictionary<string, Action> wordToAction;

    Renderer rend;
    int randomNum, textureNum, textureNum2, textureNum3, textureNum4;

    private Color32 color;
    public Texture2D[] texturas;

    private int puntuacion;
    public TMP_Text score;

    Animator planetAnimation;
    bool nextPlanet;

    // Start is called before the first frame update
    void Start()
    {
        planetAnimation = GetComponent<Animator>();
        nextPlanet = false;

        wordToAction = new Dictionary<string, Action>();
        wordToAction.Add("verde", colorTextVerde);
        wordToAction.Add("celeste", colorTextCeleste);
        wordToAction.Add("azul", colorTextAzul);
        wordToAction.Add("naranja", colorTextNaranja);
        wordToAction.Add("rojo", colorTextRojo);
        wordToAction.Add("gris", colorTextGris);
        wordToAction.Add("blanco", colorTextBlanco);
        wordToAction.Add("negro", colorTextNegro);
        wordToAction.Add("rosa", colorTextRosa);
        wordToAction.Add("violeta", colorTextVioleta);
        wordToAction.Add("marrón", colorTextMarron);
        wordToAction.Add("amarillo", colorTextAmarillo);
        randomNum = UnityEngine.Random.Range(0, 24);

        
        rend = GetComponent<Renderer>();
        ChangeMaterial(randomNum);

        keywordrecognizer = new KeywordRecognizer(wordToAction.Keys.ToArray());
        keywordrecognizer.OnPhraseRecognized += WordRecognized;
        keywordrecognizer.Start();

        puntuacion = 0;

       
        
    }
    private void colorTextVerde()
    {
        textureNum = 0;
        textureNum2 = 4;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextCeleste()
    {
        textureNum = 7;
        textureNum2 = 17;
        textureNum3 = 23;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextAzul()
    {
        textureNum = 2;
        textureNum2 = 11;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextNaranja()
    {
        textureNum = 9;
        textureNum2 = 12;
        textureNum3 = 20;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextRojo()
    {
        textureNum = 18;
        textureNum2 = 22;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextGris()
    {
        textureNum = 6;
        textureNum2 = 14;
        textureNum3 = 21;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextBlanco()
    {
        textureNum = 1;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextNegro()
    {
        textureNum = 8;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextRosa()
    {
        textureNum = 5;
        textureNum2 = 13;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextVioleta()
    {
        textureNum = 16;
        textureNum2 = 19;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextMarron()
    {
        textureNum = 15;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }
    private void colorTextAmarillo()
    {
        textureNum = 3;

        colorMatch(textureNum, textureNum2, textureNum3, textureNum4, randomNum);
    }

    private void colorMatch(int colorText1, int colorText2, int colorText3, int colorText4, int random)
    {
        planetAnimation.SetBool("NextPlanet", true);
        if (colorText1 == random || colorText2 == random || colorText3 == random || colorText4 == random)
        {            
            Debug.Log("coidiceperrin");
            puntuacion+=10;
            score.text = "Score: " + puntuacion.ToString();
            WindowsVoice.speak("Bien hecho, eres un crack");
            randomNum = UnityEngine.Random.Range(0, 24);
            ChangeMaterial(randomNum);
        }
        else
        {
            Debug.Log("nocoicide");
            randomNum = UnityEngine.Random.Range(0, 24);
            WindowsVoice.speak("Lo siento, mejor suerte para la próxima");
            ChangeMaterial(randomNum);
        }
        
    }


    private void WordRecognized(PhraseRecognizedEventArgs word)
    {
        Debug.Log(word.text);
        wordToAction[word.text].Invoke();
    }
    public void ChangeMaterial(int random)
    {
        planetAnimation.SetBool("NextPlanet", false);
        switch (random)
        {
            case 0:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 1:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 2:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 3:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 4:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 5:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 6:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 7:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 8:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 9:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 10:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 11:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 12:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 13:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 14:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 15:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 16:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 17:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 18:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 19:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 20:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 21:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 22:
                rend.material.mainTexture = texturas[randomNum];
                break;
            case 23:
                rend.material.mainTexture = texturas[randomNum];
                break;
            
            default:
                break;
        }
    }
}

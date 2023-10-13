using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class CommandVoice : MonoBehaviour
{
    public float direccionZ = 0;
    public float direccionX = 0;
    // Start is called before the first frame update
    KeywordRecognizer keywordRecognizer; // creo mi reconocedor de comandode voz

    Dictionary<string, Action> actions = new Dictionary<string, Action>(); // creo las comando
    // Start is called before the first frame update
    void Start()
    {
        //creo las acciones segun el comandod e voz
        actions.Add("abajo",MoveDown);
        actions.Add("arriba",MoveUp);
        actions.Add("derecha",MoveRight);
        actions.Add("izquierda",MoveLeft);

        //seteo el ronocedor de voz y lo inicio
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
        
    }

    private void MoveUp()
    {
        Debug.Log("el personaje debe moverse hacia arriba");
        //WindowsVoice.speak("he dicho saltar");
        direccionZ = 1;
    }

    private void MoveDown()
    {
        Debug.Log("el personaje debe moverse hacia abajo");
        //WindowsVoice.speak("he dicho aba");
        direccionZ = -1;
    }

    private void MoveRight()
    {
        Debug.Log("el personaje debe moverse hacia la derecha");
        //WindowsVoice.speak("he dicho aba");
        direccionX = 1;
    }

    private void MoveLeft()
    {
        Debug.Log("el personaje debe moverse hacia la izquierda");
        //WindowsVoice.speak("he dicho aba");
        direccionX = -1;
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs command)
    {
       // Debug.Log(command.text);
        actions[command.text].Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


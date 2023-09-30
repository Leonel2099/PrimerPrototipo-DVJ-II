using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Windows.Speech;
using System.Linq;
using TMPro;

public class controlVocie : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, Action> wordToAction;
    Animator animator;
    void Start()
    {
        wordToAction = new Dictionary<string, Action>();
        wordToAction.Add("arriba", FlyUp);
        wordToAction.Add("abajo", FlyDown);
        keywordRecognizer = new KeywordRecognizer(wordToAction.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += WordRecognized;
        keywordRecognizer.Stop();
        animator = GetComponent<Animator>();
    }
    public void ButtonPressed()
    {
        Debug.Log("Voz Activada");
        keywordRecognizer.Start();
    }

    private void WordRecognized(PhraseRecognizedEventArgs word)
    {
        wordToAction[word.text].Invoke();
    }

    private void FlyDown()
    {
        Debug.Log("Volando hacia abajo");
        animator.SetBool("flyDown", true);
        animator.SetBool("flyUp", false);
    }

    private void FlyUp()
    {
        Debug.Log("Volando hacia arriba");
        animator.SetBool("flyUp", true);
        animator.SetBool("flyDown", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SolutionBehaviour : MonoBehaviour
{
    
    public OperationBehaviour operationBehaviour;
    public int random;
    public int s;

    public int numSolution;
    public int solutionValue;

    public TMP_Text solutionText;

    public CommandVoice commandVoice;
    public ScorePlayer scorePlayer;

    public TMP_Text scoreText;

    public SolutionBehaviour solutionBehaviour1, solutionBehaviour2, solutionBehaviour3, solutionBehaviour4;
    public Animator playerAnimation;
    

    // Start is called before the first frame update
    void Start()
    {
        
        GameObject player = GameObject.Find("Player");
        playerAnimation = player.GetComponent<Animator>();
        
        commandVoice = player.GetComponent<CommandVoice>();
        scorePlayer = player.GetComponent<ScorePlayer>();
       
        GameObject solution1 = GameObject.Find("Solution01");
        solutionBehaviour1 = solution1.GetComponent<SolutionBehaviour>();

        GameObject solution2 = GameObject.Find("Solution02");
        solutionBehaviour2 = solution2.GetComponent<SolutionBehaviour>();

        GameObject solution3 = GameObject.Find("Solution03");
        solutionBehaviour3 = solution3.GetComponent<SolutionBehaviour>();

        GameObject solution4 = GameObject.Find("Solution04");
        solutionBehaviour4 = solution4.GetComponent<SolutionBehaviour>();
   
        Invoke("AssignValues", 0.1f);    
    }

    /*public void numbers()
    {
       random = operationBehaviour.numRandom;
       s = operationBehaviour.solution;
       //Debug.Log("el numero random es " + random); 
       //Debug.Log("la solucion es " + s);
    }*/

    
    public void AssignValues()
    {
        random = operationBehaviour.numRandom;
        s = operationBehaviour.solution;

        switch (numSolution)
        {
            case 1:
            {
                if (random == numSolution)
                {
                    solutionValue = s;

                }
                else
                {
                    solutionValue = Random.Range (1, 51);
                }  
                solutionText.text = solutionValue.ToString();
            }
            break;

            case 2:
            {
                if (random == numSolution)
                {
                    solutionValue = s;

                }
                else
                {
                    solutionValue = Random.Range (1, 51);
                }
                solutionText.text = solutionValue.ToString();
            }
            break;

            case 3:
            {
                if (random == numSolution)
                {
                    solutionValue = s;

                }
                else
                {
                    solutionValue = Random.Range (1, 51);
                } 
                solutionText.text = solutionValue.ToString();  
            }
            break;

            default:
            {
                if (random == numSolution)
                {
                    solutionValue = s;

                }
                else
                {
                    solutionValue = Random.Range (1, 51);
                }
                solutionText.text = solutionValue.ToString();
                
            }
            break;    
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (random == numSolution)
            {
                WindowsVoice.speak("Felicidades acertaste");
                scorePlayer.score++;
                scoreText.text = "Score: " + scorePlayer.score.ToString();

                //Debug.Log ("Puntuacion :" + scorePlayer.score);
                
            }
            else
            {
                WindowsVoice.speak("Lo siento, mejor suerte la proxima");
                
            }
                commandVoice.direccionZ = 0;
                commandVoice.direccionX = 0;

                other.transform.position = new Vector3 (0.03f, 0f, -0.35f);
            playerAnimation.SetBool("Run", false);

            operationBehaviour.GenerateNumbers();

                solutionBehaviour1.AssignValues();
                solutionBehaviour2.AssignValues();
                solutionBehaviour3.AssignValues();
                solutionBehaviour4.AssignValues();
          
        }
        
    }

}

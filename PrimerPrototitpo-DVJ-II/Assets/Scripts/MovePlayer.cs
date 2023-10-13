using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 3;
    private float directionZ;
    private float directionX;
    private CommandVoice commandVoice;

    
    //public float yMin, yMax;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        commandVoice = GetComponent<CommandVoice>();
        directionZ = commandVoice.direccionZ;
        transform.Translate(0f, 0f, directionZ * speed * Time.deltaTime);

        directionX = commandVoice.direccionX;
        transform.Translate(directionX * speed * Time.deltaTime, 0f, 0f);

        //float y = Mathf.Clamp(transform.position.y, yMin, yMax);
        //transform.position = new Vector3(0f, y, -1f);
        
    }
}

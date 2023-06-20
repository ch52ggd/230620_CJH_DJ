using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;

    bool isChange = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isChange)
        {
            if(player.transform.position.x >= 2)
            {

            }
            else
            {

            }
        }
    }

    public void LeftMove()
    {
        isChange = false;
        player.transform.position -= new Vector3(10 * Time.deltaTime, 0, 0);
    }

    public void RightMove()
    {
        isChange = true;
        player.transform.position += new Vector3(10 * Time.deltaTime, 0, 0); 
    }
}

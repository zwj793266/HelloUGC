using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookEnmey : MonoBehaviour
{
    public GameObject Enmey;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      // 对摄像机的一些限制
      //  transform.position = new Vector3(transform.position.x,3,transform.position.z);
        transform.LookAt(Enmey.transform);
        if(transform.position.y>3)
        {
          transform.position = new Vector3(transform.position.x,3,transform.position.z);
        }

        if(transform.position.y<1)
        {
          transform.position = new Vector3(transform.position.x,1,transform.position.z);
        }

     //  transform.position =  new Vector3(transform.position.x,transform.position.y,Player.transform.position.z-1.5f);

        if(transform.position.x<Player.transform.position.x-1.5)
        {
               transform.position =  new Vector3( Player.transform.position.x-1.5f,transform.position.y,transform.position.z);
        }
        if(transform.position.x>Player.transform.position.x+1.5)
        {
            transform.position =  new Vector3( Player.transform.position.x+1.5f,transform.position.y,transform.position.z);
        }

/*
        if(transform.position.z<Player.transform.position.x-2.5)
        {
               transform.position =  new Vector3( transform.position.x,transform.position.y,Player.transform.position.z-2.5f);
        }
        if(transform.position.z>Player.transform.position.z+2.5)
        {
            transform.position =  new Vector3( transform.position.x+2.5f,transform.position.y,Player.transform.position.z+2.5f);
        }
*/


    }
}

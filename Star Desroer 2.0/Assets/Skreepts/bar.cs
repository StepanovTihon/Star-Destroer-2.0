using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{
    public ship script2Reference;
    // Start is called before the first frame update
    public void OnTriggerEnter (Collider other) {
       if(other.tag=="de"){
         
         script2Reference.jizn -= 30;
         other.transform.position= new Vector3(Random.Range(-5f,5f), 0, Random.Range(-5f,5f));
        }
        else{
           
           //Destroy(other.gameObject,.0f);
        }
    }
}
 
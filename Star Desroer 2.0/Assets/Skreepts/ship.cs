using UnityEngine;
using System.Collections;
using UnityEngine.UI ;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour {

    public Rigidbody Rigid;
    public Rigidbody RB;
    public float speedPower; 
    public Transform centerOfmass;
    private float torque = 10000000f;
    private Vector3 vel;
    public float currentSpeed=0; // actual tank speed
    public float maxSpeed = 2.5f; // maximal tank speed
    public float speedgo = 1f; // maximal tank speed
    public float speedto = 1f; // maximal tank speed
    public float speedtov = 1f; // maximal tank speed
    public Collider b;
    float kol= 6f;
    Vector3 tmpf; 
    public Collider Bg;
    public Collider Bgp;
    public GameObject Bga; 
    public GameObject p;
    public Text MyText1;
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject m;
    public GameObject h;
    public AudioClip zvu; 
    public float time=0;
    public float jizn=10000;
    public float ub=0;
    public float timezv=0;
    public float w = 0f;
    public float s = 0f;
    public float a = 0f;
    public float d = 0f; 
    public float tr = 0f;
    public SimpleHealthBar healthBar1;
    public SimpleHealthBar healthBar2;
    float fire;
    public void OnTriggerEnter (Collider other) {
        if(other.gameObject!=Bg.gameObject) {
            //Destroy(other.gameObject,.0f);
        }



    }
    public void Wa (int q) {
      if(q==1){  
        w=1;
      }
      if(q==0){  
        w=0;
      }

    }
    public void Sa (int q) {
      if(q==1){  
        s=-1;
      }
      if(q==0){  
        s=0;
      }
    }
    public void Aa (int q) {
      if(q==1){  
        a=-1;
      }
      if(q==0){  
        a=0;
      }
    }
    public void Da (int q) {
      if(q==1){  
        d=1;
      }
      if(q==0){  
        d=0;
      }
    }
    public void Fi (int q) {
      if(q==1){  
        fire=1;
      }
      if(q==0){  
        fire=0;
      }
    }
    public void j () {

      jizn-=1;
 


        
    }
    void Start () {
        transform.rotation *= Quaternion.Euler(0f, 0f, -23.0f* speedto);
        // set centre of mass
        Rigid.centerOfMass = centerOfmass.localPosition;
        for (int i = 0; i < 100; i++) {
           Instantiate(a1);
           tmpf=a1.transform.position;
           a1.transform.position= tmpf+new Vector3(Random.Range(-33f,33f), Random.Range(-33f,33f), Random.Range(-10f,10f));
        }
        for (int i = 0; i < 100; i++) {
           Instantiate(a2);
           tmpf=a2.transform.position;
           a2.transform.position= tmpf+new Vector3(Random.Range(-33f,33f), Random.Range(-33f,33f), Random.Range(-10f,10f));
        }
        for (int i = 0; i < 100; i++) {
           Instantiate(a3);
           tmpf=a3.transform.position;

           a3.transform.position= tmpf+new Vector3(Random.Range(-33f,33f), Random.Range(-33f,33f), Random.Range(-10f,10f));
        }
        // max rotation speed
        Rigid.maxAngularVelocity = 1f;
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;

        for (int i = 0; i < 3; i++) {
           Instantiate(h);
           tmpf=h.transform.position;

           h.transform.position= tmpf+new Vector3(Random.Range(-53f,53f), 0, Random.Range(-53f,53f));
        }
        for (int i = 0; i < 3; i++) {
          Instantiate(b);
          tmpf=b.transform.position;
          //Instantiate(m);

          //m.transform.position= tmpf+new Vector3(Random.Range(-23f,23f), 0, Random.Range(-23f,23f));
          b.transform.position= tmpf+new Vector3(Random.Range(-23f,23f), 0, Random.Range(-23f,23f));
        }

    }
    public void go(int a)
    {
        if(a>0){

          Vector3 movement = new Vector3(0.0f,  0.0f, 0.3f);



          
          //Rigid.AddRelativeForce(movement); 
          //Rigid.AddRelativeForce(Vector3.forward * 1);
          //transform.position += transform.up * Time.deltaTime*-5;
        }
        if(a<0){

          Vector3 movement = new Vector3(0.0f, 0.0f, -0.3f);

          
           
          //Rigid.AddRelativeForce(movement); 
          //Rigid.AddRelativeForce(Vector3.forward * -1);
          //transform.position += transform.up * Time.deltaTime*5;  

        }
 



    }
    public void t(int a)
    {
        if(a>0){
             
           

          //Rigid.AddTorque(transform.up * torque * 1);
          Rigid.transform.Rotate(0.0f, -1.0f, 0.0f, Space.World);
        }
        if(a<0){
          
  
          //Rigid.AddTorque(transform.up * torque * -1);
          Rigid.transform.Rotate(0.0f, 1.0f, 0.0f, Space.World);
        }
 



    }
    void FixedUpdate()
    {
        healthBar1.UpdateBar( jizn, 100 );
        healthBar2.UpdateBar( currentSpeed+150, 300 );
        
        if(jizn<=0){
          Destroy(gameObject,.0f);
        }
        tr+=1;
        if(tr>200){
           b.transform.position= new Vector3(0, 0, 32);
           Instantiate(b);
           tr=0;
           jizn+=1;
           b.transform.position= new Vector3(10000,10000,10000);
        }
        MyText1.text=ub+"";

        GlobalData.abc = speedgo;
        //fire = Input.GetAxis("Fire1");
        //float niz = Input.GetAxis("Fire2");
        //float verh = Input.GetAxis("Fire3");
        float turn =a+d/2; //Input.GetAxis("Horizontal");
        float moveVertical = w+s;//Input.GetAxis("Vertical");
        //w=0;s=0;a=0;d=0;
        //Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);
        if(timezv>100){
            //GetComponent<AudioSource> ().volume =(0);
        }

        //if (currentSpeed < maxSpeed)
        //{
        //    Rigid.AddRelativeForce(movement * speedPower); 
        //}
        transform.rotation *= Quaternion.Euler(0f, 0f, 23.0f* speedto);
        //Rigid.transform.Rotate(0.0f, 0.0f, -15.0f* speedto, Space.World);
        speedto = (float) (((turn*3)) * 0.05 + (1.0 - 0.05) * speedto);
        Rigid.transform.Rotate(0.0f, 1.0f* speedto, 0.0f, Space.World);
        
        //speedtov = (float) (((transform.eulerAngles.z)) * 0.9 + (1.0 - 0.1) * speedtov);

        //Rigid.transform.Rotate(0.0f, 0.0f, 15.0f* speedto, Space.World);
        transform.rotation *= Quaternion.Euler(0f, 0f, -23.0f* speedto);
        currentSpeed+=(moveVertical*1);

        speedgo = (float) (((currentSpeed)) * 0.01 + (1.0 - 0.01) * speedgo);
        //speedgo = (float) (((currentSpeed) + speedgo) * 0.01f + (1.0f - 0.5f) * speedgo);
        transform.position += transform.forward * Time.deltaTime*speedgo;  
        if(moveVertical>0){
            go(1);
        }

        //if(moveVertical<0){
        //    go(-1);
        //}
        if(turn>0){
            //t(-1);
        }
        
        if(turn<0){
            //t(1);
        }
        //if(verh>0){
            //transform.rotation *= Quaternion.Euler(-0.9f, 0f, 0f);
        //}
        //if(niz>0){
            //transform.rotation *= Quaternion.Euler(0.9f, 0f, 0f);
        //}
        //Rigid.AddTorque(transform.up * torque * turn);
        //go(1);
        //t(1);
        time+=1;
        timezv+=1;
        if(fire==1 && time>10){
            GetComponent<AudioSource> ().volume =(1);
            GetComponent<AudioSource> ().PlayOneShot(zvu);
            time=0; 
            timezv=0;      

            float tmp=p.transform.eulerAngles.z;
            Instantiate(Bg,p.transform.position,transform.rotation);  



          
             
            
  
        } 
        if(Mathf.Abs(Bg.transform.position.z-p.transform.position.z)>=100){
            Bg.transform.position=p.transform.position;



        }
        if(Mathf.Abs(Bgp.transform.position.z-p.transform.position.z)>=100){
            Bgp.transform.position=p.transform.position;



        }
    }


    void Update () {


        vel = Rigid.velocity;
        



    }
}
public static class GlobalData
{
    public static float abc;
    
}

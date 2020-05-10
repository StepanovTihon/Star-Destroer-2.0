using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI ;
public class bot : MonoBehaviour {
    public Text MyText1;
    public Collider b;
    public Collider p;
    public GameObject Bg;
    //b.transform.position.x
    public Rigidbody Rigid;
    public float speedPower; 
    public Transform centerOfmass;
    private float torque = 10000000f;
    private Vector3 vel;
    public float currentSpeed; // actual tank speed
    public float maxSpeed = 2.5f; // maximal tank speed
    public float speedgo = 1f; // maximal tank speed
    float tmp= 0f;
    float ost= 0f;
    float kol= 3f;
    double G=0;
    public Collider pul;
    public GameObject r;
    Vector3 tmpf;
    public float speedto = 1f; // maximal tank speed
    //b.transform.position.x

    void Start () {
        // set centre of mass
        Rigid.centerOfMass = centerOfmass.localPosition;

        // max rotation speed
        Rigid.maxAngularVelocity = 6f;
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;

    }
    public void go(int a)
    {
        if(a>0){

          Vector3 movement = new Vector3(0.0f,  0.0f, 0.3f);



          
          //Rigid.AddRelativeForce(movement); 
          //Rigid.AddRelativeForce(Vector3.forward * 1);
          transform.position += transform.up * Time.deltaTime*-5;
        }
        if(a<0){

          Vector3 movement = new Vector3(0.0f, 0.0f, -0.3f);

          
           
          //Rigid.AddRelativeForce(movement); 
          //Rigid.AddRelativeForce(Vector3.forward * -1);
          transform.position += transform.up * Time.deltaTime*5;  

        }
 



    }
    public void t(int a)
    {
        double x1 = p.transform.position.x, y1 = p.transform.position.z;
        double x2 = b.transform.position.x, y2 = b.transform.position.z;
        G =Math.Atan2(y1 - y2, x1 - x2) / Math.PI*180;
       /* if(G>0){
            G=Math.Abs(G*-1-180)%360;
        }
        else {
            G=Math.Abs(G-270)%360;
        }*/
        G = (G < 0) ? (G+90) + 360 : G;  
        G=G*-1;
        tmp=b.transform.localEulerAngles.y;
        //tmp = (tmp < 0) ? tmp + 360 : tmp; 
        if(Math.Abs((G-tmp)%360)<Math.Abs((tmp-G-180)%360)){ 
          if(Math.Abs((G-tmp)%360)<=20){
              speedgo = (float) (((25)) * 0.1f + (1.0f - 0.1f) * speedgo);
          }    
          else{
              speedgo = (float) (((0)) * 0.1f + (1.0f - 0.1f) * speedgo);
          }
          if(Math.Abs((G-tmp)%360)<=5){
            float tmp=r.transform.eulerAngles.z;
            Instantiate(pul,r.transform.position,transform.rotation);  
          }
          speedto = (float) (((15)) * 0.1 + (1.0 - 0.1) * speedto);
          //Rigid.AddTorque(transform.up * torque * 1);
          //Rigid.transform.Rotate(0.0f,+3.0f, 0.0f, Space.World);
        }
        else{ 
          if(Math.Abs((tmp-G-180)%360)<=20){
              speedgo = (float) (((25)) * 0.1f + (1.0f - 0.1f) * speedgo);
          }    
          else{
              speedgo = (float) (((0)) * 0.1f + (1.0f - 0.1f) * speedgo);
          }  
          if(Math.Abs((tmp-G-180)%360)<=5){
            if(ost==0){
              float tmp=r.transform.eulerAngles.z;
              Instantiate(pul,r.transform.position,transform.rotation);  
              ost=5;
            }
            ost-=1;
          }
          speedto = (float) (((-15)) * 0.1 + (1.0 - 0.1) * speedto);
          //Rigid.AddTorque(transform.up * torque * -1);
         // Rigid.transform.Rotate(0.0f, -3.0f, 0.0f, Space.World);
        }




    }
    void FixedUpdate()
    {
        
        float turn = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);
        Rigid.transform.Rotate(0.0f, 1.0f* speedto, 0.0f, Space.World);
        //if (currentSpeed < maxSpeed)
        //{
        //    Rigid.AddRelativeForce(movement * speedPower); 
        //}
        //speedgo = (float) (((moveVertical*5)) * 0.1f + (1.0f - 0.1f) * speedgo);
        transform.position += transform.up * Time.deltaTime*speedgo*-1;  
        //if(moveVertical>0){
        //    go(1);
        //}

        //if(moveVertical<0){
        //    go(-1);
        //}
        if(turn>0){
            t(0);
        }
        //MyText1.text =  (Math.Abs((tmp-G-180)%360)) +"  ";
        if(turn<0){
            t(0);
        }

        //Rigid.AddTorque(transform.up * torque * turn);
        //go(1);
        t(0);

    }


    void Update () {


        vel = Rigid.velocity;
        currentSpeed = vel.magnitude;



    }
}

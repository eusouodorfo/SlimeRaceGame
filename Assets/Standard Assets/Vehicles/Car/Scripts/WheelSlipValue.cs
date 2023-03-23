using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSlipValue : MonoBehaviour
{
   WheelCollider WheelC;
   public float RoadForwardStiffness = 3f;
   public float TerrainForwardStiffness = 0.6f;
   public float RoadSidewayStiffness = 1.1f;
   public float TerrainSidewayStiffness = 0.2f;
   private bool Changed = false;
   

   void Start(){
      WheelC = GetComponent<WheelCollider>();
   }

   void Update(){

      if(SaveScript.OnTheRoad == true){
         if(Changed == false){
            Changed = true;
            WheelFrictionCurve fFriction = WheelC.forwardFriction;
            fFriction.stiffness = RoadForwardStiffness;
            WheelC.forwardFriction = fFriction;

            WheelFrictionCurve sFriction = WheelC.sidewaysFriction;
            sFriction.stiffness = RoadSidewayStiffness;
            WheelC.sidewaysFriction = sFriction;
         }
      }

      if(SaveScript.OnTheTerrain == true){
         if(Changed == true){
            Changed = false;
            WheelFrictionCurve fFriction = WheelC.forwardFriction;
            fFriction.stiffness = TerrainForwardStiffness;
            WheelC.forwardFriction = fFriction;

            WheelFrictionCurve sFriction = WheelC.sidewaysFriction;
            sFriction.stiffness = TerrainSidewayStiffness;
            WheelC.sidewaysFriction = sFriction;
         }
      }
   }
}

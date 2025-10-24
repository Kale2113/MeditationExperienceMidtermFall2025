using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1MenuManager : MonoBehaviour
{
    public BreathingBubble breathingBubble;
   // public string orbitTag = "OrbitTarget"; // tag assigned to all planets
   // private RotateAround[] orbitScripts; // store all planets

    void Start()
    {
        //GameObject[] orbitObjects = GameObject.FindGameObjectsWithTag(orbitTag);
       // if (orbitObjects.Length > 0)
       // {
         //   orbitScripts = new RotateAround[orbitObjects.Length];
          //  for (int i = 0; i < orbitObjects.Length; i++)
            {
          //      RotateAround script = orbitObjects[i].GetComponent<RotateAround>();
          //      if (script != null)
          //          orbitScripts[i] = script;
          //      else
           //         Debug.LogWarning($"Object tagged '{orbitTag}' has no RotateAround script.");
            }
        }
       // else
      //  {
       //     Debug.LogWarning($"No GameObjects found with tag '{orbitTag}'.");
       // }
   // }

   // public void PlayOrbit()
   // {
    //    if (orbitScripts == null) return;
        //
     //   foreach (var script in orbitScripts)
    //    {
     //       if (script != null)
     //           script.rotate = true; // enable rotation for all
     //   }
    //}

//    public void PauseOrbit()
//    {
//        if (orbitScripts == null) return;
//
 //       foreach (var script in orbitScripts)
 //       {
  //          if (script != null)
   //             script.rotate = false; // disable rotation for all
   //     }
  //  }

    public void TurnBubbleOn()
    {
        if (breathingBubble != null)
            breathingBubble.Show(true);
    }

    public void TurnBubbleOff()
    {
        if (breathingBubble != null)
            breathingBubble.Show(false);
    }
}

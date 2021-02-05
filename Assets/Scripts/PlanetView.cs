using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlanetView : MonoBehaviour
{
    public GameObject Planet;
    public float SpeedRotation = 2f;
    
    public void FixedUpdate()
    {
        Planet.transform.Rotate(0,0,SpeedRotation);
    }
}

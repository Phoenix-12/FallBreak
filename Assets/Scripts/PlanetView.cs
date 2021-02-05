using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlanetView : MonoBehaviour
{
    public GameObject Planet;
    [SerializeField]public float SpeedRotation;
    
    public void FixedUpdate()
    {
        Planet.transform.Rotate(0,0,SpeedRotation);
    }
}

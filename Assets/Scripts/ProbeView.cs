using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeView : MonoBehaviour
{
    public GameObject Probe;
    [SerializeField] public float SpeedProbe;
    
    public void FixedUpdate()
    {
        Probe.transform.Translate(0,SpeedProbe,0);
    }
}

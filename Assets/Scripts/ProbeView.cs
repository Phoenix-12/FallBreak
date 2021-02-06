using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeView : MonoBehaviour
{
    public GameObject Probe;
    public float SpeedProbe;

    public GameObject planet;
    
    public PlanetView PlanetView;

    public void Start()
    {
        planet = GameObject.Find("Planet");
    }

    public void FixedUpdate()
    {
        Probe.transform.Translate(0,SpeedProbe,0);
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider);
        SpeedProbe = 0;
        Probe.transform.parent = planet.transform;
    }
    public void Update()
    {

    }
}

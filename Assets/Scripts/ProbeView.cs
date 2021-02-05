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

    void OnTriggerEnter(Collider collision)
    {
        SpeedProbe = 0;
        Debug.Log(planet);
        Probe.transform.parent = planet.transform;
    }
    public void Update()
    {

    }
}

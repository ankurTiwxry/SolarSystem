using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlanetManager : MonoBehaviour
{
    // to call the script called planet
    public GameObject Planet_GO;
    Planet planet;

    public Slider slider;    

    // to instantiate planets
    //public GameObject Earth; // sphere called earth
    public Transform MercuryTransform = default;
    public Transform VenusTransform = default;
    public Transform EarthTransform = default;
    public Transform MarsTransform = default;
    public Transform JupiterTransform = default;
    public Transform SaturnTransform = default;
    public Transform UranusTransform = default;
    public Transform NeptuneTransform = default;

    public Transform reset = default;

    public Transform cameraTransform = default;
    public Transform target = default;

    float[] MercuryData = new float[5];
    float[] VenusData   = new float[5];
    float[] EarthData   = new float[5];
    float[] MarsData    = new float[5];
    float[] JupiterData = new float[5];
    float[] SaturnData  = new float[5];
    float[] UranusData  = new float[5];
    float[] NeptuneData = new float[5];

    bool Cam0 = false;
    bool Cam1 = false;
    bool Cam2 = false;
    bool Cam3 = false;
    bool Cam4 = false;
    bool Cam5 = false;
    bool Cam6 = false;
    bool Cam7 = false;
    bool Cam_reset = false;
    
    bool Cam0_1 = false;
    bool Cam1_1 = false;
    bool Cam2_1 = false;
    bool Cam3_1 = false;
    bool Cam4_1 = false;
    bool Cam5_1 = false;
    bool Cam6_1 = false;
    bool Cam7_1 = false;

    


    // Common Attributes
    public float speed = 10.0f;

    float timecounter_1 = 0.0f;
    float timecounter_2 = 0.0f;
    float timecounter_3 = 0.0f;
    float timecounter_4 = 0.0f;
    float timecounter_5 = 0.0f;
    float timecounter_6 = 0.0f;
    float timecounter_7 = 0.0f;
    float timecounter_8 = 0.0f;

    private void Awake()
    {
        planet = Planet_GO.GetComponent<Planet>();
        //cameraManager = CameraManager.GetComponent<CameraManager>();
        PlanetData();
        CreatePlanets();
    }

    void Update()
    {
        MovePlanets();
    }

    private void LateUpdate()
    {
        ChooseCamera();
    }

    // Import Planet Data
    void PlanetData()
    {
        MercuryData = planet.Mercury();
        VenusData = planet.Venus();
        EarthData = planet.Earth();
        MarsData = planet.Mars();
        JupiterData = planet.Jupiter();
        SaturnData = planet.Saturn();
        UranusData = planet.Uranus();
        NeptuneData = planet.Neptune();
    }

    // Create Planets
    void CreatePlanets()
    {
        CreateMercury();
        CreateVenus();
        CreateEarth();
        CreateMars();
        CreateJupiter();
        CreateSaturn();
        CreateUranus();
        CreateNeptune();

        CreateCamera();
    }

        // Move Planets
    void MovePlanets()
    {
        MoveEarth();
        MoveMercury();
        MoveVenus();
        MoveMars();
        MoveJupiter();
        MoveSaturn();
        MoveUranus();
        MoveNeptune();
    }



    void CreateMercury()
    {
        Transform point = Instantiate(MercuryTransform);
        point.localPosition = new Vector3(MercuryData[2], 0.0f, 0.0f);
        MercuryTransform = point;
    }

    void CreateVenus()
    {
        Transform point = Instantiate(VenusTransform);
        point.localPosition = new Vector3(VenusData[2], 0.0f, 0.0f);
        VenusTransform = point;
    }

    void CreateEarth()
    {
        Transform point = Instantiate(EarthTransform);
        point.localPosition = new Vector3(EarthData[2], 0.0f, 0.0f);
        EarthTransform = point;
    }

    void CreateMars()
    {
        Transform point = Instantiate(MarsTransform);
        point.localPosition = new Vector3(MarsData[2], 0.0f, 0.0f);
        MarsTransform = point;
    }

    void CreateJupiter()
    {
        Transform point = Instantiate(JupiterTransform);
        point.localPosition = new Vector3(JupiterData[2], 0.0f, 0.0f);
        JupiterTransform = point;
    }

    void CreateSaturn()
    {
        Transform point = Instantiate(SaturnTransform);
        point.localPosition = new Vector3(SaturnData[2], 0.0f, 0.0f);
        SaturnTransform = point;
    }

    void CreateUranus()
    {
        Transform point = Instantiate(UranusTransform);
        point.localPosition = new Vector3(UranusData[2], 0.0f, 0.0f);
        UranusTransform = point;
    }

    void CreateNeptune()
    {
        Transform point = Instantiate(NeptuneTransform);
        point.localPosition = new Vector3(NeptuneData[2], 0.0f, 0.0f);
        NeptuneTransform = point;
    }


    // CAMERA
    // ---------------------------------------------------------------------
    void CreateCamera()
    {
        Transform point = cameraTransform;
        point.localPosition = new Vector3(0.0f, 0.0f, -175.0f);
        cameraTransform = point;
    }

    void ChooseCamera()
    {
        if(Cam0)
        {
            MoveCamera(MercuryTransform, 1.0f);

        }
        if (Cam1)
        {
            MoveCamera(VenusTransform, 1.5f);
        }

        if (Cam2)
        {
            MoveCamera(EarthTransform, 1.5f);
        }

        if (Cam3)
        {
            MoveCamera(MarsTransform, 1.2f);
        }

        if (Cam4)
        {
            MoveCamera(JupiterTransform, 14.0f);
        }

        if (Cam5)
        {
            MoveCamera(SaturnTransform, 12.0f);
        }

        if (Cam6)
        {
            MoveCamera(UranusTransform, 8.0f);
        }

        if (Cam7)
        {
            MoveCamera(NeptuneTransform, 9.0f);
        }

        if (Cam0_1)
        {
            MoveCamera_1(MercuryTransform, 15.0f);

        }
        if (Cam1_1)
        {
            MoveCamera_1(VenusTransform, 22f);
        }

        if (Cam2_1)
        {
            MoveCamera_1(EarthTransform, 24f);
        }

        if (Cam3_1)
        {
            MoveCamera_1(MarsTransform, 18f);
        }

        if (Cam4_1)
        {
            MoveCamera_1(JupiterTransform, 45f);
        }

        if (Cam5_1)
        {
            MoveCamera_1(SaturnTransform, 39f);
        }

        if (Cam6_1)
        {
            MoveCamera_1(UranusTransform, 31f);
        }

        if (Cam7_1)
        {
            MoveCamera_1(NeptuneTransform, 33f);
        }

        if (Cam_reset)
        {
            MoveCamera(reset, 0.0f);
        }
    }
    

    public void EnableMercuryCamera()
    {
        Cam0 = true;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;

        Cam_reset = false;
    }
    public void EnableVenusCamera()
    {
        Cam0 = false;
        Cam1 = true;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }
    public void EnableEarthCamera()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = true;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }
    public void EnableMarsCamera()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = true;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }

    public void EnableJupiterCamera()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = true;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }

    public void EnableSaturnCamera()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = true;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }

    public void EnableUranusCamera()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = true;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }

    public void EnableNeptuneCamera()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = true;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }

    public void EnableMercuryCamera_1()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = true;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }
    public void EnableVenusCamera_1()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = true;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }
    public void EnableEarthCamera_1()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = true;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }
    public void EnableMarsCamera_1()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = true;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }

    public void EnableJupiterCamera_1()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = true;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }

    public void EnableSaturnCamera_1()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = true;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = false;
    }

    public void EnableUranusCamera_1()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = true;
        Cam7_1 = false;
        Cam_reset = false;
    }

    public void EnableNeptuneCamera_1()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = true;
        Cam_reset = false;
    }

    public void EnableResetCam()
    {
        Cam0 = false;
        Cam1 = false;
        Cam2 = false;
        Cam3 = false;
        Cam4 = false;
        Cam5 = false;
        Cam6 = false;
        Cam7 = false;
        Cam0_1 = false;
        Cam1_1 = false;
        Cam2_1 = false;
        Cam3_1 = false;
        Cam4_1 = false;
        Cam5_1 = false;
        Cam6_1 = false;
        Cam7_1 = false;
        Cam_reset = true;
    }

    void MoveCamera(Transform planetTransform, float mul)
    {
        Transform cam_point = cameraTransform;
        cam_point.localPosition = planetTransform.localPosition + new Vector3(mul, 0.0f, mul);
        cam_point.transform.LookAt(target, Vector3.up);
    }

    void MoveCamera_1(Transform planetTransform, float mul)
    {
        Transform cam_point = cameraTransform;
        cam_point.localPosition = planetTransform.localPosition + new Vector3(mul, 20.0f, mul);
        cam_point.transform.LookAt(target, Vector3.up);
    }

    public float sliderUI()
    {
        return slider.value;
    }
    // MOVE PLANETS
    // ------------------------------------------------------------------------------------------
    void MoveMercury()
    {
        Transform new_point = MercuryTransform;
        timecounter_1 += speed * Time.deltaTime * PlanetSpeed(MercuryData[4], new_point.localPosition);
        new_point.localPosition = CalculatePosition(MercuryData[0], MercuryData[1], new_point, timecounter_1);
    }

    
    
    void MoveVenus()
    {
        Transform new_point = VenusTransform;
        timecounter_2 += speed * Time.deltaTime * PlanetSpeed(VenusData[4], new_point.localPosition);
        new_point.localPosition = CalculatePosition(VenusData[0], VenusData[1], new_point, timecounter_2);
    }
    void MoveEarth()
    {
        Transform new_point = EarthTransform;
        timecounter_3 += speed * Time.deltaTime * PlanetSpeed(EarthData[4], new_point.localPosition);
        new_point.localPosition = CalculatePosition(EarthData[0], EarthData[1], new_point, timecounter_3);
    }

    

    void MoveMars()
    {
        Transform new_point = MarsTransform;
        timecounter_4 += speed * Time.deltaTime * PlanetSpeed(MarsData[4], new_point.localPosition);
        new_point.localPosition = CalculatePosition(MarsData[0], MarsData[1], new_point, timecounter_4);

    } 

    void MoveJupiter()
    {
        Transform new_point = JupiterTransform;
        timecounter_5 += speed * Time.deltaTime * PlanetSpeed(JupiterData[4], new_point.localPosition);
        new_point.localPosition = CalculatePosition(JupiterData[0], JupiterData[1], new_point, timecounter_5);
    }

    void MoveSaturn()
    {
        Transform new_point = SaturnTransform;
        timecounter_6 += speed * Time.deltaTime * PlanetSpeed(SaturnData[4], new_point.localPosition);
        new_point.localPosition = CalculatePosition(SaturnData[0], SaturnData[1], new_point, timecounter_6);
    }

    void MoveUranus()
    {
        Transform new_point = UranusTransform;
        timecounter_7 += speed * Time.deltaTime * PlanetSpeed(UranusData[4], new_point.localPosition);
        new_point.localPosition = CalculatePosition(UranusData[0], UranusData[1], new_point, timecounter_7);
    }

    void MoveNeptune()
    {
        Transform new_point = NeptuneTransform;
        timecounter_8 += speed * Time.deltaTime * PlanetSpeed(NeptuneData[4],new_point.localPosition);
        new_point.localPosition = CalculatePosition(NeptuneData[0], NeptuneData[1], new_point, timecounter_8);
    }

    

    Vector3 CalculatePosition(float a, float b, Transform new_pt, float timecounter)
    {
        Vector3 pos = new_pt.localPosition;

        pos.x = a * Mathf.Cos(timecounter);
        pos.y = 0.0f;
        pos.z = b * Mathf.Sin(timecounter);

        return pos;
    }

    float PlanetSpeed(float multiplier, Vector3 current_pos)
    {
        float root_r = Mathf.Pow(Mathf.Pow(current_pos.x, 2) + Mathf.Pow(current_pos.z, 2), 0.5f);
        return (multiplier / root_r) * sliderUI();
    }

    public void CloseSolarSystem()
    {
        Application.Quit();
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    float AU_a = 1.0f * 150.0f;
    float AU_p = 1.033f * 150.0f;

    float AU_s = 1.0f;

    public float[] Mercury()
    {
        float speedMultiplier = 0.596f * AU_s;
        float e = 0.205f;
        float apogee = 0.459f * AU_a;
        float perigee = 0.313f * AU_p;
        float a = (apogee + perigee) / 2;
        float b = a * Mathf.Pow((1 - Mathf.Pow(e, 2)), 0.5f);
                

        float[] planetData = { a, b, apogee, perigee, speedMultiplier };
        return planetData; 
    }

    public float[] Venus()
    {
        float speedMultiplier = 0.815f * AU_s;
        float e = 0.0068f;
        float apogee = 0.716f * AU_a;
        float perigee = 0.731f * AU_p;
        float a = (apogee + perigee) / 2;
        float b = a * Mathf.Pow((1 - Mathf.Pow(e, 2)), 0.5f);

        float[] planetData = { a, b, apogee, perigee, speedMultiplier };
        return planetData;
    }

    public float[] Earth()
    {
        float speedMultiplier = 1.0f * AU_s;
        float e = 0.0167f;
        float apogee = AU_a;
        float perigee = AU_p;
        float a = (apogee + perigee) / 2;
        float b = a * Mathf.Pow((1 - Mathf.Pow(e, 2)), 0.5f);

        float[] planetData = { a, b, apogee, perigee, speedMultiplier };
        return planetData;
    }

    public float[] Mars()
    {
        float speedMultiplier = 1.452f * AU_s;
        float e = 0.0934f;
        float apogee = 1.64f * AU_a;
        float perigee = 1.41f * AU_p;
        float a = (apogee + perigee) / 2;
        float b = a * Mathf.Pow((1 - Mathf.Pow(e, 2)), 0.5f);

        float[] planetData = { a, b, apogee, perigee, speedMultiplier };
        return planetData;
    }

    public float[] Jupiter()
    {
        float speedMultiplier = 1.979f * AU_s;
        float e = 0.048f;
        float apogee = 5.37f * AU_a;
        float perigee = 5.03f * AU_p;
        float a = (apogee + perigee) / 2;
        float b = a * Mathf.Pow((1 - Mathf.Pow(e, 2)), 0.5f);

        float[] planetData = { a, b, apogee, perigee, speedMultiplier };
        return planetData;
    }

    public float[] Saturn()
    {
        float speedMultiplier = 3.031f * AU_s;
        float e = 0.054f;
        float apogee = 9.96f * AU_a;
        float perigee = 9.20f * AU_p;
        float a = (apogee + perigee) / 2;
        float b = a * Mathf.Pow((1 - Mathf.Pow(e, 2)), 0.5f);

        float[] planetData = { a, b, apogee, perigee, speedMultiplier };
        return planetData;
    }

    public float[] Uranus()
    {
        float speedMultiplier = 4.338f * AU_s;
        float e = 0.047f;
        float apogee = 19.75f * AU_a;
        float perigee = 18.64f * AU_p;
        float a = (apogee + perigee) / 2;
        float b = a * Mathf.Pow((1 - Mathf.Pow(e, 2)), 0.5f);

        float[] planetData = { a, b, apogee, perigee, speedMultiplier };
        return planetData;
    }

    public float[] Neptune()
    {
        float speedMultiplier = 5.410f * AU_s;
        float e = 0.0086f;
        float apogee = 29.89f * AU_a;
        float perigee = 30.22f * AU_p;
        float a = (apogee + perigee) / 2;
        float b = a * Mathf.Pow((1 - Mathf.Pow(e, 2)), 0.5f);

        float[] planetData = { a, b, apogee, perigee, speedMultiplier };
        return planetData;
    }


}

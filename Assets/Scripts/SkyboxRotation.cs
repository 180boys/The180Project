using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotation : MonoBehaviour
{
    public float skiSpeedMultiplier;

    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skiSpeedMultiplier);
    }

}

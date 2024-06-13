using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    [SerializeField] List<Material> panoramaMats;
    public void EnablePanorama(int index)
    {
        RenderSettings.skybox = panoramaMats[index];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wwise_HealthCrate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    // Update is called once per frame
    public void OnEnter()
    {
        AkSoundEngine.PostEvent("Stop_HealthCrate", gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wwise_ChomperOnDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    // Update is called once per frame
    public void OnDeath()
    {
        AkSoundEngine.PostEvent("Play_ChomperDeath", gameObject);
        AkSoundEngine.PostEvent("Stop_ChomperGrunt", gameObject);
        AkSoundEngine.PostEvent("Play_WeaponHit", gameObject);
        AkSoundEngine.PostEvent("Play_ChomperEvaporate", gameObject);
    }
    
    

}

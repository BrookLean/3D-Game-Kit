using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wwise_BoxOnDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    // Update is called once per frame
    public void OnDeath()
    {
        AkSoundEngine.PostEvent("Play_DestructibleBox", gameObject);
        AkSoundEngine.PostEvent("Play_WeaponHit", gameObject);
    }
}

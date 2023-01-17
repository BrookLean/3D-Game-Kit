using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wwise_ui_back : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    // Update is called once per frame
    public void OnClick()
    {
        AkSoundEngine.PostEvent("Play_Close", gameObject);
    }
}

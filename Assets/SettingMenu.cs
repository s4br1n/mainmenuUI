using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Dropdown resolutionDd;
    Resolution[] resolutions;

    void Start(){
        resolutions = Screen.resolutions;
        resolutionDd.ClearOptions();
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
            
        }
        resolutionDd.AddOptions(options);
        resolutionDd.value = currentResolutionIndex;
        resolutionDd.RefreshShownValue();
    }

    public void SetResolution (int resolutionIndex){
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void setFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void MuteToggle(bool mute)
    {
        if (mute == true)
        {
            AudioListener.pause = true;
            Debug.Log("audio  muted");
        }
        else
        {
            AudioListener.pause = false;
            Debug.Log("audio unmuted");
        }
    }
}

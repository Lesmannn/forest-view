using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _bgmAudioSource;
    public bool isAudioEnabled = false;
    private static AudioManager _instance;
    private AudioSource audioSource;
    private int index = 0;

    public static AudioManager Instance { get { return _instance; } }
    private void Awake() 
    {   
       if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
            index = Random.Range(0, _bgmAudioSource.Count);
            DontDestroyOnLoad(this);
        }
        
    }
    public void PlayBgm()
    {
        audioSource = _bgmAudioSource[index];
        audioSource.Play();
    }
    public void UnloadPart()
    {
        for(int i = 0; i<_bgmAudioSource.Count; i++)
        {
            if (i != index)
            {
                Destroy(_bgmAudioSource[i].gameObject);
            }
        }
    }
    public void UnloadAll()
    {
        foreach (AudioSource AS in _bgmAudioSource)
        {
            Destroy(this.gameObject);
        }
    }
}


using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    [SerializeField]
    private AudioMixer audioMixer;

    [SerializeField]
    private Slider glissiereVolumeMusique; 

    [SerializeField]
    private Slider glissiereVolumeEffets;


    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //audioMixer.GetFloat("MusiqueVolume");
        //audioMixer.SetFloat("MusiqueVolume", -20f);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("MusiqueVolume", ConvertToLogarithmique(volume));
    }

    public void AjusteVolumeEffets(float volume){
        audioMixer.SetFloat("EffetsVolume", ConvertToLogarithmique(volume));
        audioSource.Play();
    }

    private float ConvertToLogarithmique(float volume){
        return Mathf.Log10(volume) * 20;
    }


    

    
}

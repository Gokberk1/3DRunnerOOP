using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _3DRunnerOOP.Abstract.Utilities;

namespace _3DRunnerOOP.Managers
{
    public class SoundManager : SingletonMonoBehaviourObject<SoundManager>
    {
        AudioSource[] _audioSource;

        private void Awake()
        {
            SingletonThisObject(this);

            _audioSource = GetComponentsInChildren<AudioSource>();
        } 

        public void PlaySoundWithCondition(int index)
        {
            if (!_audioSource[index].isPlaying)
            {
                _audioSource[index].Play();
            }
        }
        public void StopSound(int index)
        {
            if (_audioSource[index].isPlaying)
            {
                _audioSource[index].Stop();
            }
        }
        public void PlaySound(int index)
        {
            _audioSource[index].Play();
        }
    }
}



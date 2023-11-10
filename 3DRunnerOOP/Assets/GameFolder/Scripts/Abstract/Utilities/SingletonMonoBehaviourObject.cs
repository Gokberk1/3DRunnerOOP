using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace _3DRunnerOOP.Abstract.Utilities
{
    public class SingletonMonoBehaviourObject<T> : MonoBehaviour where T: Component 
    {
        public static T Instance { get; private set; }
        
        protected void SingletonThisObject(T entity)
        {
            if(Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}



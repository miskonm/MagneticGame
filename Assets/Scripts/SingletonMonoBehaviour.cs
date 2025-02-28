using System.Security.Cryptography;
using System.Threading.Tasks;
using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    #region Variables

    private static T instance;

    #endregion


    #region Properties

    public static T Instance => instance;

    #endregion


    #region Unity lifecycle

    protected void Awake()
    {
        if (instance != null)
        {
            // Dont do costils cuz u just wrong used singleton
            Destroy(gameObject);

            return;
        }

        instance = this as T;
        DontDestroyOnLoad(gameObject);
    }

    #endregion
}

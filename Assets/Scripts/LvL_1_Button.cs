using UnityEngine;
using UnityEngine.SceneManagement;


public class Lvl_Menu : MonoBehaviour
{
        public void Play_lvl_1()
        {
            SceneManager.LoadSceneAsync("lvl_1");
        }
        public void Play_lvl_2()
        {
            SceneManager.LoadSceneAsync("lvl_2");
        }
}   

using UnityEngine;
using UnityEngine.SceneManagement;


public class Main_menu : MonoBehaviour
{
        public void Play_Lvl_menu()
        {
            SceneManager.LoadSceneAsync("LvL_Menu");
        }
        
}
using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour
{
    public float speed;
    public Rigidbody rigid;
    public GameObject bombP;
    public int bombRes = 2;
    public GameObject bombExplose;
    public float rayon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    void FixedUpdate()
    {
        rigid.linearVelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            rigid.linearVelocity = (Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigid.linearVelocity = (Vector3.back * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigid.linearVelocity = (Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigid.linearVelocity = (Vector3.right * speed);
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && bombRes > 0){    
            StartCoroutine(PlaceBomb());
        }
    }

    private IEnumerator PlaceBomb(){
        GameObject bomb = Instantiate(bombP,this.transform.position,bombP.transform.rotation);
        bombRes--;
        yield return new WaitForSeconds(2f);
        Vector3 spawnPosz = new Vector3(bomb.transform.position.x + rayon,bomb.transform.position.y, bomb.transform.position.z);
        Vector3 spawnPoss = new Vector3(bomb.transform.position.x - rayon,bomb.transform.position.y, bomb.transform.position.z); 
        Vector3 spawnPosq = new Vector3(bomb.transform.position.x,bomb.transform.position.y, bomb.transform.position.z - rayon); 
        Vector3 spawnPosd = new Vector3(bomb.transform.position.x,bomb.transform.position.y, bomb.transform.position.z + rayon);  
        GameObject haut = Instantiate(bombExplose, spawnPosz, bombExplose.transform.rotation);
        GameObject bas = Instantiate(bombExplose, spawnPoss, bombExplose.transform.rotation);
        GameObject gauche = Instantiate(bombExplose, spawnPosq, bombExplose.transform.rotation);
        GameObject droite = Instantiate(bombExplose, spawnPosd, bombExplose.transform.rotation);
        Destroy(haut,0.1f);
        Destroy(bas,0.1f);
        Destroy(gauche,0.1f);
        Destroy(droite,0.1f);        
        Destroy(bomb);
        bombRes++;
    }

}
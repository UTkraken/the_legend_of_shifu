using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ennemyDetect : MonoBehaviour
{

    public int detectDirection = 0;//0 left | 1 Top | 2 Right | 3 Bottom
    public float detectRange = 5.0f;
    public float speed = 0.4f;
    public Animator animator;
    public Player_save pSave;

    bool checkForPlayer = true;
    bool walkToPlayer = false;
    RaycastHit2D hitMade;

    // Start is called before the first frame update
    void Start()
    {
        /*Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * detectRange, Color.red);
        Debug.Log(transform.position);
        Debug.Log(transform.TransformDirection(Vector3.forward));*/
    }

    // Update is called once per frame
    void Update()
    {
        if (checkForPlayer)
        {

            Vector2 direction = Vector2.up;
            switch (detectDirection)
            {
                case 0:
                    //direction = Vector2.up;
                    direction = -Vector2.right;
                    break;

                case 1:
                    //direction = Vector2.right;
                    direction = Vector2.up;
                    break;

                case 2:
                    //direction = -Vector2.up;
                    direction = Vector2.right;
                    break;

                case 3:
                    //direction = -Vector2.right;
                    direction = -Vector2.up;
                    break;
            }

            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 1 << LayerMask.NameToLayer("Ignore Raycast"));
            if (hit.collider != null)
            {
                Debug.Log("moving to " + hit.collider.name);
                //Debug.DrawLine(transform.position, hit.point, Color.red, 1);
                checkForPlayer = false;
                //freeze player
                Debug.Log(hit.collider);
                hit.collider.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                //switch player anim and save info
                hit.collider.GetComponent<Animator>().SetBool("running", false);
                pSave.savePlayerData();

                hitMade = hit;
                walkToPlayer = true;
                animator.SetBool("running", true);
                //todo play anim run
            }
        }

        if (walkToPlayer)
        {

            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, hitMade.point, step);
        } 



    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col);
        Debug.Log("TTTTTTTTTTTTTTTTTTTTT");

        walkToPlayer = false;
        animator.SetBool("running", false);

        //start the fight
        GameObject[] go = UnityEngine.SceneManagement.SceneManager.GetSceneByName("game_scene").GetRootGameObjects();
        foreach (GameObject objet in go)
        {
            objet.SetActive(false);
        }

        if (UnityEngine.SceneManagement.SceneManager.sceneCount > 1)
        {
            GameObject[] go2 = UnityEngine.SceneManagement.SceneManager.GetSceneByName("CardDrawTest").GetRootGameObjects();
            foreach (GameObject objet2 in go2)
            {
                objet2.SetActive(true);
            }
            UnityEngine.SceneManagement.SceneManager.SetActiveScene(UnityEngine.SceneManagement.SceneManager.GetSceneByName("CardDrawTest"));
        }


        //Debug.Log(col.gameObject);
    }
}


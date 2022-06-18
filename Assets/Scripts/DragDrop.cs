using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragDrop :  MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool dragging;
    bool on_enemy = false;
    bool on_hero = false;
    public Vector3 _oldPos;

    public void Update() {
        if (dragging) {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }

    public void OnPointerDown(PointerEventData eventData) {
        dragging = true;
        _oldPos = transform.position;
    }

    public void OnPointerUp(PointerEventData eventData) {
        dragging = false;
        if (on_enemy) {
            on_enemy = false;
            on_hero = false;
            switch(this.GetComponent<ThisCard>().id) {
                case 0:
                    Debug.Log("Pierre");
                    transform.position = _oldPos;
                    GameObject.Find("FightManager").GetComponent<FightManager>().Comparer(this.GetComponent<ThisCard>().id);
                    break;
                case 1:
                    Debug.Log("Feuille");
                    transform.position = _oldPos;
                    GameObject.Find("FightManager").GetComponent<FightManager>().Comparer(this.GetComponent<ThisCard>().id);
                    break;
                case 2:
                    Debug.Log("Ciseaux");
                    transform.position = _oldPos;
                    GameObject.Find("FightManager").GetComponent<FightManager>().Comparer(this.GetComponent<ThisCard>().id);
                    break;
            }
        }
        else {
            transform.position = _oldPos;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy"){
            on_enemy = true;
            Debug.Log("on him");
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        on_enemy = false;
    }

    // public void OnMouseUp()
    // {
    //     if (on_enemy) {
    //         switch(this.GetComponent<ThisCard>().id) {
    //             case 0:
    //                 Debug.Log("Pierre");
    //                 GameObject.Find("FightManager").GetComponent<FightManager>().Comparer(this.GetComponent<ThisCard>().id);
    //                 break;
    //             case 1:
    //                 Debug.Log("Feuille");
    //                 GameObject.Find("FightManager").GetComponent<FightManager>().Comparer(this.GetComponent<ThisCard>().id);
    //                 break;
    //             case 2:
    //                 Debug.Log("Ciseaux");
    //                 GameObject.Find("FightManager").GetComponent<FightManager>().Comparer(this.GetComponent<ThisCard>().id);
    //                 break;
    //         }
    //     }
    //}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RayCast : MonoBehaviour
{
    [SerializeField]float time;
    [SerializeField]float timePassed;
    [SerializeField]Text numero;
    bool check;
    bool Box1;
    bool Box2;
    bool Sphere;
    

    void Update()
    {
        RayCastFuncion();
        if(check)
        {
            if(timePassed < time)
            {
                timePassed += Time.deltaTime;
                numero.text = timePassed.ToString();
            }
            if(timePassed > time && Box1)
            {
                Menu1();
            }
            else if(timePassed > time && Box2)
            {
                Menu2();
            }
            else if(timePassed > time && Sphere)
            {
                Menu3();
            }

        }
    }

    void RayCastFuncion()
    {
        
        RaycastHit hit;
        Ray raycastnohit = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(raycastnohit, out hit))
            {
                if(hit.transform.gameObject.CompareTag("box1"))
                {
                    check = true;
                    Box1 = true;
                }
                else if(hit.transform.gameObject.CompareTag("box2"))
                {
                    check = true;
                    Box2 = true;

                }
                else if(hit.transform.gameObject.CompareTag("sphere"))
                {
                    check = true;
                    Sphere = true;
                }
            }

        }


        
    }

    void Menu1()
    {
        SceneManager.LoadScene(1);
        
    }
    void Menu2()
    {

        SceneManager.LoadScene(2);
    
    }
    void Menu3()
    {
        SceneManager.LoadScene(3);
    }
}

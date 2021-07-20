﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaDrop : MonoBehaviour
{
    int speed = 1; //속도 설정

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float yMove = speed * Time.deltaTime; //속도 설정
        this.transform.Translate(new Vector3(0, -yMove, 0)); // 떨어지는 동작

        // if (특정 범위 벗어남) : 원위치로 돌아가는 코드
        // 를 넣고 싶은데 어떡하지..

        if(gameObject.transform.localPosition.y <= -400f)
        {
            gameObject.SetActive(false);
        }

    }
}

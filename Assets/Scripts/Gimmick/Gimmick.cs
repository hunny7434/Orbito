﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Gimmick과 관련된 정보 및 컴포넌트들을 가지고 있는 클래스
/// </summary>
public class Gimmick : FieldObject
{
    public GimmickBehaviour Behaviour
    {
        get; private set;
    }


    private void Awake()
    {
        // Get Behaviour by something.
        // Json 데이터가 준비되면 Json을 통해서 받아올 것
        // Behaviour = ?;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData {

    public int level;

    public LevelData(GameController gameController) {

        level = gameController.level;

    }
}

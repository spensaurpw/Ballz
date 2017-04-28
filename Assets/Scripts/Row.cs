﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Row : MonoBehaviour {
	public enum SlotType{
		BLANK,
		TILE,
		BALL,
		POINT
	}

	public HorizontalLayoutGroup layout;

	private void Start() {
		LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
		layout.enabled = false;
	}
}

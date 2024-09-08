﻿// ==================================================
// 
//   Created by Atqa Munzir
// 
// ==================================================

using System;
using UnityEngine;
using UnityEngine.UI;

namespace QuackleBit
{
	public class MenuGroup : MonoBehaviour
	{
		[SerializeField] private Button _startButton;
		[SerializeField] private Button _optionButton;
		[SerializeField] private Button _quitButton;
		
		public Action<string> _callback; 
		
		private void Start()
		{
			_startButton.onClick.AddListener(OnStartButton);
			_optionButton.onClick.AddListener(OnOptionButton);
			_quitButton.onClick.AddListener(OnQuitButton);
		}
		
		private void OnStartButton()
		{
			SceneHandler.Instance.SetNextScene("Backstory");
			SceneHandler.Instance.LoadNextScene();
		}
		
		private void OnOptionButton()
		{
			_callback?.Invoke("Option");
		}
		
		private void OnQuitButton()
		{
			_callback?.Invoke("Quit");
		}
	}
}
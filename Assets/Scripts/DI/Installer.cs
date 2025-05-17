using System;
using System.Collections;
using UnityEngine;
public class Installer : MonoBehaviour {
	
	private static DIContainer container;
	
	
	
	void Awake() {		
		container = new DIContainer();		
		container.Register<IProfileSelectionView>(GetComponent<ProfileSelectionView>());
		container.Register<IActiveProfileView>(GetComponent<ActiveProfileView>());
		container.Register<IGUIManager>(GetComponent<GUIManager>());
	}
	
	
	public static T GetService<T>() => container.Resolve<T>();
	private void OnDestroy() {
		container.Dispose();
	}
}

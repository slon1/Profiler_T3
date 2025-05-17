using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Installer : MonoInstaller {
	public override void InstallBindings() {	
		Container.Bind<IProfileSelectionView>().FromComponentInHierarchy().AsSingle();
		Container.Bind<IActiveProfileView>().FromComponentInHierarchy().AsSingle();
		Container.Bind<IGUIManager>().FromComponentInHierarchy().AsSingle();
		
	}
}

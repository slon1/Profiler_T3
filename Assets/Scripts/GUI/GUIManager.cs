using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GUIManager : MonoBehaviour, IGUIManager {
	
	private Dictionary<PanelId, IPage> panels;
	[SerializeField]
	private List<ScrAbs> screens;

		

	public void Initialize() {
		panels = screens.ToDictionary(panel => panel.PanelID, panel => (IPage)panel);
		EventBus.Bus.AddListener<ButtonId>(EventId.MenuEvent, OnMenuEvent);		

	}

	private void OnMenuEvent(ButtonId id) {
		switch (id) {
			case ButtonId.GameBtn:
				ShowPanel(PanelId.GamePanel);				
				break;						
			case ButtonId.MenuBtn:
				ShowPanel(PanelId.MenuPanel);				
				break;
			case ButtonId.SettingsBtn:
				ShowPanel(PanelId.SettingsPanel);
				break;
			case ButtonId.ProfileBtn:
				ShowPanel(PanelId.ProfilePanel);
				break;
			case ButtonId.SoundOn:
				Execute(PanelId.SettingsPanel, PageActionId.SoundOn);
				break;
			case ButtonId.SoundOff:
				Execute(PanelId.SettingsPanel, PageActionId.SoundOff);				
				break;
			default:
				break;
		}
	}

	
	public void ShowPanelModal(PanelId panelId, bool show) {
		if (show) {
			panels[panelId].Show();
		}
		else {
			panels[panelId].Hide();
		}



	}
	public void ShowPanel(PanelId panelId) {
		foreach (var panel in panels.Values) {
			if (panel.IsStatic()) {
				continue;
			}
			if (panel.PanelID == panelId) {
				panel.Show();
			}
			else {
				panel.Hide();
			}
		}

	}

	private void OnDestroy() {
		
		panels = null;
		EventBus.Bus.RemoveListener<ButtonId>(EventId.MenuEvent, OnMenuEvent);
	}


	public void Execute<T>(PanelId panelId, PageActionId action, T param) {
		panels[panelId].Execute(action, param);
	}


	public void Execute(PanelId panelId, PageActionId action) {
		panels[panelId].Execute(action);
	}

	
}

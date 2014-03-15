#pragma strict

// Draw the damage and the armor with bars in an Editor Window
	
	class ProgressBarUpdater extends EditorWindow {
	
	    var armor : int = 20;
	    var damage : int = 80;
	
		@MenuItem("Examples/Display Info")
	    static function Init() {
	        var window = GetWindow(ProgressBarUpdater);
	        window.Show();
	    }
	    
	    function OnGUI() {
	        //armor = EditorGUI.IntSlider(Rect(3,3,position.width-6,15), "Armor:", armor, 0, 100);
	        //damage = EditorGUI.IntSlider(Rect(3,25,position.width-6,15), "Damage:", damage, 0, 100);
			
	        EditorGUI.ProgressBar(Rect(3,45,position.width-6,20),armor/100.0, "Armor");
	        EditorGUI.ProgressBar(Rect(3,70,position.width-6,20),damage/100.0, "Damage");
	    }
	}
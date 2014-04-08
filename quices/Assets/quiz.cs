using UnityEngine;
using System.Collections;

public class quiz : MonoBehaviour {

	private Rect windowRect = new Rect (20, 20, 200, 800);

	public string textarea = "";
	public string textarea1 = "";
	public string textarea2 = "";
	public string textarea3 = "";
	void OnGUI(){
		
		
		
				windowRect = GUI.Window (0, windowRect, Window, "Tarea y actividades");

		}
	void Window (int windowID) {
		textarea1 = GUILayout.TextArea (textarea1, 400);
		if (GUILayout.Button("tarea"))
			
		{
			
			
			textarea+=textarea1+"\n";
			textarea1="";
			
			
		}
		textarea = GUILayout.TextArea (textarea, 200);
	
				
			textarea2 = GUILayout.TextArea (textarea2, 200);
			if (GUILayout.Button("Actividades"))
				
			{
				
				
				textarea3=textarea2+"\n"+textarea3;
				textarea2="";
				
				
			}
			textarea3 = GUILayout.TextArea (textarea3, 200);

	}
}

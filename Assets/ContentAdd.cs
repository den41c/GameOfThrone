using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public interface IMenu
{
	void OnMouseDown();
}
public class ContentAdd : MonoBehaviour, IMenu
{
	public RectTransform prefarb;
	public Text countText;
	public RectTransform content;

    // Start is called before the first frame update
    void Start()
    {
        
    }
	public void OnMouseDown()
	{
		StartCoroutine(GetItems(int.Parse(countText.text) , result => Funkk(result)));
	}

	private void Funkk(List<Model> models)
	{
		foreach (Transform child in content)
		{
			Destroy(child.gameObject);
		}
		foreach (var model in models)
		{
			var instance = Instantiate(prefarb.gameObject) as GameObject;
			instance.transform.SetParent(content, false);
			InizializeItem(instance, model);
		}
	}

	private void InizializeItem(GameObject instance, Model model)
	{
		var view = new TestItemView(instance.transform);
		view.button./*GetComponent<Text>().*/GetComponentsInChildren<Text>().ToList().First().text = model.buttonText;
		view.button.onClick.AddListener(() => { Debug.Log(view.button.name + "2");  });
	}

	private class Model
	{
		public string buttonText;
	}

	private class TestItemView
	{
		public Button button;
		public TestItemView(Transform rootView)
		{
			button = rootView.Find("Button").GetComponent<Button>();
		}
	}

	IEnumerator GetItems(int count, Action<List<Model>> callback)
	{
		yield return new WaitForSeconds(1f);
		var result = new List<Model>();


		for (int i = 0; i < count; i++)
		{
			result.Add(new Model() { buttonText = "text" + i.ToString() });
		}
		callback(result);
	}
	// Update is called once per frame
	void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using Project.Scripts.Attributes;
using TMPro;
using UnityEngine;

namespace Project.Scripts
{
    public class TagSelectorDemo : MonoBehaviour
    {
        [SerializeField, TagSelector] private string singleTag;
        [SerializeField, TagSelector] private string[] multipleTagsArray;
        [SerializeField, TagSelector] private List<string> multipleTagsList;
        
        [Header("Debug Controls")]
        [SerializeField] private float delayBetweenPrints = 1f;
        [SerializeField] private TextMeshProUGUI singleTagText;
        [SerializeField] private TextMeshProUGUI multipleTagsArrayText;
        [SerializeField] private TextMeshProUGUI multipleTagsListText;
        
        private void Start()
        {
            StartCoroutine(DebugTags());
        }

        private IEnumerator DebugTags()
        {
            while (true)
            {
                singleTagText.SetText($"Single tag: {singleTag}");
                multipleTagsArrayText.SetText($"Multiple tags array: {string.Join(", ", multipleTagsArray)}");
                multipleTagsListText.SetText($"Multiple tags list: {string.Join(", ", multipleTagsList)}");
                yield return new WaitForSeconds(delayBetweenPrints);
            }
        }
    }
} 

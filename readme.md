# Unity Tag Selector
A simple tool to allow associating existing tags with a string property. Can be used with string, string[] or List<string> properties.

# Demo

## Code
```csharp
public class TagSelectorDemo : MonoBehaviour
{
    [SerializeField, TagSelector] private string singleTag;
    [SerializeField, TagSelector] private string[] multipleTagsArray;
    [SerializeField, TagSelector] private List<string> multipleTagsList;
}
```

## How it works
![Demo](./readme_imgs/demo.gif)
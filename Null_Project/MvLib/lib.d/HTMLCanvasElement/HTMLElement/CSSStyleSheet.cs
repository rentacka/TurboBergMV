
public class CSSStyleSheet : StyleSheet
{
    protected CSSStyleSheet() : base()
    {

    }
    public CSSRuleList cssRules;
    public string cssText;
    public string href;
    public string id;
    public StyleSheetList imports;
    public bool isAlternate;
    public bool isPrefAlternate;
    public CSSRule ownerRule;
    public Element owningElement;
    public StyleSheetPageList pages;
    public bool readOnly;
    public CSSRuleList rules;
    public float addImport(string bstrURL, float lIndex = default(float))
    {
        throw new System.NotImplementedException();
    }
    public float addPageRule(string bstrSelector, string bstrStyle, float lIndex = default(float))
    {
        throw new System.NotImplementedException();
    }
    public float addRule(string bstrSelector, string bstrStyle = default(string), float lIndex = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void deleteRule(float index = default(float))
    {
        throw new System.NotImplementedException();
    }
    public float insertRule(string rule, float index = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void removeImport(float lIndex)
    {
        throw new System.NotImplementedException();
    }
    public void removeRule(float lIndex)
    {
        throw new System.NotImplementedException();
    }
}

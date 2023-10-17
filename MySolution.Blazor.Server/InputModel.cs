using System;
using DevExpress.ExpressApp.Blazor.Components.Models;
// ...
public class InputModel : ComponentModelBase
{
    public int Value
    {
        get => GetPropertyValue<int>();
        set => SetPropertyValue(value);
    }
    public bool ReadOnly
    {
        get => GetPropertyValue<bool>();
        set => SetPropertyValue(value);
    }
    // ...
    public void SetValueFromUI(int value)
    {
        SetPropertyValue(value, notify: false, nameof(Value));
        ValueChanged?.Invoke(this, EventArgs.Empty);
    }
    public event EventHandler ValueChanged;
}
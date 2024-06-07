namespace MauiApp2;

public class ReportStateContainer
{
    public Blazored.FluentValidation.FluentValidationValidator FluentValidationValidator { get; set; }
    public bool isTouched = false;
    public void OnTouched(bool b)
    {
        if (b)
            isTouched = true;
    }
}
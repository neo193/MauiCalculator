namespace HelloMaui.View;

public partial class CalcMainPage : ContentPage
{
    string a = string.Empty;
    string b = string.Empty;
    string Operator = string.Empty;

    private void Number_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        b += button.Text;
        ExpressionField.Text = b;
    }
    private void Operator_Clicked(object sender, EventArgs e)
    {
        Button button = ( Button )sender;
        Operator = button.Text;
        a = b;
        b = string.Empty;

    }
    private void Equals_Clicked(object sender, EventArgs e)
    {
        double num1 = Convert.ToDouble(a);
        double num2 = Convert.ToDouble(b);
        double result = 0;
        switch(Operator)
        {
            case "+": result = num1 + num2; 
                break;
            case "-": result = num1 - num2;
                break;
            case "*": result = num1 * num2;
                break;
            case "/": result = num1 / num2;
                break;
        }
        Answer.Text = result.ToString();
        b = result.ToString();
    }
    private void Reset_Clicked(object sender, EventArgs e)
    {
        a = b= string.Empty;
        Operator = string.Empty;
        ExpressionField.Text = "0";
        Answer.Text= "";
    }
    public CalcMainPage()
    {
        InitializeComponent();
    }

    
}
using System;
namespace HelloMaui.View;

public partial class CalcMainPage : ContentPage
{
    string a = string.Empty;
    string b = string.Empty;
    string Operator = string.Empty;
    double result;

    private void Number_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        b += button.Text;
        if(ExpressionField.Text == "0" || String.IsNullOrEmpty(ExpressionField.Text))
        {
            ExpressionField.Text = b;
        }
        else
        {
            ExpressionField.Text += button.Text;
        }
        if (!String.IsNullOrEmpty(a))
        {
            double num1 = Convert.ToDouble(a);
            double num2 = Convert.ToDouble(b);
            result = 0;
            switch (Operator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            Answer.Text = result.ToString();
            
        }
    }
    private void Operator_Clicked(object sender, EventArgs e)
    {
        Button button = ( Button )sender;
        Operator = button.Text;
        if (String.IsNullOrEmpty(a))
        {
            a = b;
            b = string.Empty;
            ExpressionField.Text += Operator;
        }
        else
        {
            a = result.ToString();
            b = string.Empty;
            ExpressionField.Text += Operator;
        }
        //a = b;
        //b = string.Empty;
        //ExpressionField.Text += Operator;
    }
    private void Equals_Clicked(object sender, EventArgs e)
    {
        Answer.Text = string.Empty;
        ExpressionField.Text = result.ToString();
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
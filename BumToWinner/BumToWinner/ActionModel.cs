namespace BumToWinner;

/// <summary>
/// Especting number from 0 - 9, distributes the input to the Actions
/// </summary>

public class ActionModel
{
    private int _number = 1; 
    private string _output;

    public ActionModel(int number)
    {
        
    }

    public void Desicion(int number)
    {
        switch (number)
        {
            case 0:
                _output = "You choose None";
                break;
            case 1:
                _output = "You choose Happiness";
                break;
            case 2:
                _output = "You choose Health";
                break;
            case 3:
                _output = "You choose Job";
                break;
            case 4:
                _output = "You choose Housing";
                break;
            case 5:
                _output = "You choose Vehicle";
                break;
            case 6:
                _output = "You choose Food";
                break;
            case 7:
                _output = "You choose Education";
                break;
            case 8:
                _output = "You choose Clothing";
                break;
            case 9:
                _output = "You choose Suicide";
                break;
        }
    }
}